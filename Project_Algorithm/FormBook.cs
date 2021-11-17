using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace Project_Algorithm
{
    public partial class FormBook : Form
    {
        protected string imageLocation = "";
        public FormBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //trich xuat anh
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog(); 
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    img.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            book temp = new book();
            temp.maSach = textBox1.Text;
            temp.tenSach = textBox2.Text;
            temp.TacGia = textBox3.Text;
            temp.ChuDe = textBox4.Text;
            temp.NXB = textBox5.Text;
            if(int.TryParse(textBox6.Text, out temp.price)){};
            temp.imgSrc = imageLocation;
            temp.NgXB = new DateTime(2019 / 1 / 1);
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" &&
                textBox5.Text == "" && textBox6.Text == "")
            {
                this.Close();
                return;
            }
            Form1.a.Push(temp);
            this.Close();
        }
    }
}
