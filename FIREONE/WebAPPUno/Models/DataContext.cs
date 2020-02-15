using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPPUno.Models
{
    public class DataContext :DbContext
    {
        public DataContext():base("DefaultConecction")
        {

        }

        public System.Data.Entity.DbSet<WebAPPUno.Models.Person> People { get; set; }
    }
}