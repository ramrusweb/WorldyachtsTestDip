namespace WorldyachtsUI
{
    partial class EmployeesListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFirstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeMiddleNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBurnDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAddressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSpecCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeCodeCol,
            this.employeeLastNameCol,
            this.employeeFirstNameCol,
            this.employeeMiddleNameCol,
            this.employeeBurnDateCol,
            this.employeeAddressCol,
            this.employeeSpecCodeCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // employeeCodeCol
            // 
            this.employeeCodeCol.HeaderText = "Код сотрудника";
            this.employeeCodeCol.MinimumWidth = 6;
            this.employeeCodeCol.Name = "employeeCodeCol";
            this.employeeCodeCol.Width = 125;
            // 
            // employeeLastNameCol
            // 
            this.employeeLastNameCol.HeaderText = "Фамилия";
            this.employeeLastNameCol.MinimumWidth = 6;
            this.employeeLastNameCol.Name = "employeeLastNameCol";
            this.employeeLastNameCol.Width = 125;
            // 
            // employeeFirstNameCol
            // 
            this.employeeFirstNameCol.HeaderText = "Имя";
            this.employeeFirstNameCol.MinimumWidth = 6;
            this.employeeFirstNameCol.Name = "employeeFirstNameCol";
            this.employeeFirstNameCol.Width = 125;
            // 
            // employeeMiddleNameCol
            // 
            this.employeeMiddleNameCol.HeaderText = "Отчество";
            this.employeeMiddleNameCol.MinimumWidth = 6;
            this.employeeMiddleNameCol.Name = "employeeMiddleNameCol";
            this.employeeMiddleNameCol.Width = 125;
            // 
            // employeeBurnDateCol
            // 
            this.employeeBurnDateCol.HeaderText = "Дата рождения";
            this.employeeBurnDateCol.MinimumWidth = 6;
            this.employeeBurnDateCol.Name = "employeeBurnDateCol";
            this.employeeBurnDateCol.Width = 125;
            // 
            // employeeAddressCol
            // 
            this.employeeAddressCol.HeaderText = "Адрес";
            this.employeeAddressCol.MinimumWidth = 6;
            this.employeeAddressCol.Name = "employeeAddressCol";
            this.employeeAddressCol.Width = 125;
            // 
            // employeeSpecCodeCol
            // 
            this.employeeSpecCodeCol.HeaderText = "Код специализации";
            this.employeeSpecCodeCol.MinimumWidth = 6;
            this.employeeSpecCodeCol.Name = "employeeSpecCodeCol";
            this.employeeSpecCodeCol.Width = 125;
            // 
            // EmployeesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 249);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeesListForm";
            this.Text = "Список сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeMiddleNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeBurnDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeAddressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSpecCodeCol;
    }
}