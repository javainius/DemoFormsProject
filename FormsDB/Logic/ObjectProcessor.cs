using FormsDB.Contexts;
using FormsDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormsDB.Logic
{
    public static class ObjectProcessor
    {
        public static List<PersonDbModel> GetAllPersons()
        {
            using (var context = new MainContext())
            {
                return context.Persons.ToList();
            }
        }
        public static void AddPersonsInfoToDatabase(PersonDbModel data)
        {
            using (var context = new MainContext())
            {
                context.Persons.Add(data);
                context.SaveChanges();
            }
        }
    }
}
