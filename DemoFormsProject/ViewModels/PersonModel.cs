using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFormsProject.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public PersonModel(string firstName, string lastName, string age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public PersonModel() { }
    }
}
