using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherWebSiteApp.Data.Models
{

    public interface IEntity
    {
        public int Id { get; set; }
    }
    public class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
