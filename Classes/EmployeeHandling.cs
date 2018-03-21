using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaires.Classes
{
    class EmployeeHandling : Employee
    {
        private int _workingHours;
        public int WorkingHours { get => _workingHours; set => _workingHours = value; }

        public EmployeeHandling(string lastName, string firstName, DateTime birthDate, DateTime entryDate, int workingHours) : base(lastName, firstName, birthDate, entryDate)
        {
            WorkingHours = workingHours;
        }


        public override double CalculateSalary()
        {
            return (WorkingHours * 70);
        }
    }
}
