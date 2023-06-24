using System.Windows.Forms;

namespace Stock
{
    partial class GoodsUploadForm
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(350, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(651, 531);
            dataGridView1.TabIndex = 1;
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(183, 247);
            button5.Name = "button5";
            button5.Size = new Size(144, 28);
            button5.TabIndex = 26;
            button5.Text = "Скасувати";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 247);
            button4.Name = "button4";
            button4.Size = new Size(144, 28);
            button4.TabIndex = 25;
            button4.Text = "Додати";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 32);
            button3.Name = "button3";
            button3.Size = new Size(315, 39);
            button3.TabIndex = 24;
            button3.Text = "Видалити товар";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(204, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 26);
            textBox1.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "Name";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(204, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 21;
            comboBox1.DropDown += comboBox1_DropDown;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(183, 487);
            button2.Name = "button2";
            button2.Size = new Size(144, 50);
            button2.TabIndex = 19;
            button2.Text = "Повернутися до \r\nголовного меню";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(12, 487);
            button1.Name = "button1";
            button1.Size = new Size(144, 48);
            button1.TabIndex = 18;
            button1.Text = "Сформувати накладну";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 190);
            label2.Name = "label2";
            label2.Size = new Size(172, 19);
            label2.TabIndex = 17;
            label2.Text = "Введіть кількість товару ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 100);
            label1.Name = "label1";
            label1.Size = new Size(152, 19);
            label1.TabIndex = 16;
            label1.Text = "Введіть назву товару ";
            // 
            // GoodsUploadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 553);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "GoodsUploadForm";
            Text = "Вигрузка товару";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public void SetData(List<Checkin> checkin)
        {
            dataGridView1.DataSource = checkin;
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}