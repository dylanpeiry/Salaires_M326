using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaires.Classes
{
    public class Staff
    {
        private List<Employee> _employees = new List<Employee>();

        private List<EmployeeAtRisk> _employeesAtRisk = new List<EmployeeAtRisk>();

        public List<Employee> Employees { get => _employees; set => _employees = value; }
        public List<EmployeeAtRisk> EmployeesAtRisk { get => _employeesAtRisk; set => _employeesAtRisk = value; }

        public void AddEmployee(Employee e)
        {
            Employees.Add(e);
            if (e is EmployeeHandlingAtRisk || e is EmployeeProductionAtRisk)
                EmployeesAtRisk.Add((EmployeeAtRisk)e);

        }

        public void CalculateSalaries()
        {

        }

        public double AverageSalary()
        {
            return 0.0;
        }

        public void ShowEmployeesAtRisk()
        {

        }

    }
}
