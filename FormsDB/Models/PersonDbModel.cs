using System;
using System.Collections.Generic;
using System.Text;

namespace FormsDB.Models
{

    public class PersonDbModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int id { get; set; }
        public PersonDbModel(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public PersonDbModel() { }
    }
}

