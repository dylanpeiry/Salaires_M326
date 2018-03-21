using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaires.Classes
{
    class EmployeeProductionAtRisk : EmployeeProduction, EmployeeAtRisk
    {
        private int _primeRisk;
        public int PrimeRisk { get => _primeRisk; set => _primeRisk = value; }

        public EmployeeProductionAtRisk(string lastName, string firstName, DateTime birthDate, DateTime entryDate, int quantityProduced) : base(lastName, firstName, birthDate, entryDate, quantityProduced)
        {
            PrimeRisk = 300;
        }


        public int GetPrimeRisk()
        {
            return PrimeRisk;
        }
    }
}
