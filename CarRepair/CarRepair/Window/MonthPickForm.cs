using System;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class MonthPickForm : Form
    {
        //Поля время начала и конца (период) для выборки
        public DateTime start;
        public DateTime end;

        public bool isOk; //Флаг, показывающий, была ли нажата кнопка ОК

        public MonthPickForm()
        {
            InitializeComponent();

            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "MMMM - yyyy";
            dateTimePickerStart.ShowUpDown = true;

            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "MMMM - yyyy";
            dateTimePickerEnd.ShowUpDown = true;
            
            //Защита от >28 дня
            dateTimePickerStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

		private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
		{
			// Если год в dateTimePickerEnd отличается от выбранного года в dateTimePickerStart,
			// обновляем год в dateTimePickerEnd
			if (dateTimePickerEnd.Value.Year != dateTimePickerStart.Value.Year)
			{
				dateTimePickerEnd.Value = new DateTime(dateTimePickerStart.Value.Year, dateTimePickerEnd.Value.Month, 1);
			}
			// Если месяц в dateTimePickerEnd меньше выбранного месяца в dateTimePickerStart,
			// обновляем месяц в dateTimePickerEnd
			else if (dateTimePickerEnd.Value < dateTimePickerStart.Value)
			{
				dateTimePickerEnd.Value = new DateTime(dateTimePickerStart.Value.Year, dateTimePickerStart.Value.Month, 1);
			}
		}

		private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
		{
			// Если год в dateTimePickerStart отличается от выбранного года в dateTimePickerEnd,
			// обновляем год и месяц в dateTimePickerStart
			if (dateTimePickerStart.Value.Year != dateTimePickerEnd.Value.Year)
			{
				dateTimePickerStart.Value = new DateTime(dateTimePickerEnd.Value.Year, dateTimePickerStart.Value.Month, 1);
			}
			// Если месяц в dateTimePickerStart больше выбранного месяца в dateTimePickerEnd,
			// обновляем месяц в dateTimePickerStart
			else if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
			{
				dateTimePickerStart.Value = new DateTime(dateTimePickerEnd.Value.Year, dateTimePickerEnd.Value.Month, 1);
			}
		}

		private void btnYeap_Click(object sender, EventArgs e)
        {
            int Day = 1;

            start = new DateTime(dateTimePickerStart.Value.Year, dateTimePickerStart.Value.Month, Day);

            Day = 30;
             if (dateTimePickerEnd.Value.Month == 2)
                Day = 28;
                
            end = new DateTime(dateTimePickerEnd.Value.Year, dateTimePickerEnd.Value.Month, Day);

            isOk = true;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
