using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class EmployeesForm : Form
    {
        bool isEdit; //Флаг, указывающий была ли нажата кнопка редактирования.

        int _id;

		public EmployeesForm(int id)
        {
            InitializeComponent();
            this._id = id;
		}

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
			//DataGridView указываем в качестве источника данных список сотрудников
			dataGridView.DataSource = DataAccess.GetEmployees();

			//Указываем в качестве источника данных комбобокса список отделов
			departmentBox.DataSource = DataAccess.GetDepartments();
			specialisationBox.DisplayMember = "Title";
			roleBox.DataSource = DataAccess.GetRole();
            DisableControls(); //Отключаем кнопку сохр и тектовое поля.
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Проверяем датагрид на наличие нужной колонки, если она есть то выключаем ее или переименовываем
            if (dataGridView.Columns["ID_Employee"] != null)
                dataGridView.Columns["ID_Employee"].Visible = false;
			if (dataGridView.Columns["FirstName"] != null)
				dataGridView.Columns["FirstName"].HeaderText = "Фамилия";
			if (dataGridView.Columns["Name"] != null)
                dataGridView.Columns["Name"].HeaderText = "Имя";
			if (dataGridView.Columns["SecondName"] != null)
				dataGridView.Columns["SecondName"].HeaderText = "Отчество";
			if (dataGridView.Columns["Specialisation_ID"] != null)
				dataGridView.Columns["Specialisation_ID"].Visible = false;
			if (dataGridView.Columns["Specialisation"] != null)
                dataGridView.Columns["Specialisation"].HeaderText = "Отдел | Специализация";
            if (dataGridView.Columns["Department"] != null)
                dataGridView.Columns["Department"].HeaderText = "Отдел";
            if (dataGridView.Columns["Phone"] != null)
                dataGridView.Columns["Phone"].HeaderText = "Телефон";
			if (dataGridView.Columns["Email"] != null)
				dataGridView.Columns["Email"].HeaderText = "Почта";
			if (dataGridView.Columns["DetailRepair"] != null)
                dataGridView.Columns["DetailRepair"].Visible = false;
            if (dataGridView.Columns["Department_ID"] != null)
                dataGridView.Columns["Department_ID"].Visible = false;
            if (dataGridView.Columns["Role_ID"] != null)
                dataGridView.Columns["Role_ID"].Visible = false;
            if (dataGridView.Columns["login"] != null)
                dataGridView.Columns["login"].HeaderText = "Логин";
            if (dataGridView.Columns["password"] != null)
                dataGridView.Columns["password"].HeaderText = "Пароль";
            if (dataGridView.Columns["Role"] != null)
                dataGridView.Columns["Role"].HeaderText = "Роль";
		}

        //Обработчик события переключения строк
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //Проверяем, выбрана ли строка
            if (dataGridView.SelectedRows.Count > 0)
            {
                //Получаем связанный с этой строкой элемент
                var item = dataGridView.SelectedRows[0].DataBoundItem as Employee;
                //Заполняем поля данными из элемента
                
				firstNameText.Text = item.FirstName;
				nameText.Text = item.Name;
                specialisationBox.SelectedItem = item.Specialisation;
                if(item.Specialisation != null)
                    departmentBox.SelectedItem = item.Specialisation.Department;
				secondName.Text = item.SecondName;
				maskedTextBox.Text = item.Phone;
				emailTexttBox.Text = item.Email;
                roleBox.SelectedItem = item.Role;
                passwordText.Text = item.Password;
                loginText.Text = item.Login;
            }
            DisableControls(); //Отключаем кнопку сохр и тектовое поля.
        }

		private void AddBtn_Click(object sender, EventArgs e)
        {
            EditBtn.Enabled = isEdit = false;
            EnableControls();
            ClearConrols();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                AddBtn.Enabled = false;
                isEdit = true;
                
                EnableControls();
            }
            else MessageBox.Show("Необходимо выбрать строку для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (var context = new CarRepairEntities())
            {
                if (isEdit)//Если вкл. режим редактирования
                {
                    if (firstNameText.Text.Length > 0 && nameText.Text.Length > 0 && secondName.Text.Length > 0 && maskedTextBox.MaskCompleted && departmentBox.SelectedItem != null && specialisationBox.SelectedItem != null && (loginText.Text.Length > 0 && passwordText.Text.Length > 0 || roleBox.SelectedItem.ToString() == "Не активный"))//Если данные введены
                    {
                        try //Пробуем изменить запись
                        {
                            var specialisation = specialisationBox.SelectedItem as Specialisation;
                            var item = dataGridView.SelectedRows[0].DataBoundItem as Employee; //Получаем элемент из датагрида
                            var roleitem = roleBox.SelectedItem as Role;

                            var user = context.Employee.SingleOrDefault(x => x.ID_Employee == item.ID_Employee);
                            bool isLoginUnique = !context.Employee.Any(u => u.Login == loginText.Text && u.Login != user.Login);
                            if (!isLoginUnique && item.Role_ID != 4) 
                            {
                                MessageBox.Show("Сотрудник с таким логином существует уже!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            DataAccess.UpdateEmployee(item, specialisation, roleitem, firstNameText.Text, nameText.Text, secondName.Text, maskedTextBox.Text, emailTexttBox.Text, loginText.Text, passwordText.Text); //Метод изменения записи в БД
                            dataGridView.DataSource = DataAccess.GetEmployees(); //Обновляем данные в датагриде
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (firstNameText.Text.Length > 0 && nameText.Text.Length > 0 && secondName.Text.Length > 0 && maskedTextBox.MaskCompleted && emailTexttBox.Text.Length > 0 && departmentBox.SelectedItem != null && specialisationBox.SelectedItem != null && (loginText.Text.Length > 0 && passwordText.Text.Length > 0 || roleBox.SelectedItem.ToString() == "Не активный"))//Если данные введены
                    {
                        try
                        {
                            var specialisation = specialisationBox.SelectedItem as Specialisation;
                            var roleitem = roleBox.SelectedItem as Role;
							bool isLoginUnique = !context.Employee.Any(u => u.Login == loginText.Text);
                            if (!isLoginUnique && roleitem.ID_Role != 4)
                            {
								MessageBox.Show("Сотрудник с таким логином существует уже!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}
                            DataAccess.AddNewEmployee(specialisation, roleitem, firstNameText.Text, nameText.Text, secondName.Text, maskedTextBox.Text, emailTexttBox.Text, loginText.Text, passwordText.Text);//Пробуем добавить запись
                            dataGridView.DataSource = DataAccess.GetEmployees();//Обновляем данные в датагриде
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            DisableControls();
            SaveBtn.Enabled = false;
        }

        //Метод отключает текстбокс и кнопку сохранить и активирует кнопки добавить и редактировать
        void DisableControls()
        {
            secondName.Enabled = nameText.Enabled = firstNameText.Enabled = SaveBtn.Enabled = passwordText.Enabled = loginText.Enabled = maskedTextBox.Enabled = emailTexttBox.Enabled = specialisationBox.Enabled = roleBox.Enabled = departmentBox.Enabled = false;
            EditBtn.Enabled = AddBtn.Enabled = true;
        }

        //Метод включает текстбокс и кнопку сохранить
        void EnableControls()
        {
			if (0 == roleBox.SelectedIndex)
				roleBox.Enabled = false;
			else
				roleBox.Enabled = true;
			secondName.Enabled = nameText.Enabled = firstNameText.Enabled = SaveBtn.Enabled = passwordText.Enabled = loginText.Enabled = maskedTextBox.Enabled = emailTexttBox.Enabled = specialisationBox.Enabled = departmentBox.Enabled = true;
            SaveBtn.Enabled = true;
        }

        //очищает поля для заполнения
        void ClearConrols()
        {
			secondName.Text = nameText.Text = firstNameText.Text = maskedTextBox.Text = emailTexttBox.Text = passwordText.Text = loginText.Text = string.Empty;
            departmentBox.SelectedItem = null;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBtn.Enabled = isEdit = false;
            EnableControls();
            ClearConrols();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                AddBtn.Enabled = false;
                isEdit = true;
                EnableControls();
            }
            else MessageBox.Show("Необходимо выбрать строку для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                var selected = dataGridView.SelectedRows[0].DataBoundItem as Employee;
                if(selected.ID_Employee != _id)
                {
                    try
                    {
                        DataAccess.DeleteEmployee(selected);
                        dataGridView.DataSource = DataAccess.GetEmployees();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Нельзя себя удалить!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void DepartmentBox_TextChanged(object sender, EventArgs e)
		{
		    //проверяем, выбран ли элемент
		    if (departmentBox.SelectedItem != null)
		    {
			    //Получаем его
			    var depart = departmentBox.SelectedItem as Department;
			    specialisationBox.DataSource = DataAccess.GetSpecialisation(depart);
				specialisationBox.DisplayMember = "Title";
			}
		    else specialisationBox.DataSource = null;
		}

		private void TitleText_KeyPress(object sender, KeyPressEventArgs e)
		{
			char inputChar = e.KeyChar;

			// Проверяем, является ли введенный символ буквой или символом "ъ"
			if (!char.IsLetter(inputChar) && inputChar != 'ъ' && inputChar != '\b')
			{
				// Если символ не является буквой, символом "ъ" или клавишей Backspace, отменяем его ввод
				e.Handled = true;
			}
		}

		private void emailTexttBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string email = emailTexttBox.Text.Trim();
            if (email.Length > 0)
            {
                if (!IsValidEmail(email))
                {
					MessageBox.Show("Некорректный формат адреса электронной почты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					e.Cancel = true;
				}
            }
		}

		private bool IsValidEmail(string email)
		{
			try
			{
				MailAddress mailAddress = new MailAddress(email);
				return true;
			}
			catch (FormatException)
			{
				return false;
			}
		}

		private void maskedTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				e.SuppressKeyPress = true; // Отмена ввода пробела
			}
		}
	}
}
