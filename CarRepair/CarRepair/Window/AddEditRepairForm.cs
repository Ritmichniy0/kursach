using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class AddEditRepairForm : Form
    {
        bool isEdit; //Флаг, редактируется ли ремонт или добавляется новый.
		bool cost;
		List<DetailRepair> _detailRepair { get; set; }
        //Объявляем источник привязки данных для датагрида
        BindingSource bs;
        //Объявляем поле Ремонт (если придется редактировать, получим объект данного типа в конструкторе)
        private Repair item;

        Employee _employee;

        public AddEditRepairForm(Employee employee)
        {
            InitializeComponent();

            //Инициализируем коллекцию деталей для ремонта
            _detailRepair = new List<DetailRepair>();
            this._employee = employee;
            //Инициализируем источник данных и указываем в качестве источника коллекцию
            bs = new BindingSource();
            bs.DataSource = _detailRepair;
            
		}

		//Контструкор, принимаюший объект типа Repair (для редактирования ремонта)
		public AddEditRepairForm(Repair item, Employee employee)
        {
            InitializeComponent();
            //Инициализация коллекции для деталей ремонта
            _detailRepair = new List<DetailRepair>();
			this._employee = employee;
			//Инициализируем источник данных и указываем в качестве источника коллекцию
			bs = new BindingSource();
            bs.DataSource = _detailRepair;
			dateTimeBegin.Enabled = false;
			//Указываем что происходит именно редактирование ремонта, а не добовление нового
			isEdit = true;
            this.item = item;
		}

        private void YeapBtn_Click(object sender, EventArgs e)
        {
			//Если происходит не добавление, а редактирование ремонта
			if (isEdit)
            {
                //Если все поля заполнены верно
                if (ClientBox.SelectedItem != null && CarBox.SelectedItem != null)
                {
                    //Если у ремонта существуют детали для ремонта
                    if (_detailRepair.Count > 0)
                    {
                        //Получаем из комбобоксов клиента, автомобиль
                        var client = ClientBox.SelectedItem as Client;
                        var car = CarBox.SelectedItem as Car;
                        //Подсчитываем сумму
                        var totalPrice = _detailRepair.Sum(x => x.Detail.Price * x.Count_Detail + x.Employee.Specialisation.Price);
                        //Обновляем данные о ремонте
                        DataAccess.UpdateRepair(this.item, car, totalPrice);
                        //Очищаем все детали для данного ремонта
                        DataAccess.ClearDetailsRepair(this.item);
                        //Добавляем детали, которые внес пользователь
                        foreach (var item in _detailRepair)
                        {
                            DataAccess.AddNewDetailRepair(item, this.item);
                        }
                        //Закрываем форму
                        this.Close();
                    }
                    else MessageBox.Show("Необходимо добавить хотя бы одну деталь на ремонт", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Необходимо выбрать клиента и автомобиль", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //Если происходит добавление Ремонта
            {
                //Проверяем, заполнены ли все поля
                if (ClientBox.SelectedItem != null && CarBox.SelectedItem != null)
                {
                    //Проверяем количество деталей на ремонт
                    if (_detailRepair.Count > 0)
                    {
                        //Получаем из комбобоксов клиента, автомобиль
                        var car = CarBox.SelectedItem as Car;
                        var totalPrice = _detailRepair.Sum(x => x.Count_Detail * x.Detail.Price + x.Employee.Specialisation.Price); //считаем сумму
                        //Добавляем ремонт в БД и получаем его для дальнейшей работы
                        var repair = DataAccess.AddNewRepair(car, dateTimeBegin.Value, totalPrice);
                        //Очищаем у него все детали (если были)
                        DataAccess.ClearDetailsRepair(repair);

                        //Добавляем детали, которые внес пользователь
                        foreach (var item in _detailRepair)
                        {
                            DataAccess.AddNewDetailRepair(item, repair);
                        }
                        //Закрываем форму
                        this.Close();
                    }
                    else MessageBox.Show("Необходимо добавить хотя бы одну деталь на ремонт", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Необходимо выбрать клиента и автомобиль", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddEditRepairForm_Load(object sender, EventArgs e)
        {
            if (_employee.Role_ID == 3)
            {
				ClientBtn.Visible = false;
                CarBtn.Visible = false;
			}

			specialisationBox.DisplayMember = "Title";
			detailBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			detailBox.AutoCompleteSource = AutoCompleteSource.ListItems;

			cost = false;
			//Привязываем данные к комбобоксу с клиентами
			ClientBox.DataSource = DataAccess.GetClients();
            ClientBox.SelectedItem = null;
            //Привязываем данные к комбобоксу с отделами
            departmentBox.DataSource = DataAccess.GetDepartments();
            departmentBox.SelectedItem = null;

			detailBox.DataSource = DataAccess.GetDetail();
			detailBox.SelectedItem = null;
			specialisationBox.DisplayMember = "Title";
			//Указываем в качестве источника данных - источник привязки данных
			dataGridView.DataSource = bs;

            //Если происходит редактирование
            if (isEdit)
            {
                //Коллекции с деталями присваеваем коллекцию
                _detailRepair = item.DetailRepair.ToList();
                //заполняем поля на форме данными из редактируемого ремонта
                ClientBox.SelectedItem = item.Car.Client;
                dateTimeBegin.Value = item.DateRepairBegin;
                CarBox.SelectedItem = item.Car;
                //Обновляем источник привязки
                bs.DataSource = null;
                bs.DataSource = _detailRepair;
            }
            else
				dateTimeBegin.MinDate = DateTime.Now;
			//Считаем сумму ремонта
			totalPriceLabel.Text = _detailRepair.Sum(x => x.Count_Detail * x.Detail.Price + x.Employee.Specialisation.Price).ToString() + " Руб.";
        }

        private void AddRepairBtn_Click(object sender, EventArgs e)
        {
			//Если все необходимые поля заполнены
			if (detailBox.SelectedItem != null && repairNoteText.Text.Length > 0 && employeeBox.SelectedItem != null)
            {
				DetailRepair dr = new DetailRepair()
                {
                    Employee = employeeBox.SelectedItem as Employee,
                    Detail = detailBox.SelectedItem as Detail,
                    Count_Detail = ((int)countDetailText.Value),
                    RepairNote = repairNoteText.Text
                };
                try
                {
                    //Добавляем датель в коллекцию деталей
                    _detailRepair.Add(dr);
                    //Обновляем источник привязки, чтобы новые данные отобразились в датагриде
                    bs.DataSource = null;
                    bs.DataSource = _detailRepair;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Очищаем поля, связанные с деталью ремонта
                departmentBox.SelectedItem = null;
                detailBox.SelectedItem = null;
				///////////////////////////////////////////////////////////////////////////////////////////////
				countDetailText.Value = 1;
				///////////////////////////////////////////////////////////////////////////////////////////////
				repairNoteText.Text = string.Empty;
                //Подсчитываем стоимость ремонта всего
                totalPriceLabel.Text = _detailRepair.Sum(x => x.Count_Detail * x.Detail.Price + x.Employee.Specialisation.Price).ToString() + " Руб.";
            }
            else MessageBox.Show("При добавлении детали/узла к ремонту заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
			//Переименовывем колонки таблицы
			if (dataGridView.Columns["ID_DetailRepair"] != null)
                dataGridView.Columns["ID_DetailRepair"].Visible = false;
            if (dataGridView.Columns["Repair_ID"] != null)
                dataGridView.Columns["Repair_ID"].Visible = false;
            if (dataGridView.Columns["Repair"] != null)
                dataGridView.Columns["Repair"].Visible = false;
            if (dataGridView.Columns["RepairNote"] != null)
            {
				dataGridView.Columns["RepairNote"].HeaderText = "Описание ремонта";
				dataGridView.Columns["RepairNote"].DisplayIndex = 0;
			}
			if (dataGridView.Columns["Count_Detail"] != null)
            {
				dataGridView.Columns["Count_Detail"].HeaderText = "Кол-во деталей (шт.)";
				dataGridView.Columns["Count_Detail"].DisplayIndex = 2;
			}
			if (dataGridView.Columns["Employee_ID"] != null)
                dataGridView.Columns["Employee_ID"].Visible = false;
            if (dataGridView.Columns["Employee"] != null)
                dataGridView.Columns["Employee"].HeaderText = "Отв. сотрудник";
			if (dataGridView.Columns["Detail_ID"] != null)
				dataGridView.Columns["Detail_ID"].Visible = false;
			if (dataGridView.Columns["Detail"] != null)
            {
				dataGridView.Columns["Detail"].HeaderText = "Запчасть";
				dataGridView.Columns["Detail"].DisplayIndex = 1;
			}
		}

		private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //проверяем, выбрана ли строка с деталью
            if (dataGridView.SelectedRows.Count > 0)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as DetailRepair;
                //Удаляем из коллекции деталей 
                _detailRepair.Remove(item);
                //Обновляем источник привязки
                bs.DataSource = null;
                bs.DataSource = _detailRepair;
            }
            //Пересчитываем сумму
            totalPriceLabel.Text = _detailRepair.Sum(x => x.Count_Detail * x.Detail.Price + x.Employee.Specialisation.Price).ToString() + " Руб.";
        }

        private void ClientBox_TextChanged(object sender, EventArgs e)
        {

            //проверяем, выбран ли клиент
            if (ClientBox.SelectedItem != null)
            {
                var client = ClientBox.SelectedItem as Client;
				CarBox.DataSource = DataAccess.GetCars(client);
				if (CarBox.Items.Count == 0)
					CarBox.Text = null;
			}
			else CarBox.DataSource = null;

        }

        private void CarBtn_Click(object sender, EventArgs e)
        {
            //Проверяем, выбран ли клиент
            if (ClientBox.SelectedItem != null)
            {
                var client = ClientBox.SelectedItem as Client;
                //Создаем и открываем форму
                CarsForm cf = new CarsForm(client);
                cf.ShowDialog();
                //Обновляем комбобокс данными
                CarBox.DataSource = DataAccess.GetCars(client);
            }
            else MessageBox.Show("Необходимо выбрать клиента", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void departmentBox_TextChanged(object sender, EventArgs e)
        {
            //проверяем, выбран ли элемент
            if (departmentBox.SelectedItem != null)
            {
                //Получаем его
                var depart = departmentBox.SelectedItem as Department;
                specialisationBox.DataSource = DataAccess.GetSpecialisation(depart);
				specialisationBox.DisplayMember = "Title";
				if (specialisationBox.Items.Count == 0)
					specialisationBox.Text = null;
			}
            else specialisationBox.DataSource = null;
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            //Создаем и открываем форму клиентов
            ClientsForm cf = new ClientsForm();
            cf.ShowDialog();
            //Обновляем данные в комбобоксе
            ClientBox.DataSource = DataAccess.GetClients();
        }

		private void specialisationBox_TextChanged(object sender, EventArgs e)
		{
			//проверяем, выбран ли элемент
			if (specialisationBox.SelectedItem != null)
			{
				//Получаем его
				var depart = specialisationBox.SelectedItem as Specialisation;
				employeeBox.DataSource = DataAccess.GetEmployees(depart);
                if(employeeBox.Items.Count == 0)
					employeeBox.Text = null;
			}
			else employeeBox.DataSource = null;
		}

		private void detailBox_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (detailBox.SelectedItem != null && cost)
			{
				MessageBox.Show("Если деталь не требует количество, не используете кол-во");
			}
            cost = true;
		}
	}
}
