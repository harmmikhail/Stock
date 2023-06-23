using System.Windows.Forms;

namespace Stock
{
    partial class Form7
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
            dateTimePicker1 = new DateTimePicker();
            textBoxQuantity = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxName = new TextBox();
            button2 = new Button();
            button1 = new Button();
            textBoxPrice = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(313, 245);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(191, 29);
            dateTimePicker1.TabIndex = 17;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxQuantity.Location = new Point(313, 188);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(191, 29);
            textBoxQuantity.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 253);
            label3.Name = "label3";
            label3.Size = new Size(196, 21);
            label3.TabIndex = 14;
            label3.Text = "Введіть дату реєстрації";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 191);
            label2.Name = "label2";
            label2.Size = new Size(209, 21);
            label2.TabIndex = 13;
            label2.Text = "Введіть кількість товару ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 58);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 12;
            label1.Text = "Введіть назву товару ";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(313, 55);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(191, 29);
            textBoxName.TabIndex = 18;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(268, 324);
            button2.Name = "button2";
            button2.Size = new Size(263, 71);
            button2.TabIndex = 20;
            button2.Text = "Повернутися до \r\nголовного меню";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(10, 324);
            button1.Name = "button1";
            button1.Size = new Size(225, 71);
            button1.TabIndex = 19;
            button1.Text = "Підтвердити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.Location = new Point(313, 119);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(191, 29);
            textBoxPrice.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 122);
            label4.Name = "label4";
            label4.Size = new Size(172, 21);
            label4.TabIndex = 21;
            label4.Text = "Введіть ціну товару ";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 405);
            Controls.Add(textBoxPrice);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxName);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxQuantity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox textBoxQuantity;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxName;
        private Button button2;
        private Button button1;
        private TextBox textBoxPrice;
        private Label label4;
    }
}