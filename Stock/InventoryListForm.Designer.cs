using System.Windows.Forms;

namespace Stock
{
    partial class InventoryListForm : Form
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
            dataGridView = new DataGridView();
            button1 = new Button();
            dateTimePicker = new DateTimePicker();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(339, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(645, 527);
            dataGridView.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(30, 370);
            button1.Name = "button1";
            button1.Size = new Size(270, 67);
            button1.TabIndex = 1;
            button1.Text = "Повернутися в головне меню";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker.Location = new Point(51, 166);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(231, 32);
            dateTimePicker.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(30, 219);
            button2.Name = "button2";
            button2.Size = new Size(270, 55);
            button2.TabIndex = 3;
            button2.Text = "Пошук";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 114);
            label1.Name = "label1";
            label1.Size = new Size(231, 23);
            label1.TabIndex = 4;
            label1.Text = "Вкажіть дату для пошуку";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(30, 293);
            button3.Name = "button3";
            button3.Size = new Size(270, 55);
            button3.TabIndex = 5;
            button3.Text = "Скасувати";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // InventoryListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 551);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(dateTimePicker);
            Controls.Add(button1);
            Controls.Add(dataGridView);
            Name = "InventoryListForm";
            Text = "Інвентарна відомість";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public void SetData(List<Checkin> checkin)
        {
            dataGridView.DataSource = checkin;
        }

        #endregion

        private DataGridView dataGridView;
        private Button button1;
        private DateTimePicker dateTimePicker;
        private Button button2;
        private Label label1;
        private Button button3;
    }
}