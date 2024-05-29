using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRepair.Window
{
    public partial class ModelsForm : Form
    {
        bool isEdit; //Флаг, указывающий была ли нажата кнопка редактирования.

        public ModelsForm()
        {
            InitializeComponent();

			yearManufacturePicker.Format = DateTimePickerFormat.Custom;
			yearManufacturePicker.CustomFormat = "yyyy";
			yearManufacturePicker.ShowUpDown = true;

			brandBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			brandBox.AutoCompleteSource = AutoCompleteSource.ListItems;
		}

        private void ModelsForm_Load(object sender, EventArgs e)
        {
            //DataGridView указываем в качестве источника данных список отделов
            dataGridView.DataSource = DataAccess.GetMarks();
            brandBox.DataSource = DataAccess.GetBrand();
            DisableControls(); //Отключаем кнопку сохр и тектовое поле.
        }

        //Метод отключает текстбокс и кнопку сохранить и активирует кнопки добавить и редактировать
        void DisableControls()
        {
            TitleText.Enabled = brandBox.Enabled = yearManufacturePicker.Enabled = SaveBtn.Enabled = false;
            EditBtn.Enabled = AddBtn.Enabled = true;
        }

        //Метод включает текстбокс и кнопку сохранить
        void EnableControls()
        {
			TitleText.Enabled = brandBox.Enabled = yearManufacturePicker.Enabled = true;
            SaveBtn.Enabled = true;
        }

        //Обр события, когда датагрид получает источник данных
        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
			dataGridView.Columns["Brand"].DisplayIndex = 0;

			//Проверяем датагрид на наличие нужной колонки, если она есть то выключаем ее или переименовываем
			if (dataGridView.Columns["ID_Model"] != null)
                dataGridView.Columns["ID_Model"].Visible = false;
			if (dataGridView.Columns["Brand_ID"] != null)
				dataGridView.Columns["Brand_ID"].Visible = false;
			if (dataGridView.Columns["Title"] != null)
                dataGridView.Columns["Title"].HeaderText = "Название модели";
			if (dataGridView.Columns["Year"] != null)
            {
				dataGridView.Columns["Year"].HeaderText = "Год выпуска";
                dataGridView.Columns["Year"].DefaultCellStyle.Format = "yyyy";
			}
			if (dataGridView.Columns["Brand"] != null)
				dataGridView.Columns["Brand"].HeaderText = "Название бренда";
			if (dataGridView.Columns["Car"] != null)
                dataGridView.Columns["Car"].Visible = false;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Проверяем, выбрана ли строка
            if (dataGridView.SelectedRows.Count > 0)
            {
                //Получаем связанный с этой строкой элемент
                var item = dataGridView.SelectedRows[0].DataBoundItem as Model;
                DataAccess.DeleteModels(item);
                dataGridView.DataSource = DataAccess.GetMarks(); //Обновляем данные в датагриде
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
                var itemModel = dataGridView.SelectedRows[0].DataBoundItem as Model;
                TitleText.Text = itemModel.Title;
                yearManufacturePicker.Value = itemModel.Year;
                brandBox.SelectedItem = itemModel.Brand;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
			var brand1 = brandBox.SelectedItem as Brand;
			if (isEdit)
            {
                if (TitleText.Text.Length > 0)
                {
                    try
                    {
                        var item = dataGridView.SelectedRows[0].DataBoundItem as Model;    //Получаем элемент из датагрида
                        var brand = brandBox.SelectedItem as Brand;
                        DataAccess.EditModel(item, brand, TitleText.Text, yearManufacturePicker.Value);//Метод изменения записи в БД
                        dataGridView.DataSource = DataAccess.GetMarks(); //Обновляем данные в датагриде
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
                        var brand = brandBox.SelectedItem as Brand;
                        DataAccess.AddNewModel(brand, TitleText.Text, yearManufacturePicker.Value);//Пробуем добавить запись
                        dataGridView.DataSource = DataAccess.GetMarks();//Обновляем данные в датагриде
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
			brandBox.SelectedItem = null;
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

		private void брендToolStripMenuItem_Click(object sender, EventArgs e)
		{
            BrandForm brandForm = new BrandForm();
            brandForm.ShowDialog();

			brandBox.DataSource = DataAccess.GetBrand();
		}
	}
}
