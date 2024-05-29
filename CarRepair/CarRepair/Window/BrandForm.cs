using System;
using System.Windows.Forms;

namespace CarRepair.Window
{
	public partial class BrandForm : Form
	{
		bool isEdit;

		public BrandForm()
		{
			InitializeComponent();
		}

		//Метод отключает текстбокс и кнопку сохранить и активирует кнопки добавить и редактировать
		void DisableControls()
		{
			TitleText.Enabled = SaveBtn.Enabled = false;
			EditBtn.Enabled = AddBtn.Enabled = true;
		}

		private void BrandForm_Load(object sender, EventArgs e)
		{
			dataGridView.DataSource = DataAccess.GetBrand();
		}

		//Метод включает текстбокс и кнопку сохранить
		void EnableControls()
		{
			TitleText.Enabled = true;
			SaveBtn.Enabled = true;
		}

		//Обр события, когда датагрид получает источник данных
		private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			//Проверяем датагрид на наличие нужной колонки, если она есть то выключаем ее или переименовываем
			if (dataGridView.Columns["ID_Brand"] != null)
				dataGridView.Columns["ID_Brand"].Visible = false;
			if (dataGridView.Columns["Title"] != null)
				dataGridView.Columns["Title"].HeaderText = "Название марки";
			if (dataGridView.Columns["Models"] != null)
				dataGridView.Columns["Models"].Visible = false;
		}

		private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Проверяем, выбрана ли строка
			if (dataGridView.SelectedRows.Count > 0)
			{
				//Получаем связанный с этой строкой элемент
				var item = dataGridView.SelectedRows[0].DataBoundItem as Brand;
				DataAccess.DeleteBrand(item);
				dataGridView.DataSource = DataAccess.GetBrand(); //Обновляем данные в датагриде
			}
		}

		//Событие при переключении строк в таблице
		private void dataGridView_SelectionChanged(object sender, EventArgs e)
		{
			//Выключаем текстбокс и нужные кнопки
			DisableControls();
			if (dataGridView.SelectedRows.Count > 0)
			{
				//Заполняем текстбокс данными
				var item = dataGridView.SelectedRows[0].DataBoundItem as Brand;
				TitleText.Text = item.Title;
			}
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (isEdit)
			{
				if (TitleText.Text.Length > 0)
				{
					try
					{
						var item = dataGridView.SelectedRows[0].DataBoundItem as Brand;    //Получаем элемент из датагрида
						DataAccess.EditBrand(item, TitleText.Text);                         //Метод изменения записи в БД
						dataGridView.DataSource = DataAccess.GetBrand();                    //Обновляем данные в датагриде
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
				if (TitleText.Text.Length > 0)
				{
					try
					{
						DataAccess.AddNewBrand(TitleText.Text);//Пробуем добавить запись
						dataGridView.DataSource = DataAccess.GetBrand();//Обновляем данные в датагриде
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

		//очищает поля для заполнения
		void ClearConrols()
		{
			TitleText.Text = string.Empty;
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

		private void AddBtn_Click(object sender, EventArgs e)
		{
			EditBtn.Enabled = isEdit = false;
			EnableControls();
			ClearConrols();
		}
	}
}
