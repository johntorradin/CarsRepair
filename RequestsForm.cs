using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsRepair
{
    public partial class RequestsForm : Form
    {
        public RequestsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание экземпляра подключения к БД
            CarsRepairEntities db = new CarsRepairEntities();
            // Присваивание данных из таблицы БД в список
            List<Request> list = db.Requests.ToList();

            // Присваивание значений в поле для вывода
            textBox6.Text = "";
            textBox6.Text += "id / client_id / car / title / text";
            textBox6.Text += Environment.NewLine;

            // Вывод данных из списка через цикл в поле для вывода
            foreach (Request item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.client_id.ToString();
                String data3 = item.car.ToString();
                String data4 = item.title.ToString();
                String data5 = item.text.ToString();
                textBox6.Text += $"{data1} / {data2} / {data3} / {data4} / {data5}";
                textBox6.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создание экземпляра подключения к БД
            CarsRepairEntities db = new CarsRepairEntities();

            // Создание новой записи списка
            Request request = new Request
            {
                Id = Int32.Parse(textBox1.Text),
                client_id = Int32.Parse(textBox2.Text),
                car = textBox3.Text,
                title = textBox4.Text,
                text = textBox5.Text
            };

            // Добавление в таблицу БД новых данных списка
            db.Requests.Add(request);
            // Сохранение изменений в БД
            db.SaveChanges();

            // Присваивание данных из таблицы БД в список
            List<Request> list = db.Requests.ToList();

            // Присваивание значений в поле для вывода
            textBox6.Text = "";
            textBox6.Text += "id / client_id / car / title / text";
            textBox6.Text += Environment.NewLine;

            // Вывод данных из списка через цикл в поле для вывода
            foreach (Request item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.client_id.ToString();
                String data3 = item.car.ToString();
                String data4 = item.title.ToString();
                String data5 = item.text.ToString();
                textBox6.Text += $"{data1} / {data2} / {data3} / {data4} / {data5}";
                textBox6.Text += Environment.NewLine;
            }
        }
    }
}
