using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CarRepair.Window
{
	public partial class StatisticForm : Form
	{
		Employee _Employee;
		public StatisticForm(Employee employee)
		{
			InitializeComponent();
			this._Employee = employee;
		}

		private void StatisticForm_Load(object sender, EventArgs e)
		{
			// Получение первого дня текущего месяца
			DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

			// Получение последнего дня текущего месяца
			DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

			var repairs = DataAccess.GetRepairsPeople(_Employee, firstDayOfMonth, lastDayOfMonth);

			var repairNotEnd = DataAccess.GetRepairsPeople(_Employee, firstDayOfMonth);

			labelWork.Text += "\n" + repairs.Count.ToString();
			labelWorkNotEnd.Text += "\n" + repairNotEnd.Count.ToString();
			labelWorkAll.Text += "\n" + (repairNotEnd.Count + repairs.Count).ToString();

			chartEmployee.Series.Clear();

			// Создание серии данных для Chart
			Series series = new Series("Ремонты");
			series.ChartType = SeriesChartType.Column;


			chartEmployee.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM.yyyy"; // Формат отображения даты
			chartEmployee.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;

			// Добавление данных в серию
			foreach (var repair in repairs)
			{
				DataPoint dataPoint = new DataPoint();
				decimal price = repair.Count_Detail * repair.Detail.Price + repair.Employee.Specialisation.Price;
				dataPoint.Label = price.ToString(); // Здесь задаем значение для отображения на столбце
				dataPoint.Font = new Font("Arial", 13);
				dataPoint.LabelForeColor = System.Drawing.Color.Gray;
				series.Points.Add(dataPoint);
				dataPoint.SetValueXY(repair.Repair.DateRepairEnd, price);
			}
			chartEmployee.Series.Add(series);
		}
	}
}
