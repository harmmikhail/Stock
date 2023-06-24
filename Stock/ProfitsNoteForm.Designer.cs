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
            dataGridView1.Location = new Point(8, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 311);
            dataGridView1.TabIndex = 0;
            // 
            // labelTotalSum
            // 
            labelTotalSum.AutoSize = true;
            labelTotalSum.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalSum.ForeColor = SystemColors.ControlText;
            labelTotalSum.Location = new Point(12, 362);
            labelTotalSum.Name = "labelTotalSum";
            labelTotalSum.Size = new Size(117, 20);
            labelTotalSum.TabIndex = 1;
            labelTotalSum.Text = "Загальна сума";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = SystemColors.ControlText;
            labelDate.Location = new Point(312, 362);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(126, 20);
            labelDate.TabIndex = 2;
            labelDate.Text = "Дата реєстрації";
            // 
            // ProfitsNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 410);
            Controls.Add(labelDate);
            Controls.Add(labelTotalSum);
            Controls.Add(dataGridView1);
            Name = "ProfitsNoteForm";
            Text = "Прибутка накладна";
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