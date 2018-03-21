using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaires.Classes
{
    class EmployeeRepresentation : Employee
    {
        private double _revenues;
        public double Revenues { get => _revenues; set => _revenues = value; }

        public EmployeeRepresentation(string lastName, string firstName, DateTime birthDate, DateTime entryDate, double revenues) : base(lastName, firstName, birthDate, entryDate)
        {
            Revenues = revenues;
        }


        public override double CalculateSalary()
        {
            return ((Revenues / 100) * 20) + 800;
        }
    }
}
