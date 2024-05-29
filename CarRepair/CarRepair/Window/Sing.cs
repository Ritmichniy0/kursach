using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class Sing : Form
    {
        public Sing()
        {
            InitializeComponent();
            this.passwordText.PasswordChar = '*';
        }

        private void singBtn_Click(object sender, EventArgs e)
        {
            using(var context = new CarRepairEntities())
            {
                var empl = context.Employee.SingleOrDefault(q => q.Login == loginText.Text.Trim() && q.Password == passwordText.Text.Trim());
                if (empl != null)
                {
                    DashBoardForm dashBoardForm = new DashBoardForm(empl);
					dashBoardForm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Не найден пользователь!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void Sing_FormClosed(object sender, FormClosedEventArgs e)
		{
            Application.Exit();
		}
	}
}
