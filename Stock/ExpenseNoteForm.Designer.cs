namespace Stock
{
    partial class ExpenseNoteForm
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
            SuspendLayout();
            // 
            // ExpenseNote
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 394);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ExpenseNote";
            Text = "Видаткова накладна";
            ResumeLayout(false);
        }

        #endregion
    }
}