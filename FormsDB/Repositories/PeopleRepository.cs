using FormsDB.Contexts;
using FormsDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormsDB.Repositories
{
    public static class PeopleRepository
    {
        public static List<PersonDbModel> GetPeople()
        {
            using (var context = new MainContext())
            {
                return context.People.ToList();
            }
        }
        public static void CreatePerson(PersonDbModel data)
        {
            using (var context = new MainContext())
            {
                context.People.Add(data);
                context.SaveChanges();
            }
        }
    }
}
