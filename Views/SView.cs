using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salaires.Classes;

namespace Salaires
{
    public partial class SView : Form
    {
        private Staff _s;
        internal Staff S { get => _s; set => _s = value; }

        public SView()
        {
            InitializeComponent();
            S = new Staff();
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            SAddEmployeeView _frmAddEmployee = new SAddEmployeeView(S,this);
            _frmAddEmployee.ShowDialog();
        }

        public void ShowEmployees()
        {
            foreach (Employee S in S.Employees)
            {
                dgvEmployees.Rows.Add(S.FirstName, S.LastName, S.BirthDate, S.EntryDate);
            }
        }
    }
}
