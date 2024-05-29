using System;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class PeoplsPickForm : Form
    {
        //Поля время начала и конца (период) для выборки
        public DateTime start;
        public DateTime end;

        public bool isOk; //Флаг, показывающий, была ли нажата кнопка ОК

        public PeoplsPickForm()
        {
            InitializeComponent();
        }

        private void btnYeap_Click(object sender, EventArgs e)
        {
            start = dateTimePickerStart.Value.Date;
            end = dateTimePickerEnd.Value.Date;

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
