namespace WorldyachtsUI
{
    partial class SpecializationForm
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
            this.code_spec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code_spec,
            this.specializationCol,
            this.salaryCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 415);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // code_spec
            // 
            this.code_spec.HeaderText = "Код специализации";
            this.code_spec.MinimumWidth = 6;
            this.code_spec.Name = "code_spec";
            this.code_spec.Width = 125;
            // 
            // specializationCol
            // 
            this.specializationCol.HeaderText = "Специализация";
            this.specializationCol.MinimumWidth = 6;
            this.specializationCol.Name = "specializationCol";
            this.specializationCol.Width = 125;
            // 
            // salaryCol
            // 
            this.salaryCol.HeaderText = "Оклад";
            this.salaryCol.MinimumWidth = 6;
            this.salaryCol.Name = "salaryCol";
            this.salaryCol.Width = 125;
            // 
            // SpecializationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 415);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SpecializationForm";
            this.Text = "Специализация";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_spec;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryCol;
    }
}