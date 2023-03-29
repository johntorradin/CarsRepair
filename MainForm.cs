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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Событие клика по кнопке
        private void button1_Click(object sender, EventArgs e)
        {
            // Создание экземпляра новой формы
            ClientsForm form = new ClientsForm();
            // Отображение новой формы
            form.Show();
        }

        // Событие клика по кнопке
        private void button2_Click(object sender, EventArgs e)
        {
            // Создание экземпляра новой формы
            RequestsForm form = new RequestsForm();
            // Отображение новой формы
            form.Show();
        }

        // Событие клика по кнопке
        private void button3_Click(object sender, EventArgs e)
        {
            // Создание экземпляра новой формы
            DamageBaseForm form = new DamageBaseForm();
            // Отображение новой формы
            form.Show();
        }

        // Событие клика по кнопке
        private void button4_Click(object sender, EventArgs e)
        {
            // Создание экземпляра новой формы
            WorksForm form = new WorksForm();
            // Отображение новой формы
            form.Show();
        }
    }
}
