using System;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class DepartmentsForm : Form
    {
        bool isEdit; //Флаг, указывающий была ли нажата кнопка редактирования.

        public DepartmentsForm()
        {
            InitializeComponent();
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Проверяем датагрид на наличие нужной колонки, если она есть то выключаем ее или переименовываем
            if (dataGridView.Columns["ID_Department"] != null)
                dataGridView.Columns["ID_Department"].Visible = false;
            if (dataGridView.Columns["Title"] != null)
                dataGridView.Columns["Title"].HeaderText = "Название отдела";
            if (dataGridView.Columns["Specialisation"] != null)
                dataGridView.Columns["Specialisation"].Visible = false;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //Выключаем текстбокс и нужные кнопки
            DisableControls();
            if (dataGridView.SelectedRows.Count > 0)
            {
                //Заполняем текстбокс данными
                var item = dataGridView.SelectedRows[0].DataBoundItem as Department;
                TitleText.Text = item.Title;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (isEdit)//Если вкл. режим редактирования
            {
                if (TitleText.Text.Length > 0) //Если данные введены
                {
                    try //Пробуем изменить запись
                    {
                        var item = dataGridView.SelectedRows[0].DataBoundItem as Department; //Получаем элемент из датагрида
                        DataAccess.UpdateDepartment(item, TitleText.Text); //Метод изменения записи в БД
                        dataGridView.DataSource = DataAccess.GetDepartments(); //Обновляем данные в датагриде
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
                if (TitleText.Text.Length > 0)//Если данные введены
                {
                    try
                    {
                        DataAccess.AddNewDepartment(TitleText.Text); //Пробуем добавить запись
                        dataGridView.DataSource = DataAccess.GetDepartments();//Обновляем данные в датагриде
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

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            //DataGridView указываем в качестве источника данных список отделов
            dataGridView.DataSource = DataAccess.GetDepartments();
            DisableControls(); //Отключаем кнопку сохр и тектовое поле.
        }

        //Метод отключает текстбокс и кнопку сохранить и активирует кнопки добавить и редактировать
        void DisableControls()
        {
            TitleText.Enabled = SaveBtn.Enabled = false;
            EditBtn.Enabled = AddBtn.Enabled = true;
        }

        //Метод включает текстбокс и кнопку сохранить
        void EnableControls()
        {
            TitleText.Enabled = true;
            SaveBtn.Enabled = true;
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
            else MessageBox.Show("Необходимо выбрать строку для редактирования!", 
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //очищает поля для заполнения
        void ClearConrols()
        {
            TitleText.Text = string.Empty;
        }

		private void добавитьСпецализациюToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count > 0)
			{
				var item = dataGridView.SelectedRows[0].DataBoundItem as Department;

				SpecialisationForm specialisation = new SpecialisationForm(item);
				specialisation.ShowDialog();
			}
			dataGridView.DataSource = DataAccess.GetDepartments();
		}
	}
}
