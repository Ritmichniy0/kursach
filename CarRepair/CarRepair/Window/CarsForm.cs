using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class CarsForm : Form
    {
        bool isEdit; //Флаг, указывающий была ли нажата кнопка редактирования.
        Client _Client;

        public CarsForm(Client client)
        {
            InitializeComponent();

			gosNumTextBox.Mask = ">L000LL000";
			this._Client = client;
        }

		private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Проверяем, выбрана ли строка
            if (dataGridView.SelectedRows.Count > 0)
            {
                //Получаем связанный с этой строкой элемент
                var item = dataGridView.SelectedRows[0].DataBoundItem as Car;
                DataAccess.DeleteCar(item);
                dataGridView.DataSource = DataAccess.GetCars(_Client); //Обновляем данные в датагриде
            }
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            //DataGridView указываем в качестве источника данных список сотрудников
            dataGridView.DataSource = DataAccess.GetCars(_Client);
            brandBox.DataSource = DataAccess.GetMarks();
            colorBox.DataSource = DataAccess.GetColor();
            DisableControls(); //Отключаем кнопку сохр и тектовое поля.
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

			//Проверяем датагрид на наличие нужной колонки, если она есть то выключаем ее или переименовываем
			if (dataGridView.Columns["ID_Car"] != null)
                dataGridView.Columns["ID_Car"].Visible = false;
            if (dataGridView.Columns["Client"] != null)
                dataGridView.Columns["Client"].Visible = false;
            if (dataGridView.Columns["Model"] != null)
            {
				dataGridView.Columns["Model"].DisplayIndex = 0;
				dataGridView.Columns["Model"].HeaderText = "Авто";
			}
			if (dataGridView.Columns["Number"] != null)
                dataGridView.Columns["Number"].HeaderText = "Гос. номер";
            if (dataGridView.Columns["Repair"] != null)
                dataGridView.Columns["Repair"].Visible = false;
            if (dataGridView.Columns["Client_ID"] != null)
                dataGridView.Columns["Client_ID"].Visible = false;
            if (dataGridView.Columns["Model_ID"] != null)
                dataGridView.Columns["Model_ID"].Visible = false;
			if (dataGridView.Columns["Color"] != null)
				dataGridView.Columns["Color"].HeaderText = "Цвет";
			if (dataGridView.Columns["Color_ID"] != null)
				dataGridView.Columns["Color_ID"].Visible = false;
		}

        //Обработчик события переключения строк
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //Проверяем, выбрана ли строка
            if (dataGridView.SelectedRows.Count > 0)
            {
                //Получаем связанный с этой строкой элемент
                var item = dataGridView.SelectedRows[0].DataBoundItem as Car;
                //Заполняем поля данными из элемента
                gosNumTextBox.Text = item.Number;
                colorBox.SelectedItem = item.Color;
                brandBox.SelectedItem = item.Model;
                vinTextBox.Text = item.VIN.ToString();
            }
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
            if (isEdit)//Если вкл. режим редактирования
            {
                if (colorBox.SelectedItem != null && brandBox.SelectedItem != null && (gosNumTextBox.MaskCompleted || gosNumTextBox.Text.Length == 8) && vinTextBox.MaskCompleted)//Если данные введены

                {
                    try //Пробуем изменить запись
                    {
                        var mark = brandBox.SelectedItem as Model;
                        var itemColor = colorBox.SelectedItem as Color;
                        var item = dataGridView.SelectedRows[0].DataBoundItem as Car; //Получаем элемент из датагрида
                        DataAccess.UpdateCar(item, mark, itemColor, gosNumTextBox.Text, vinTextBox.Text); //Метод изменения записи в БД
                        dataGridView.DataSource = DataAccess.GetCars(_Client); //Обновляем данные в датагриде
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
                if (colorBox.SelectedItem != null && brandBox.SelectedItem != null && (gosNumTextBox.MaskCompleted || gosNumTextBox.Text.Length == 8) && vinTextBox.MaskCompleted)//Если данные введены
                {
                    try
                    {
                        var mark = brandBox.SelectedItem as Model;
						var itemColor = colorBox.SelectedItem as Color;
						DataAccess.AddNewCar(_Client, mark, itemColor, gosNumTextBox.Text, vinTextBox.Text);//Пробуем добавить запись
                        dataGridView.DataSource = DataAccess.GetCars(_Client); //Обновляем данные в датагриде
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
			gosNumTextBox.Text = vinTextBox.Text = string.Empty;
            colorBox.SelectedItem = null;
			brandBox.SelectedItem = null;
        }

        //Метод отключает текстбоксы и кнопку сохранить и активирует кнопки добавить и редактировать
        void DisableControls()
        {
            colorBox.Enabled = SaveBtn.Enabled = gosNumTextBox.Enabled = vinTextBox.Enabled = brandBox.Enabled = false;
            EditBtn.Enabled = AddBtn.Enabled = true;
        }

        //Метод включает текстбоксы и кнопку сохранить
        void EnableControls()
        {
            colorBox.Enabled = SaveBtn.Enabled = gosNumTextBox.Enabled = vinTextBox.Enabled = brandBox.Enabled = true;
            SaveBtn.Enabled = true;
        }
	}
}
