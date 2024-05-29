using System;
using System.Windows.Forms;

namespace CarRepair.Window
{
    public partial class CarPickForm : Form
    {
        public Car _Car { get; set; }
       
        public CarPickForm()
        {
            InitializeComponent();
        }

        private void CarPickForm_Load(object sender, EventArgs e)
        {
            CarBox.DataSource = DataAccess.GetAllCars();

            //Делаем автозаполнение при вводе в комбобокс
            //Создаем коллекцию для автозаполнения
            AutoCompleteStringCollection collect = new AutoCompleteStringCollection();
            //Заполняем эту коллекцию именами клиентов
            foreach (var item in DataAccess.GetAllCars())
            {
                collect.Add(item.ToString());
            }
            //Указываем комбобоксу источник для подсказки при автозаполнении
            CarBox.AutoCompleteCustomSource = collect;
            //Включаем режим автозаполнение путем дополнения и выпадающего списка
            CarBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //Указываем что при автозаполнении будет использоваться пользовательская коллекция
            CarBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void YeapBtn_Click(object sender, EventArgs e)
        {
            if (CarBox.SelectedItem != null)
            {
                _Car = CarBox.SelectedItem as Car;
                this.Close();
            }
            else MessageBox.Show("Необходимо выбрать автомобиль", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
