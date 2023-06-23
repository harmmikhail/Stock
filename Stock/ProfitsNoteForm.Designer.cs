namespace Stock
{
    partial class ProfitsNoteForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            labelTotalSum = new Label();
            labelDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(500, 311);
            dataGridView1.TabIndex = 0;
            // 
            // labelTotalSum
            // 
            labelTotalSum.AutoSize = true;
            labelTotalSum.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalSum.Location = new Point(12, 362);
            labelTotalSum.Name = "labelTotalSum";
            labelTotalSum.Size = new Size(0, 21);
            labelTotalSum.TabIndex = 1;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(410, 362);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(0, 21);
            labelDate.TabIndex = 2;
            // 
            // ProfitsNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 405);
            Controls.Add(labelDate);
            Controls.Add(labelTotalSum);
            Controls.Add(dataGridView1);
            Name = "ProfitsNoteForm";
            Text = "Form1";
            Load += ProfitsNoteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelTotalSum;
        private Label labelDate;
    }
}