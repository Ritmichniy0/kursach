using CarRepair.Base;
using System;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class Main : Form
    {
		private Employee _Employee;

		public Main(Employee employee)
        {
            InitializeComponent();

            this._Employee = employee;
        }

		private void Main_Load(object sender, EventArgs e)
        {   
			dataGridView.DataSource = DataAccess.GetRepairs();
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView.Columns["ID_Repair"] != null)
                dataGridView.Columns["ID_Repair"].Visible = false;
            if (dataGridView.Columns["Car"] != null)
                dataGridView.Columns["Car"].HeaderText = "Автомобиль";
            if (dataGridView.Columns["Client"] != null)
                dataGridView.Columns["Client"].HeaderText = "Клиент";
            if (dataGridView.Columns["TotalPrice"] != null)
            {
                dataGridView.Columns["TotalPrice"].HeaderText = "Стоимость ремонта (руб.)";
                dataGridView.Columns["TotalPrice"].DefaultCellStyle.Format = "N2";
            }
            if (dataGridView.Columns["DateRepairBegin"] != null)
                dataGridView.Columns["DateRepairBegin"].HeaderText = "Дата начала";
            if (dataGridView.Columns["DateRepairEnd"] != null)
                dataGridView.Columns["DateRepairEnd"].HeaderText = "Дата окончания";
            if (dataGridView.Columns["Car_ID"] != null)
                dataGridView.Columns["Car_ID"].Visible = false;
            if (dataGridView.Columns["DetailRepair"] != null)
                dataGridView.Columns["DetailRepair"].Visible = false;
            if (dataGridView.Columns["Client_ID"] != null)
                dataGridView.Columns["Client_ID"].Visible = false;


            //Раскрашиваем строки датагрида, в зависимости выполнен ли ремонт или нет
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                var repair = item.DataBoundItem as Repair;
                if (repair.DateRepairEnd != null)
                {
                    item.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                }
            }
        }

		private void AddBtn_Click(object sender, EventArgs e)
		{
			AddEditRepairForm aef = new AddEditRepairForm(_Employee);
			aef.ShowDialog();
			dataGridView.DataSource = DataAccess.GetRepairs();
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count > 0)
			{
				var item = dataGridView.SelectedRows[0].DataBoundItem as Repair;

				AddEditRepairForm aef = new AddEditRepairForm(item, _Employee);
				aef.ShowDialog();
			}
			dataGridView.DataSource = DataAccess.GetRepairs();
		}

		private void деталиЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as Repair;
                DetailForm df = new DetailForm(item);
                df.ShowDialog();
            }
        }

        private void пометитьКакВыполненныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Получаем выбранный элемент
            if (dataGridView.SelectedRows.Count > 0)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as Repair;
                if (item.DateRepairEnd == null)
                {
                    //Устанавливаем время окончания ремонта
                    DataAccess.SetRepairIsDone(item);
                    dataGridView.DataSource = DataAccess.GetRepairs();
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                var selected = dataGridView.SelectedRows[0].DataBoundItem as Repair;
                DataAccess.DeleteRepair(selected);
                dataGridView.DataSource = DataAccess.GetRepairs();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Sing sing = new Sing();
			this.Hide();
			sing.Show();
		}

        private void чекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {

                //Получаем значения по сделанной одной работе 
                var item = dataGridView.SelectedRows[0].DataBoundItem as Repair;
                //Создаем таблицу из ДатаСета типа CheackReportDataTable
                ReportDataSet.CheackReportDataTable table = new ReportDataSet.CheackReportDataTable();
                //Получаем данные о ремонта для данного клиента
                //заполняем таблицу данными
                foreach (var detail in item.DetailRepair)
                {
                    var row = table.NewCheackReportRow();

					row.RepairDate = item.DateRepairBegin;
					row.DetailNote = detail.RepairNote;
                    row.Detail = detail.Detail.Title;
                    row.DetailPrice = detail.Detail.Price;
                    row.CountDetail = detail.Count_Detail;
					row.Employee = detail.Employee.ToString();
                    row.EmployeePrice = detail.Employee.Specialisation.Price;

                    //Количество деталей добавить
                    row.ClientName = item.Car.Client.ToString();
					row.NumberCheck = detail.ID_DetailRepair;
					row.EmployeeDoing = _Employee.FirstName + " " + _Employee.Name[0] + ". " + _Employee.SecondName[0] + ".";
                    table.Rows.Add(row);
                }
                //Создаем форму отчета, передаем ей название отчета и таблицу данных для отображения
                Reporting reporting = new Reporting("CheckReport", table);
                reporting.ShowDialog();
            }

            //if (dataGridView.SelectedRows.Count > 0)
            //{

            //    //Получаем значения по сделанной одной работе 
            //    var item = dataGridView.SelectedRows[0].DataBoundItem as Repair;
            //    //Создаем таблицу из ДатаСета типа CheackReportDataTable
            //    ReportDataSet.CheackReportDataTable table = new ReportDataSet.CheackReportDataTable();
            //    //Получаем данные о ремонта для данного клиента
            //    //заполняем таблицу данными
            //    foreach (var detail in item.DetailRepair)
            //    {
            //        var row = table.NewCheackReportRow();
            //        row.NumberCheck = detail.ID_DetailRepair;
            //        row.EmployeeDoing = _Employee.FirstName + " " + _Employee.Name[0] + ". " + _Employee.SecondName[0] + ".";
            //        row.DetailNote = detail.RepairNote;
            //        row.DetailPrice = detail.Detail.Price;
            //        row.Employee = detail.Employee.ToString();
            //        row.DetailTitle = detail.Detail.Title;
            //        //Количество деталей добавить
            //        row.ClientName = item.Car.Client.ToString();
            //        row.RepairDate = item.DateRepairBegin;
            //        table.Rows.Add(row);
            //    }
            //    //Создаем форму отчета, передаем ей название отчета и таблицу данных для отображения
            //    Reporting reporting = new Reporting("CheckReport", table);
            //    reporting.ShowDialog();
            //}
        }
	}
}
