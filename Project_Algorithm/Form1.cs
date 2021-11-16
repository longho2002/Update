using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Algorithm
{

    public partial class Form1 : Form
    {
        public static List<book> books = new List<book>();


        public TextBox tb1 = new TextBox();
        public Form1()
        {
            InitializeComponent();

            ListBook bk = new ListBook();
            book a = new book(); 
            bk.books.Add(a);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDisplay b = new FormDisplay();
            b.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBook b = new FormBook();
            b.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb1.Location = new Point(CB_timkiem.Location.X + 20 + CB_timkiem.Width, CB_timkiem.Location.Y);
            tb1.Width = 300;
            tb1.Height = 39;
            tb1.Font = new Font("Arial", 20);
            panel3.Controls.Add(tb1);
        }
    }
}
