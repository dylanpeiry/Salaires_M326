using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaires.Classes
{
    class EmployeeSale : Employee
    {
        private double _revenues;
        public double Revenues { get => _revenues; set => _revenues = value; }

        public EmployeeSale(string lastName, string firstName, DateTime birthDate, DateTime entryDate, double revenues) : base(lastName, firstName, birthDate, entryDate)
        {
            Revenues = revenues;
        }


        public override double CalculateSalary()
        {
            return ((Revenues / 100) * 20) + 400;
        }
    }
}
