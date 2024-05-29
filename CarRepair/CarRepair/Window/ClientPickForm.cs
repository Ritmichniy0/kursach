using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRepair.Window
{
    public partial class ClientPickForm : Form
    {
        public Client _Client { get; set; }

        public ClientPickForm()
        {
            InitializeComponent();
        }

        private void YeapBtn_Click(object sender, EventArgs e)
        {
            if (ComboBox.SelectedItem != null)
            {
                _Client = ComboBox.SelectedItem as Client;
                this.Close();
            }
            else MessageBox.Show("Необходимо выбрать клиента", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientPickForm_Load(object sender, EventArgs e)
        {
            ComboBox.DataSource = DataAccess.GetClients();


            //Делаем автозаполнение при вводе в комбобокс
            //Создаем коллекцию для автозаполнения
            AutoCompleteStringCollection collect = new AutoCompleteStringCollection();
            //Заполняем эту коллекцию именами клиентов
            foreach (var item in DataAccess.GetClients())
            {
                collect.Add(item.ToString());
            }
            //Указываем комбобоксу источник для подсказки при автозаполнении
            ComboBox.AutoCompleteCustomSource = collect;
            //Включаем режим автозаполнение путем дополнения и выпадающего списка
            ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //Указываем что при автозаполнении будет использоваться пользовательская коллекция
            ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
