using CarRepair.Base;
using System;
using System.Windows.Forms;

namespace CarRepair.Window
{
	public partial class DashBoardForm : Form
	{
		private Form secondTicForm;
		Employee _Employee;
		static string WinLabel = "Окно : ";

		public DashBoardForm(Employee employee)
		{
			InitializeComponent();

			this.Text = string.Empty;
			this._Employee = employee;
		}

		private void DashBoardForm_Load(object sender, EventArgs e)
		{
			labelName.Text += _Employee;
			LabelRole.Text += _Employee.Role;
			OpenChildForm(new Window.StatisticForm(_Employee));
			if(_Employee.Role.ID_Role == 2)
				EmployeeBtn.Visible = false;
			else if(_Employee.Role.ID_Role == 3)
			{
				DirectoryBtn.Visible = false;
				ReportingBtn.Visible = false;
				//checkEmploy = false;
			}
		}

		private void OpenChildForm(Form childForm)
		{
			if(secondTicForm != null)
				if (secondTicForm.AccessibilityObject.Name == childForm.AccessibilityObject.Name)
					return;
			WindowLabel.Text = WinLabel + childForm.Text;
			secondTicForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelDesktop.Controls.Add(childForm);
			panelDesktop.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void RepairBtn_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Window.Main(_Employee));
		}

		private void DirectoryBtn_Click(object sender, EventArgs e)
		{
			if(panelMenuDirectory.Visible == false)
				panelMenuDirectory.Visible = true;
			else
				panelMenuDirectory.Visible = false;
		}

		private void StatisticBtn_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Window.StatisticForm(_Employee));
		}

		private void DepartmentBtn_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Window.DepartmentsForm());
		}

		private void DetailBtn_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Window.PartsForm());
		}

		private void CarBtn_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Window.ModelsForm());
		}

		private void Clientbtn_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Window.ClientsForm());
		}

		private void EmployeeBtn_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Window.EmployeesForm(_Employee.ID_Employee));
		}

		private void SettingBtn_Click(object sender, EventArgs e)
		{
			if (panelExitMenu.Visible == false)
				panelExitMenu.Visible = true;
			else
				panelExitMenu.Visible = false;
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Sing sing = new Sing();
			this.Hide();
			sing.Show();
		}

		private void ExitBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ReportingBtn_Click(object sender, EventArgs e)
		{
			if (panelMenuReporting.Visible == false)
				panelMenuReporting.Visible = true;
			else
				panelMenuReporting.Visible = false;
		}

		private void HistoryClientBtn_Click(object sender, EventArgs e)
		{
			ClientPickForm clientPickForm = new ClientPickForm();
			clientPickForm.FormClosed += ClientPickForm_FormClosed; //Подписываемся на событие закрытия формы выбора клиента
			clientPickForm.ShowDialog();
		}

		void ClientPickForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			//Если клиент выбран (не нул)
			var item = sender as ClientPickForm;
			if (item._Client != null)
			{
				//Создаем таблицу из ДатаСета типа ClientReportDataTable
				ReportDataSet.ClientReportDataTable table = new ReportDataSet.ClientReportDataTable();
				//Получаем данные о ремонта для данного клиента
				var data = DataAccess.GetRepairs(item._Client);
				//заполняем таблицу данными
				foreach (var repair in data)
				{
					foreach (var detail in repair.DetailRepair)
					{
						var row = table.NewClientReportRow();

						row.Car = repair.Car.Model.Brand.Title + "\n" + repair.Car.Model.Title + "\n" + repair.Car.Model.Year.Year + "\n" + repair.Car.Color.Title;
						row.ClientName = repair.Car.Client.ToString();
						row.RepairDate = repair.DateRepairBegin;
						row.DetailNote = detail.RepairNote;
						row.DetailPrice = detail.Detail.Price;
						row.Employee = detail.Employee.ToString();
						row.EmployeePrice = detail.Employee.Specialisation.Price;
						row.CountDetail = detail.Count_Detail;
						row.Detail = detail.Detail.Title;
						//Добавить количество и сумма
						row.RepairDate = repair.DateRepairBegin;
						table.Rows.Add(row);
					}
				}
				//Создаем форму отчета, передаем ей название отчета и таблицу данных для отображения
				OpenChildForm(new Window.Reporting("ClientReport", table));
			}
		}

		private void HistoryCarBtn_Click(object sender, EventArgs e)
		{
			CarPickForm carPickForm = new CarPickForm();
			carPickForm.FormClosing += CarPickForm_FormClosing;
			carPickForm.ShowDialog();
		}

		private void CarPickForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Проверяем, был ли выбран авто
			var item = sender as CarPickForm;
			if (item._Car != null)
			{
				//Создаем таблицу данных типа CarReportDataTable
				ReportDataSet.CarReportDataTable table = new ReportDataSet.CarReportDataTable();
				//Получаем данные о ремонтах для конкретного авто
				var data = DataAccess.GetRepairs(item._Car);
				//Заполняем таблицу
				foreach (var repair in data)
				{
					foreach (var detail in repair.DetailRepair)
					{
						var row = table.NewCarReportRow();

						row.Car = repair.Car.ToString();
						row.RepairDate = repair.DateRepairBegin;
						row.DetailNote = detail.RepairNote;
						row.DetailPrice = detail.Detail.Price;
						row.Employee = detail.Employee.ToString();
						row.EmployeePrice = detail.Employee.Specialisation.Price;
						row.CountDetail = detail.Count_Detail;
						row.Detail = detail.Detail.Title;
						//Количество деталей добавить
						table.Rows.Add(row);
					}
				}
				//Создаем форму отчета, передаем ей название отчета и таблицу данных для отображения
				OpenChildForm(new Window.Reporting("CarReport", table));
			}
		}

		private void OrderHistoryPeriodbtn_Click(object sender, EventArgs e)
		{
			DatePickForm datePickForm = new DatePickForm();
			datePickForm.FormClosing += DatePickForm_FormClosing; //Подписываемся на событие закрытия формы 
			datePickForm.ShowDialog();
		}

		private void DatePickForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			var item = sender as DatePickForm;

			if (item.isOk)
			{
				//Создаем таблицу и заполняем ее данными
				ReportDataSet.WorkReportDataTable table = new ReportDataSet.WorkReportDataTable();

				#pragma warning disable CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
				var data = DataAccess.GetRepairs(item.start.Date, item.end.Date);

				foreach (var repair in data)
				{
					foreach (var detail in repair.DetailRepair)
					{
						var row = table.NewWorkReportRow();

						row.ClientName = repair.Car.Client.ToString();
						row.RepairDate = repair.DateRepairBegin;
						row.Detail = detail.Detail.Title;
						row.DetailNote = detail.RepairNote;
						row.DetailPrice = detail.Detail.Price;
						row.Employee = detail.Employee.ToString();
						row.Car = repair.Car.Model.Brand.Title + "\n" + repair.Car.Model.Title + "\n" + repair.Car.Model.Year.Year + "\n" + repair.Car.Color.Title;
						row.DateStart = item.start.Date;
						row.DateEnd = item.end.Date;
						row.EmployeePrice = detail.Employee.Specialisation.Price;
						row.CountDetail = detail.Count_Detail;

						//Количество деталей добавить
						table.Rows.Add(row);
					}
				}
				#pragma warning restore CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
				//Создаем форму отчета, передаем ей название отчета и таблицу данных для отображения
				OpenChildForm(new Window.Reporting("WorkReport", table));
			}
		}

		private void ScheduleMonthsBtn_Click(object sender, EventArgs e)
		{

				MonthPickForm monthPickForm = new MonthPickForm();
				monthPickForm.FormClosed += MonthPickForm_FormClosed;
				monthPickForm.ShowDialog();
			
		}

		private void MonthPickForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			var item = sender as MonthPickForm;

			if (item.isOk)
			{
				ReportDataSet.CharYearMonthReportDataTable table = new ReportDataSet.CharYearMonthReportDataTable();
				#pragma warning disable CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
				var data = DataAccess.GetRepairsEnd(item.start.Date, item.end.Date);
				#pragma warning restore CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
				foreach (var repair in data)
				{
					var row = table.NewCharYearMonthReportRow();

					row.Car = repair.Car.ToString();
					row.DetailPrice = repair.TotalPrice;
					row.RepairDate = (DateTime)repair.DateRepairEnd;
					table.Rows.Add(row);
				}
				OpenChildForm(new Window.Reporting("CharMonthReport", table));
			}
		}

		private void ScheduleYearsBtn_Click(object sender, EventArgs e)
		{
			YearPickForm yearPickForm = new YearPickForm();
			yearPickForm.FormClosed += YearPickForm_FormClosed;
			yearPickForm.ShowDialog();
		}

		private void YearPickForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			var item = sender as YearPickForm;

			if (item.isOk)
			{
				ReportDataSet.CharYearMonthReportDataTable table = new ReportDataSet.CharYearMonthReportDataTable();
				#pragma warning disable CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
				var data = DataAccess.GetRepairsEnd(item.start.Date, item.end.Date);
				#pragma warning restore CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
				foreach (var repair in data)
				{
					var row = table.NewCharYearMonthReportRow();

					row.Car = repair.Car.ToString();
					row.RepairDate = (DateTime)repair.DateRepairEnd;
					row.DetailPrice = repair.TotalPrice;

					table.Rows.Add(row);
				}
				OpenChildForm(new Window.Reporting("CharYearReport", table));
			}
		}

		private void ScheduleAllEmployeesBtn_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Показание завершенных заказов всех сотрудников, показать?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				PeoplsPickForm peoplsPickForm = new PeoplsPickForm();
				peoplsPickForm.FormClosed += PeoplsPickForm_FormClosed;
				peoplsPickForm.ShowDialog();
			}
		}

		private void PeoplsPickForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			//Если клиент выбран (не нул)
			var item = sender as PeoplsPickForm;
			if (item.isOk)
			{
				//Создаем таблицу из ДатаСета типа ClientReportDataTable
				ReportDataSet.CharPeopleReportDataTable table = new ReportDataSet.CharPeopleReportDataTable();
				//Получаем данные о ремонта для данного клиента
				#pragma warning disable CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
				var data = DataAccess.GetRepairsPeopls(item.start.Date, item.end.Date);
				#pragma warning restore CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
				//заполняем таблицу данными
				foreach (var repair in data)
				{
					var row = table.NewCharPeopleReportRow();

					row.EmployeePrice = repair.Employee.Specialisation.Price;
					row.Employee = repair.Employee.ToString();
					row.DetailPrice = repair.Detail.Price;
					row.CountDetail = repair.Count_Detail;
					row.RepairDate = (DateTime)repair.Repair.DateRepairEnd;
					table.Rows.Add(row);
				}
				//Создаем форму отчета, передаем ей название отчета и таблицу данных для отображения
				OpenChildForm(new Window.Reporting("CharPeoplsReport", table));
			}
		}

		private void ScheduleEmployeeBtn_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Показание завершенных заказов сотрудника, показать?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				PeoplePickForm peoplePickForm = new PeoplePickForm();
				peoplePickForm.FormClosed += PeoplePickForm_FormClosed;
				peoplePickForm.ShowDialog();
			}
		}

		private void PeoplePickForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			//Если клиент выбран (не нул)
			var item = sender as PeoplePickForm;
			if (item._Employee != null && item.isOk)
			{
				//Создаем таблицу из ДатаСета типа ClientReportDataTable
				ReportDataSet.CharPeopleReportDataTable table = new ReportDataSet.CharPeopleReportDataTable();
				//Получаем данные о ремонта для данного клиента
				#pragma warning disable CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
				var data = DataAccess.GetRepairsPeople(item._Employee, item.start.Date, item.end.Date);
				#pragma warning restore CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
				//заполняем таблицу данными
				foreach (var repair in data)
				{
					var row = table.NewCharPeopleReportRow();

					row.EmployeePrice = repair.Employee.Specialisation.Price;
					row.Employee = repair.Employee.ToString();
					row.DetailPrice = repair.Detail.Price;
					row.CountDetail = repair.Count_Detail;
					row.RepairDate = (DateTime)repair.Repair.DateRepairEnd;
					table.Rows.Add(row);
				}
				//Создаем форму отчета, передаем ей название отчета и таблицу данных для отображения
				OpenChildForm(new Window.Reporting("CharPeopleReport", table));
			}
		}

		private void DashBoardForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
