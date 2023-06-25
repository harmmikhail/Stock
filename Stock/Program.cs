using Microsoft.VisualBasic.ApplicationServices;

namespace Stock
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var context = new Context())
            {
                List<Checkin> checkin = context.Checkin.ToList();

                int remainingAttempts = 5;

                while (remainingAttempts > 0)
                {
                    using (var authenticationForm = new AuthenticationForm())
                    {
                        if (authenticationForm.ShowDialog() == DialogResult.OK)
                        {
                            if (authenticationForm.Username == "Stock owner" && authenticationForm.Password == "123456")
                            {
                                MainForm mainForm = new MainForm();
                                mainForm.ShowDialog();
                                return;
                            }
                            else
                            {
                                remainingAttempts--;
                                if (remainingAttempts == 1)
                                {
                                    MessageBox.Show("� ��� ���������� 1 ������. ϳ��� �� � ��� �� ���� ��������� �����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    remainingAttempts = 0;
                                }
                                else
                                {
                                    
                                    MessageBox.Show("������� ���� ��� ������. ���������� �����: " + (remainingAttempts-1), "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    
                                }
                            }
                        }

                        else
                        {
                            DialogResult result = MessageBox.Show("���� ���������. �� �������?", "�����������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                return;
                            }
                        }
                    }
                }

                MessageBox.Show("�� ��������� ��� �����. ��������� �������� ���� ���������.", "�����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}