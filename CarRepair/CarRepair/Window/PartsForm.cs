using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRepair.Window
{
	public partial class PartsForm : Form
	{
		bool isEdit;

		public PartsForm()
		{
			InitializeComponent();
		}

		private void PartsForm_Load(object sender, EventArgs e)
		{
			dataGridView.DataSource = DataAccess.GetDetail();
			DisableControls(); //Отключаем кнопку сохр и тектовое поле.
		}

		private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			//Проверяем датагрид на наличие нужной колонки, если она есть то выключаем ее или переименовываем
			if (dataGridView.Columns["ID_Detail"] != null)
				dataGridView.Columns["ID_Detail"].Visible = false;
			if (dataGridView.Columns["Title"] != null)
				dataGridView.Columns["Title"].HeaderText = "Название запчасти";
			if (dataGridView.Columns["Price"] != null)
			{
				dataGridView.Columns["Price"].HeaderText = "Стоимость запчасти (руб.)";
				dataGridView.Columns["Price"].DefaultCellStyle.Format = "N2";
			}
			if (dataGridView.Columns["DetailRepair"] != null)
				dataGridView.Columns["DetailRepair"].Visible = false;
		}

		private void dataGridView_SelectionChanged(object sender, EventArgs e)
		{
			//Выключаем текстбокс и нужные кнопки
			DisableControls();
			if (dataGridView.SelectedRows.Count > 0)
			{
				//Заполняем текстбокс данными
				var item = dataGridView.SelectedRows[0].DataBoundItem as Detail;
				TitleText.Text = item.Title;
				priceText.Value = item.Price;
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
						var item = dataGridView.SelectedRows[0].DataBoundItem as Detail; //Получаем элемент из датагрида
						DataAccess.UpdateDetail(item, TitleText.Text, priceText.Value); //Метод изменения записи в БД
						dataGridView.DataSource = DataAccess.GetDetail(); //Обновляем данные в датагриде
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
						DataAccess.AddNewDetail(TitleText.Text, priceText.Value); //Пробуем добавить запись
						dataGridView.DataSource = DataAccess.GetDetail();//Обновляем данные в датагриде
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

		//Метод отключает текстбокс и кнопку сохранить и активирует кнопки добавить и редактировать
		void DisableControls()
		{
			TitleText.Enabled = priceText.Enabled = SaveBtn.Enabled = false;
			EditBtn.Enabled = AddBtn.Enabled = true;
		}

		//Метод включает текстбокс и кнопку сохранить
		void EnableControls()
		{
			TitleText.Enabled = priceText.Enabled = true;
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
			priceText.Value = 0;
		}
	}
}
