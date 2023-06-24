namespace Stock
{
    partial class GoodsDeleting
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
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 12;
            label1.Text = "Введіть назву товару ";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(223, 137);
            button2.Name = "button2";
            button2.Size = new Size(191, 37);
            button2.TabIndex = 20;
            button2.Text = "Повернутися ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(12, 137);
            button1.Name = "button1";
            button1.Size = new Size(172, 37);
            button1.TabIndex = 19;
            button1.Text = "Видалити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(223, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 29);
            comboBox1.TabIndex = 24;
            comboBox1.DropDown += comboBox1_DropDown;
            // 
            // GoodsDeleting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 186);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "GoodsDeleting";
            Text = "Видалення товару";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
    }
}