using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaires.Classes
{
    public abstract class Employee
    {
        private string _lastName;
        private string _firstName;
        private DateTime _birthDate;
        private DateTime _entryDate;


        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public DateTime EntryDate { get => _entryDate; set => _entryDate = value; }

        public Employee(string lastName, string firstName, DateTime birthDate, DateTime entryDate)
        {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            EntryDate = entryDate;
        }


        public abstract double CalculateSalary();

        public string GetName()
        {
            return String.Format("L'employé {0} {1}", FirstName, LastName);
        }
    }
}
