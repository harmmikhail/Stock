namespace Stock
{
    partial class MainForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(27, 432);
            button1.Name = "button1";
            button1.Size = new Size(243, 83);
            button1.TabIndex = 0;
            button1.Text = "Реєстрація надходження товару";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(347, 432);
            button2.Name = "button2";
            button2.Size = new Size(243, 83);
            button2.TabIndex = 1;
            button2.Text = "Вигрузка товарів";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(672, 432);
            button3.Name = "button3";
            button3.Size = new Size(243, 83);
            button3.TabIndex = 2;
            button3.Text = " Вивід інвентарної відомості";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 546);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Головна";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}