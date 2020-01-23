using FormsDB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace FormsDB.Contexts
{
    public class MainContext : DbContext
    {
        public DbSet<PersonDbModel> People { get; set; }
        public MainContext()
            : base("data source = (localdb)\\MSSQLLocalDB; Initial Catalog = FormDB; integrated security = SSPI")
        {

        }
    }
}
