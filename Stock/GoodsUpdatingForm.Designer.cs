namespace Stock
{
    partial class GoodsUpdatingForm
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            checkinBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            checkinBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkinBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkinBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(350, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(651, 531);
            dataGridView1.TabIndex = 0;
            // 
            // checkinBindingSource
            // 
            checkinBindingSource.DataSource = typeof(Checkin);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 106);
            label1.Name = "label1";
            label1.Size = new Size(152, 19);
            label1.TabIndex = 1;
            label1.Text = "Введіть назву товару ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 196);
            label2.Name = "label2";
            label2.Size = new Size(172, 19);
            label2.TabIndex = 3;
            label2.Text = "Введіть кількість товару ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(12, 493);
            button1.Name = "button1";
            button1.Size = new Size(144, 48);
            button1.TabIndex = 5;
            button1.Text = "Сформувати накладну";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(183, 493);
            button2.Name = "button2";
            button2.Size = new Size(144, 50);
            button2.TabIndex = 6;
            button2.Text = "Повернутися до \r\nголовного меню";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 281);
            label3.Name = "label3";
            label3.Size = new Size(162, 19);
            label3.TabIndex = 7;
            label3.Text = "Введіть дату реєстрації";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "Name";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(204, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            comboBox1.DropDown += comboBox1_DropDown;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(204, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 26);
            textBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(204, 281);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 38);
            button3.Name = "button3";
            button3.Size = new Size(315, 39);
            button3.TabIndex = 13;
            button3.Text = "Додати новий товар";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 318);
            button4.Name = "button4";
            button4.Size = new Size(144, 28);
            button4.TabIndex = 14;
            button4.Text = "Додати";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(183, 318);
            button5.Name = "button5";
            button5.Size = new Size(144, 28);
            button5.TabIndex = 15;
            button5.Text = "Скасувати";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // checkinBindingSource1
            // 
            checkinBindingSource1.DataSource = typeof(Checkin);
            // 
            // GoodsUpdatingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 553);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "GoodsUpdatingForm";
            Text = "Додавання товару";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkinBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkinBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public void SetData(List<Checkin> checkin)
        {
            dataGridView1.DataSource = checkin;
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button4;
        private Button button5;
        private BindingSource checkinBindingSource;
        private BindingSource checkinBindingSource1;
    }
}