using System;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class YearPickForm : Form
    {
        //Поля время начала и конца (период) для выборки
        public DateTime start;
        public DateTime end;

        public bool isOk; //Флаг, показывающий, была ли нажата кнопка ОК

        public YearPickForm()
        {
            InitializeComponent();

            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "yyyy";
            dateTimePickerStart.ShowUpDown = true;

            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "yyyy";
            dateTimePickerEnd.ShowUpDown = true;

        }

        private void btnYeap_Click(object sender, EventArgs e)
        {
            int Day = 1;
            int Month = 1;

            start = new DateTime(dateTimePickerStart.Value.Year, Month, Day);

            Day = 30;
            Month = 12;

            end = new DateTime(dateTimePickerEnd.Value.Year, Month, Day);

            isOk = true;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value;
        }
    }
}
