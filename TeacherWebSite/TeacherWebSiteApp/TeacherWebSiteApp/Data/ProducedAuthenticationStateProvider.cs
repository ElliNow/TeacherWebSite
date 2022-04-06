using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TeacherWebSiteApp.Data
{
    public class ProducedAuthenticationStateProvider : AuthenticationStateProvider
    {
        IDbContextFactory<TeacherContext> _dbFactory;
        ILocalStorageService _localStorage;

        public ProducedAuthenticationStateProvider(ILocalStorageService localStorage,IDbContextFactory<TeacherContext> dbFactory)
        {
            _localStorage = localStorage;
            _dbFactory = dbFactory;
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
    }
}
