using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaires.Classes
{
    class EmployeeProduction : Employee
    {
        private int _quantityProduced;
        public int QuantityProduced { get => _quantityProduced; set => _quantityProduced = value; }

        public EmployeeProduction(string lastName, string firstName, DateTime birthDate, DateTime entryDate, int quantityProduced) : base(lastName, firstName, birthDate, entryDate)
        {
            QuantityProduced = quantityProduced;
        }


        public override double CalculateSalary()
        {
            return (QuantityProduced * 5);
        }
    }
}
