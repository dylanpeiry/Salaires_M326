namespace Salaires
{
    partial class SAddEmployeeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.dtpEntry = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbAddMore = new System.Windows.Forms.CheckBox();
            this.cbxSector = new System.Windows.Forms.ComboBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.cbAtRisk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(9, 9);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(58, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Prénom";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(12, 25);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(140, 21);
            this.tbxFirstName.TabIndex = 1;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(12, 107);
            this.dtpBirth.MaxDate = new System.DateTime(2018, 3, 21, 0, 0, 0, 0);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(140, 21);
            this.dtpBirth.TabIndex = 3;
            this.dtpBirth.Value = new System.DateTime(2018, 3, 21, 0, 0, 0, 0);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(12, 65);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(140, 21);
            this.tbxLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(9, 49);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(38, 15);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Nom";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(9, 89);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(122, 15);
            this.lblBirthDate.TabIndex = 5;
            this.lblBirthDate.Text = "Date de naissance";
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryDate.Location = new System.Drawing.Point(9, 130);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(94, 15);
            this.lblEntryDate.TabIndex = 6;
            this.lblEntryDate.Text = "Date d\'entrée";
            // 
            // dtpEntry
            // 
            this.dtpEntry.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntry.Location = new System.Drawing.Point(12, 148);
            this.dtpEntry.Name = "dtpEntry";
            this.dtpEntry.Size = new System.Drawing.Size(140, 21);
            this.dtpEntry.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ajouter l\'employé";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbAddMore
            // 
            this.cbAddMore.AutoSize = true;
            this.cbAddMore.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddMore.Location = new System.Drawing.Point(23, 271);
            this.cbAddMore.Name = "cbAddMore";
            this.cbAddMore.Size = new System.Drawing.Size(117, 19);
            this.cbAddMore.TabIndex = 9;
            this.cbAddMore.Text = "Ajouter plusieurs";
            this.cbAddMore.UseVisualStyleBackColor = true;
            // 
            // cbxSector
            // 
            this.cbxSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSector.FormattingEnabled = true;
            this.cbxSector.Items.AddRange(new object[] {
            "Vente",
            "Manutention",
            "Production",
            "Représentation"});
            this.cbxSector.Location = new System.Drawing.Point(12, 190);
            this.cbxSector.Name = "cbxSector";
            this.cbxSector.Size = new System.Drawing.Size(140, 21);
            this.cbxSector.TabIndex = 5;
            this.cbxSector.SelectedIndexChanged += new System.EventHandler(this.cbxSector_SelectedIndexChanged);
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSector.Location = new System.Drawing.Point(9, 172);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(56, 15);
            this.lblSector.TabIndex = 11;
            this.lblSector.Text = "Secteur";
            // 
            // cbAtRisk
            // 
            this.cbAtRisk.AutoSize = true;
            this.cbAtRisk.Enabled = false;
            this.cbAtRisk.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAtRisk.Location = new System.Drawing.Point(42, 217);
            this.cbAtRisk.Name = "cbAtRisk";
            this.cbAtRisk.Size = new System.Drawing.Size(75, 19);
            this.cbAtRisk.TabIndex = 12;
            this.cbAtRisk.Text = "A risques";
            this.cbAtRisk.UseVisualStyleBackColor = true;
            // 
            // SAddEmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 299);
            this.Controls.Add(this.cbAtRisk);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.cbxSector);
            this.Controls.Add(this.cbAddMore);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpEntry);
            this.Controls.Add(this.lblEntryDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SAddEmployeeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SAddEmployeeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.DateTimePicker dtpEntry;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cbAddMore;
        private System.Windows.Forms.ComboBox cbxSector;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.CheckBox cbAtRisk;
    }
}