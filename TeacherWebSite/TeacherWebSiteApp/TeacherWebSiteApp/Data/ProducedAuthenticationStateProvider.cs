using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TeacherWebSiteApp.Data.Auth;
using TeacherWebSiteApp.Services;

namespace TeacherWebSiteApp.Data
{
    public class ProducedAuthenticationStateProvider : AuthenticationStateProvider
    {
        IDbContextFactory<TeacherContext> _dbFactory;
        ILocalStorageService _localStorage;
        ICryptographer _cryptographer;

        public ProducedAuthenticationStateProvider(ILocalStorageService localStorage,
            IDbContextFactory<TeacherContext> dbFactory, ICryptographer cryptographer)
        {
            _localStorage = localStorage;
            _dbFactory = dbFactory;
            _cryptographer = cryptographer;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var token = await _localStorage.GetItemAsync<string>("token");
                if (token == null || token.Length < 2) return await Task.FromResult(
                    new AuthenticationState(new ClaimsPrincipal(new ClaimsPrincipal())));
                using(var context = _dbFactory.CreateDbContext())
                {
                    var user = context.Users.Find(Convert.ToInt32(token[0].ToString()));
                    if(user != null && token.Substring(1) == user.Password)
                    {
                        var identity = new ClaimsIdentity(new[]
                            {
                            new Claim(ClaimTypes.Role,"admin"),
                            new Claim(ClaimTypes.Name,user.Name)
                        });
                        var state = new ClaimsPrincipal(identity);
                        return await Task.FromResult(new AuthenticationState(state));
                    }
                    else
                    {
                        var state = new ClaimsPrincipal(new ClaimsPrincipal());
                        return await Task.FromResult(new AuthenticationState(state));
                    }
                }
            }
            catch
            {
                var state = new ClaimsPrincipal(new ClaimsPrincipal());
                return await Task.FromResult(new AuthenticationState(state));
            }
        }

        public void Logout()
        {
            _localStorage.RemoveItemAsync("token");
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }


        public string Login(string login, string password)
        {
            try
            {
                using (var context = _dbFactory.CreateDbContext())
                {
                    var user = context.Users.FirstOrDefault(x => x.Login == login);
                    if (user == null) return "Пользователь не найден.";
                    if (_cryptographer.GetHashString(password) == user.Password)
                    {
                        _localStorage.SetItemAsync("token", $"{user.Id}{user.Password}");
                        var identity = new ClaimsIdentity(new[]
                        {
                            new Claim(ClaimTypes.Role,"admin"),
                            new Claim(ClaimTypes.Name,user.Name),
                        });

                        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
                        return null;
                    }
                    else { return $"Неверный пароль для пользователя {user.Name}"; }
                }
            }
            catch (Exception ex)
            {
                return ex.Message + "\n" + ex.InnerException;
            }
        }

        public string Register(string login, string password, string name)
        {
            try
            {
                using (var context = _dbFactory.CreateDbContext())
                {
                    if (context.Users.FirstOrDefault(x => x.Login == login) != null) return "Пользователь с таким логином уже существует.";

                    var user = new User { Name = name, Login = login, Password = _cryptographer.GetHashString(password) };
                    context.Users.Add(user);
                    context.SaveChanges();

                    return null;
                }
            }
            catch (Exception ex)
            {
                return ex.Message + "\n" + ex.InnerException;
            }
        }
    }
}
