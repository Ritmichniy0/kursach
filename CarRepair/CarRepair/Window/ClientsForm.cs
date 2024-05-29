using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class ClientsForm : Form
    {
        bool isEdit; //Флаг, указывающий была ли нажата кнопка редактирования.

        public ClientsForm()
        {
            InitializeComponent();
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Проверяем датагрид на наличие нужной колонки, если она есть то выключаем ее или переименовываем
            if (dataGridView.Columns["ID_Client"] != null)
                dataGridView.Columns["ID_Client"].Visible = false;
			if (dataGridView.Columns["FirstName"] != null)
				dataGridView.Columns["FirstName"].HeaderText = "Фамилия";
			if (dataGridView.Columns["Name"] != null)
                dataGridView.Columns["Name"].HeaderText = "Имя";
            if (dataGridView.Columns["SecondName"] != null)
                dataGridView.Columns["SecondName"].HeaderText = "Отчество";
			if (dataGridView.Columns["Phone"] != null)
				dataGridView.Columns["Phone"].HeaderText = "Телефон";
			if (dataGridView.Columns["Email"] != null)
				dataGridView.Columns["Email"].HeaderText = "Почта";
			if (dataGridView.Columns["Repair"] != null)
                dataGridView.Columns["Repair"].Visible = false;
            if (dataGridView.Columns["Car"] != null)
                dataGridView.Columns["Car"].Visible = false;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //Выключаем текстбокс и нужные кнопки
            DisableControls();
            if (dataGridView.SelectedRows.Count > 0)
            {
                //Заполняем текстбокс данными
                var item = dataGridView.SelectedRows[0].DataBoundItem as Client;
                firstNameText.Text = item.FirstName;
                nameText.Text = item.Name;
                secondNameText.Text = item.SecondName;
                maskedTextBox.Text = item.Phone;
				emailTexttBox.Text = item.Email;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (isEdit)//Если вкл. режим редактирования
            {
                if (firstNameText.Text.Length > 0 && nameText.Text.Length > 0 && secondNameText.Text.Length > 0 && maskedTextBox.MaskCompleted) //Если данные введены
                { 
                    try //Пробуем изменить запись
                    {
                        var item = dataGridView.SelectedRows[0].DataBoundItem as Client; //Получаем элемент из датагрида
                        DataAccess.UpdateClient(item, firstNameText.Text, nameText.Text, secondNameText.Text, maskedTextBox.Text, emailTexttBox.Text); //Метод изменения записи в БД
                        dataGridView.DataSource = DataAccess.GetClients(); //Обновляем данные в датагриде
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
                if (firstNameText.Text.Length > 0 && nameText.Text.Length > 0 && secondNameText.Text.Length > 0 && maskedTextBox.MaskCompleted)//Если данные введены
                {
                    try
                    {
                        DataAccess.AddNewClient(firstNameText.Text, nameText.Text, secondNameText.Text, maskedTextBox.Text, emailTexttBox.Text); //Пробуем добавить запись
                        dataGridView.DataSource = DataAccess.GetClients();//Обновляем данные в датагриде
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

            DisableControls();
            SaveBtn.Enabled = false;
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

        private void ShowCarBtn_Click(object sender, EventArgs e)
        {
            //Проверяем, выбран ли клиент
            if (dataGridView.SelectedRows.Count > 0)
            {
                //Получаем связанный элемент
                var client = dataGridView.SelectedRows[0].DataBoundItem as Client;
                //Создаем и открываем форму с автомобилями
                CarsForm carsForm = new CarsForm(client);
                carsForm.ShowDialog();
            }
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            //DataGridView указываем в качестве источника данных список отделов
            dataGridView.DataSource = DataAccess.GetClients();
            DisableControls(); //Отключаем кнопку сохр и тектовое поле.
        }

        //очищает поля для заполнения
        void ClearConrols()
        {
            firstNameText.Text = nameText.Text = secondNameText.Text = maskedTextBox.Text = emailTexttBox.Text = string.Empty;
        }

        //Метод отключает текстбокс и кнопку сохранить и активирует кнопки добавить и редактировать
        void DisableControls()
        {
			firstNameText.Enabled = nameText.Enabled = secondNameText.Enabled = SaveBtn.Enabled = maskedTextBox.Enabled = emailTexttBox.Enabled = false;
            EditBtn.Enabled = AddBtn.Enabled = true;
        }

        //Метод включает текстбокс и кнопку сохранить
        void EnableControls()
        {
            firstNameText.Enabled = nameText.Enabled = secondNameText.Enabled = maskedTextBox.Enabled = emailTexttBox.Enabled = true;
            SaveBtn.Enabled = true;
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

			if (!IsValidEmail(email))
			{
				MessageBox.Show("Некорректный формат адреса электронной почты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;
			}
		}

		private bool IsValidEmail(string email)
		{
			try
			{
                if(email != null || email != "")
				{
					MailAddress mailAddress = new MailAddress(email);
					return true;
				}
				else
                    return false;
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
