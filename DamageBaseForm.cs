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
    public partial class DamageBaseForm : Form
    {
        public DamageBaseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание экземпляра подключения к БД
            CarsRepairEntities db = new CarsRepairEntities();
            // Присваивание данных из таблицы БД в список
            List<DamageBas> list = db.DamageBases.ToList();

            // Присваивание значений в поле для вывода
            textBox5.Text = "";
            textBox5.Text += "id / damage_type / damage_place / repair_type";
            textBox5.Text += Environment.NewLine;

            // Вывод данных из списка через цикл в поле для вывода
            foreach (DamageBas item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.damage_type.ToString();
                String data3 = item.damage_place.ToString();
                String data4 = item.repair_type.ToString();
                textBox5.Text += $"{data1} / {data2} / {data3} / {data4}";
                textBox5.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создание экземпляра подключения к БД
            CarsRepairEntities db = new CarsRepairEntities();

            // Создание новой записи списка
            DamageBas damage = new DamageBas
            {
                Id = Int32.Parse(textBox1.Text),
                damage_type = textBox2.Text,
                damage_place = textBox3.Text,
                repair_type = textBox4.Text
            };

            // Добавление в таблицу БД новых данных списка
            db.DamageBases.Add(damage);
            // Сохранение изменений в БД
            db.SaveChanges();

            // Присваивание данных из таблицы БД в список
            List<DamageBas> list = db.DamageBases.ToList();

            // Присваивание значений в поле для вывода
            textBox5.Text = "";
            textBox5.Text += "id / damage_type / damage_place / repair_type";
            textBox5.Text += Environment.NewLine;

            // Вывод данных из списка через цикл в поле для вывода
            foreach (DamageBas item in list)
            {
                String data1 = item.Id.ToString();
                String data2 = item.damage_type.ToString();
                String data3 = item.damage_place.ToString();
                String data4 = item.repair_type.ToString();
                textBox5.Text += $"{data1} / {data2} / {data3} / {data4}";
                textBox5.Text += Environment.NewLine;
            }
        }
    }
}
