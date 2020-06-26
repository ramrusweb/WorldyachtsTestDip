namespace WorldyachtsUI
{
    partial class ViewOrdersForm
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
            this.vOrdsCodeLineCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOrdsNumOrderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOrdsDateReceiptCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOrdsDueDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOrdsCodeEmployeeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOrdsProductCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vOrdsCodeLineCol,
            this.vOrdsNumOrderCol,
            this.vOrdsDateReceiptCol,
            this.vOrdsDueDateCol,
            this.vOrdsCodeEmployeeCol,
            this.vOrdsProductCodeCol,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // vOrdsCodeLineCol
            // 
            this.vOrdsCodeLineCol.HeaderText = "Код строки Заказы";
            this.vOrdsCodeLineCol.MinimumWidth = 6;
            this.vOrdsCodeLineCol.Name = "vOrdsCodeLineCol";
            this.vOrdsCodeLineCol.Width = 125;
            // 
            // vOrdsNumOrderCol
            // 
            this.vOrdsNumOrderCol.HeaderText = "Номер заказа";
            this.vOrdsNumOrderCol.MinimumWidth = 6;
            this.vOrdsNumOrderCol.Name = "vOrdsNumOrderCol";
            this.vOrdsNumOrderCol.Width = 125;
            // 
            // vOrdsDateReceiptCol
            // 
            this.vOrdsDateReceiptCol.HeaderText = "Дата приема";
            this.vOrdsDateReceiptCol.MinimumWidth = 6;
            this.vOrdsDateReceiptCol.Name = "vOrdsDateReceiptCol";
            this.vOrdsDateReceiptCol.Width = 125;
            // 
            // vOrdsDueDateCol
            // 
            this.vOrdsDueDateCol.HeaderText = "Дата исполнения";
            this.vOrdsDueDateCol.MinimumWidth = 6;
            this.vOrdsDueDateCol.Name = "vOrdsDueDateCol";
            this.vOrdsDueDateCol.Width = 125;
            // 
            // vOrdsCodeEmployeeCol
            // 
            this.vOrdsCodeEmployeeCol.HeaderText = "Код сотрудника";
            this.vOrdsCodeEmployeeCol.MinimumWidth = 6;
            this.vOrdsCodeEmployeeCol.Name = "vOrdsCodeEmployeeCol";
            this.vOrdsCodeEmployeeCol.Width = 125;
            // 
            // vOrdsProductCodeCol
            // 
            this.vOrdsProductCodeCol.HeaderText = "Код продукции";
            this.vOrdsProductCodeCol.MinimumWidth = 6;
            this.vOrdsProductCodeCol.Name = "vOrdsProductCodeCol";
            this.vOrdsProductCodeCol.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Примечания";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Аванс";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Количество выхода";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // ViewOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 167);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewOrdersForm";
            this.Text = "Просмотр заказов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOrdsCodeLineCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOrdsNumOrderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOrdsDateReceiptCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOrdsDueDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOrdsCodeEmployeeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOrdsProductCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}