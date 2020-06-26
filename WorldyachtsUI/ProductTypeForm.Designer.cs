namespace WorldyachtsUI
{
    partial class ProductTypeForm
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
            this.prodCodeTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodCodeTypeCol,
            this.prodNameCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(305, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // prodCodeTypeCol
            // 
            this.prodCodeTypeCol.HeaderText = "Код продукции";
            this.prodCodeTypeCol.MinimumWidth = 6;
            this.prodCodeTypeCol.Name = "prodCodeTypeCol";
            this.prodCodeTypeCol.Width = 125;
            // 
            // prodNameCol
            // 
            this.prodNameCol.HeaderText = "Наименование";
            this.prodNameCol.MinimumWidth = 6;
            this.prodNameCol.Name = "prodNameCol";
            this.prodNameCol.Width = 125;
            // 
            // ProductTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 183);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductTypeForm";
            this.Text = "Вид продукции";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCodeTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameCol;
    }
}