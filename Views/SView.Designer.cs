namespace Salaires
{
    partial class SView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.pnlEmployeesManagement = new System.Windows.Forms.Panel();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmployeesAtRisk = new System.Windows.Forms.Button();
            this.btnAverageSalary = new System.Windows.Forms.Button();
            this.btnEmployeesSalaries = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.pnlEmployees.SuspendLayout();
            this.pnlEmployeesManagement.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToResizeColumns = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colBirthDate,
            this.colEntryDate});
            this.dgvEmployees.Location = new System.Drawing.Point(12, 11);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEmployees.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvEmployees.ShowEditingIcon = false;
            this.dgvEmployees.Size = new System.Drawing.Size(426, 144);
            this.dgvEmployees.TabIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.HeaderText = "Prénom";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Nom";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colBirthDate
            // 
            this.colBirthDate.HeaderText = "Date de naissance";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.ReadOnly = true;
            // 
            // colEntryDate
            // 
            this.colEntryDate.HeaderText = "Date d\'entrée";
            this.colEntryDate.Name = "colEntryDate";
            this.colEntryDate.ReadOnly = true;
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.dgvEmployees);
            this.pnlEmployees.Location = new System.Drawing.Point(170, 12);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(452, 166);
            this.pnlEmployees.TabIndex = 1;
            // 
            // pnlEmployeesManagement
            // 
            this.pnlEmployeesManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployeesManagement.Controls.Add(this.btnDeleteEmployee);
            this.pnlEmployeesManagement.Controls.Add(this.btnAddEmployee);
            this.pnlEmployeesManagement.Location = new System.Drawing.Point(13, 12);
            this.pnlEmployeesManagement.Name = "pnlEmployeesManagement";
            this.pnlEmployeesManagement.Size = new System.Drawing.Size(150, 166);
            this.pnlEmployeesManagement.TabIndex = 2;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Enabled = false;
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(3, 41);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(143, 23);
            this.btnDeleteEmployee.TabIndex = 1;
            this.btnDeleteEmployee.Text = "Supprimer l\'employé";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Location = new System.Drawing.Point(3, 12);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(143, 23);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Ajouter un employé";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEmployeesAtRisk);
            this.panel1.Controls.Add(this.btnAverageSalary);
            this.panel1.Controls.Add(this.btnEmployeesSalaries);
            this.panel1.Location = new System.Drawing.Point(13, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 40);
            this.panel1.TabIndex = 3;
            // 
            // btnEmployeesAtRisk
            // 
            this.btnEmployeesAtRisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeesAtRisk.Location = new System.Drawing.Point(451, 8);
            this.btnEmployeesAtRisk.Name = "btnEmployeesAtRisk";
            this.btnEmployeesAtRisk.Size = new System.Drawing.Size(143, 23);
            this.btnEmployeesAtRisk.TabIndex = 4;
            this.btnEmployeesAtRisk.Text = "Employés à risques";
            this.btnEmployeesAtRisk.UseVisualStyleBackColor = true;
            // 
            // btnAverageSalary
            // 
            this.btnAverageSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAverageSalary.Location = new System.Drawing.Point(203, 8);
            this.btnAverageSalary.Name = "btnAverageSalary";
            this.btnAverageSalary.Size = new System.Drawing.Size(195, 23);
            this.btnAverageSalary.TabIndex = 3;
            this.btnAverageSalary.Text = "Salaire moyen des employés";
            this.btnAverageSalary.UseVisualStyleBackColor = true;
            // 
            // btnEmployeesSalaries
            // 
            this.btnEmployeesSalaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeesSalaries.Location = new System.Drawing.Point(7, 8);
            this.btnEmployeesSalaries.Name = "btnEmployeesSalaries";
            this.btnEmployeesSalaries.Size = new System.Drawing.Size(143, 23);
            this.btnEmployeesSalaries.TabIndex = 2;
            this.btnEmployeesSalaries.Text = "Salaires employés";
            this.btnEmployeesSalaries.UseVisualStyleBackColor = true;
            // 
            // SView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 234);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlEmployeesManagement);
            this.Controls.Add(this.pnlEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SView";
            this.Text = "Gestion des employés";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployeesManagement.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.Panel pnlEmployeesManagement;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmployeesAtRisk;
        private System.Windows.Forms.Button btnAverageSalary;
        private System.Windows.Forms.Button btnEmployeesSalaries;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntryDate;
    }
}

