using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CarsRepair
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание экземпляра подключения к БД
            CarsRepairEntities db = new CarsRepairEntities();
            // Присваивание данных из таблицы БД в список
            List<Client> list = db.Clients.ToList();

            // Присваивание значений в поле для вывода
            textBox6.Text = "";
            textBox6.Text += "id / fio / telephone / email / passport";
            textBox6.Text += Environment.NewLine;

            // Вывод данных из списка через цикл в поле для вывода
            foreach (Client item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.fio.ToString();
                String data3 = item.telephone.ToString();
                String data4 = item.email.ToString();
                String data5 = item.passport.ToString();
                textBox6.Text += $"{data1} / {data2} / {data3} / {data4} / {data5}";
                textBox6.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создание экземпляра подключения к БД
            CarsRepairEntities db = new CarsRepairEntities();

            // Создание новой записи списка
            Client client = new Client
            {
                Id = Int32.Parse(textBox1.Text),
                fio = textBox2.Text,
                telephone = textBox3.Text,
                email = textBox4.Text,
                passport = textBox5.Text
            };

            // Добавление в таблицу БД новых данных списка
            db.Clients.Add(client);
            // Сохранение изменений в БД
            db.SaveChanges();

            // Присваивание данных из таблицы БД в список
            List<Client> list = db.Clients.ToList();

            // Присваивание значений в поле для вывода
            textBox6.Text = "";
            textBox6.Text += "id / fio / telephone / email / passport";
            textBox6.Text += Environment.NewLine;

            // Вывод данных из списка через цикл в поле для вывода
            foreach (Client item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.fio.ToString();
                String data3 = item.telephone.ToString();
                String data4 = item.email.ToString();
                String data5 = item.passport.ToString();
                textBox6.Text += $"{data1} / {data2} / {data3} / {data4} / {data5}";
                textBox6.Text += Environment.NewLine;
            }
        }
    }
}
