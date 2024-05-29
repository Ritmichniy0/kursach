using System.Linq;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class DetailForm : Form
    {
        private Repair item;

        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(Repair item)
        {
            InitializeComponent();
            //Заполняем датагрид данными для данного ремонта
            this.item = item;
            dataGridView.DataSource = item.DetailRepair.ToList();
        }

        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView.Columns["ID_DetailRepair"] != null)
                dataGridView.Columns["ID_DetailRepair"].Visible = false;
            if (dataGridView.Columns["Repair_ID"] != null)
                dataGridView.Columns["Repair_ID"].Visible = false;
            if (dataGridView.Columns["Repair"] != null)
                dataGridView.Columns["Repair"].Visible = false;
            if (dataGridView.Columns["Employee_ID"] != null)
                dataGridView.Columns["Employee_ID"].Visible = false;
            if (dataGridView.Columns["Employee"] != null)
                dataGridView.Columns["Employee"].HeaderText = "Отв. сотрудник";
			if (dataGridView.Columns["Count_Detail"] != null)
				dataGridView.Columns["Count_Detail"].HeaderText = "Кол-во (шт.)";
            if (dataGridView.Columns["Detail_ID"] != null)
                dataGridView.Columns["Detail_ID"].Visible = false;
			if (dataGridView.Columns["Detail"] != null)
            {
				dataGridView.Columns["Detail"].HeaderText = "Название запчасти";
				dataGridView.Columns["Detail"].DisplayIndex = 1;
			}
			if (dataGridView.Columns["RepairNote"] != null)
            {
				dataGridView.Columns["RepairNote"].HeaderText = "Описание ремонта";
				dataGridView.Columns["RepairNote"].DisplayIndex = 0;
			}
		}
    }
}
