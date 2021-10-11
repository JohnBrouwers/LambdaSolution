using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaConsole.Generics
{
    public class Person
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public Person(int id, string firstname, string surname)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Surname = surname;
        }
    }
}
