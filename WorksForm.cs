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
    public partial class WorksForm : Form
    {
        public WorksForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание экземпляра подключения к БД
            CarsRepairEntities db = new CarsRepairEntities();
            // Присваивание данных из таблицы БД в список
            List<Work> list = db.Works.ToList();

            // Присваивание значений в поле для вывода
            textBox6.Text = "";
            textBox6.Text += "id / client_id / request_id / repair_type / date";
            textBox6.Text += Environment.NewLine;

            // Вывод данных из списка через цикл в поле для вывода
            foreach (Work item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.client_id.ToString();
                String data3 = item.request_id.ToString();
                String data4 = item.repair_type.ToString();
                String data5 = item.date.ToString();
                textBox6.Text += $"{data1} / {data2} / {data3} / {data4} / {data5}";
                textBox6.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создание экземпляра подключения к БД
            CarsRepairEntities db = new CarsRepairEntities();

            // Создание новой записи списка
            Work work = new Work
            {
                Id = Int32.Parse(textBox1.Text),
                client_id = Int32.Parse(textBox2.Text),
                request_id = Int32.Parse(textBox3.Text),
                repair_type = textBox4.Text,
                date = textBox5.Text
            };

            // Добавление в таблицу БД новых данных списка
            db.Works.Add(work);
            // Сохранение изменений в БД
            db.SaveChanges();

            // Присваивание данных из таблицы БД в список
            List<Work> list = db.Works.ToList();

            // Присваивание значений в поле для вывода
            textBox6.Text = "";
            textBox6.Text += "id / client_id / request_id / repair_type / date";
            textBox6.Text += Environment.NewLine;

            // Вывод данных из списка через цикл в поле для вывода
            foreach (Work item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.client_id.ToString();
                String data3 = item.request_id.ToString();
                String data4 = item.repair_type.ToString();
                String data5 = item.date.ToString();
                textBox6.Text += $"{data1} / {data2} / {data3} / {data4} / {data5}";
                textBox6.Text += Environment.NewLine;
            }
        }
    }
}
