using System;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class PeoplePickForm : Form
    {
        public Employee _Employee { get; set; }
        public DateTime start;
        public DateTime end;
        public bool isOk;

        public PeoplePickForm()
        {
            InitializeComponent();
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerStart.MaxDate = dateTimePickerEnd.Value;
        }

        private void btnYeap_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem != null)
            {
                _Employee = comboBox.SelectedItem as Employee;

                start = dateTimePickerStart.Value.Date;
                end = dateTimePickerEnd.Value.Date;

                isOk = true;
                this.Close();
            }
            else MessageBox.Show("Необходимо выбрать клиента", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PeoplePickForm_Load(object sender, EventArgs e)
        {
            comboBox.DataSource = DataAccess.GetEmployees();


            //Делаем автозаполнение при вводе в комбобокс
            //Создаем коллекцию для автозаполнения
            AutoCompleteStringCollection collect = new AutoCompleteStringCollection();
            //Заполняем эту коллекцию именами клиентов
            foreach (var item in DataAccess.GetClients())
            {
                collect.Add(item.ToString());
            }
            //Указываем комбобоксу источник для подсказки при автозаполнении
            comboBox.AutoCompleteCustomSource = collect;
            //Включаем режим автозаполнение путем дополнения и выпадающего списка
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //Указываем что при автозаполнении будет использоваться пользовательская коллекция
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
