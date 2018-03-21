using Salaires.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salaires
{
    public partial class SAddEmployeeView : Form
    {
        private Staff _s;
        private SView _frm;
        internal Staff S { get => _s; set => _s = value; }
        public SView Frm { get => _frm; set => _frm = value; }

        public SAddEmployeeView(Staff s, SView frm)
        {
            InitializeComponent();
            S = s;
            Frm = frm;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName, lastName, sector;
            DateTime birthDate, entryDate;
            bool atRisk, more;

            firstName = tbxFirstName.Text;
            lastName = tbxLastName.Text;
            birthDate = dtpBirth.Value;
            entryDate = dtpEntry.Value;
            sector = cbxSector.SelectedItem.ToString();
            atRisk = cbAtRisk.Checked;
            more = cbAddMore.Checked;

            if (sector == "Production")
                if (atRisk)
                    S.AddEmployee(new EmployeeProductionAtRisk(lastName, firstName, birthDate, entryDate, 30));
                else
                    S.AddEmployee(new EmployeeProduction(lastName, firstName, birthDate, entryDate, 17));
            else if (sector == "Vente")
                S.AddEmployee(new EmployeeSale(lastName, firstName, birthDate, entryDate, 1500));
            else if (sector == "Manutention")
                if (atRisk)
                    S.AddEmployee(new EmployeeHandlingAtRisk(lastName, firstName, birthDate, entryDate, 57));
                else
                    S.AddEmployee(new EmployeeHandling(lastName, firstName, birthDate, entryDate, 35));
            else if (sector == "Représentation")
                S.AddEmployee(new EmployeeRepresentation(lastName, firstName, birthDate, entryDate, 3500));

            if (more)
            {
                tbxFirstName.Clear();
                tbxLastName.Clear();
                cbxSector.SelectedIndex = -1;
                cbAtRisk.Checked = false;
                dtpBirth.Value = DateTime.Now;
                dtpEntry.Value = DateTime.Now;
            }
            else
            {
                this.Close();
                Frm.ShowEmployees();
            }
        }

        private void cbxSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSector.SelectedIndex != -1)
            {
                string sector = cbxSector.SelectedItem.ToString();
                cbAtRisk.Enabled = (sector == "Production" || sector == "Manutention") ? true : false;
            }
        }
    }
}
