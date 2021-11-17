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
        protected Node p;
        protected bool changeImg = false;
        public FormBook()
        {
            InitializeComponent();
            showForm();
        }

        private void button1_Click(object sender, EventArgs e) //trich xuat anh
        {
            imageLocation = "";
            changeImg = false;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    img.ImageLocation = imageLocation;
                    changeImg = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            book temp = new book();
            temp.MaSach = textBox1.Text;
            temp.TenSach = textBox2.Text;
            temp.TacGia = textBox3.Text;
            temp.ChuDe = textBox4.Text;
            temp.ChuDe = textBox7.Text;
            temp.NXB = textBox5.Text == "" ? (Application.StartupPath + "\\Resources\\" + "noneimg.png") : imageLocation;
            int a = 0;
            if (int.TryParse(textBox6.Text, out a))
            {
                temp.Price = a;
            };
            temp.ImgSrc = imageLocation;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            p.Data.MaSach = textBox1.Text;
            p.Data.TenSach = textBox2.Text;
            p.Data.TacGia = textBox3.Text;
            p.Data.ChuDe = textBox4.Text;
            p.Data.NXB = textBox5.Text;
            p.Data.VT = textBox7.Text;
            int a;
            if (int.TryParse(textBox6.Text, out a))
            {
                p.Data.Price = a;
            }
            p.Data.NgXB = dateTimePicker1.Value;
            if (changeImg) p.Data.ImgSrc = imageLocation;
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            p.Data.MaSach = textBox1.Text;
            p.Data.TenSach = textBox2.Text;
            p.Data.TacGia = textBox3.Text;
            p.Data.ChuDe = textBox4.Text;
            p.Data.NXB = textBox5.Text;
            p.Data.VT = textBox7.Text;
            int a;
            if (int.TryParse(textBox6.Text, out a))
            {
                p.Data.Price = a;
            }
            p.Data.NgXB = dateTimePicker1.Value;
            p.Data.ImgSrc = textBox5.Text == "" ? (Application.StartupPath + "\\Resources\\" + "noneimg.png") : imageLocation;
        }
        protected void showForm()
        {
            if (Form1.flag == false)
            {
                btnADD.Hide();
                int x = btnCan.Location.X;
                int y = btnCan.Location.Y;
                int tmpWidth = btnCan.Width;
                int tmpHeight = btnCan.Height;
                btnCan.Location = (new Point(x - tmpWidth, y));
                Button Delete = new Button()
                {
                    Width = tmpWidth,
                    Height = tmpHeight,
                    Text = "DELETE"
                };
                Delete.Location = new Point(x + 10, y);
                Button Adjust = new Button()
                {
                    Width = tmpWidth,
                    Height = tmpHeight,
                    Text = "UPDATE"
                };
                Adjust.Location = new Point(Delete.Location.X + tmpWidth + 10, Delete.Location.Y);
                Adjust.Click += btnAdjust_Click;
                Delete.Click += btnDelete_Click;
                PanBtn.Controls.Add(Adjust);
                PanBtn.Controls.Add(Delete);
                UpdateUI();
            }

        }

        protected void UpdateUI()
        {
            p = Form1.a.getRoot();
            for (int i = 0; i < Form1.slide; i++)
            {
                p = p.Next;
            }
            textBox1.Text = p.Data.MaSach;
            textBox2.Text = p.Data.TenSach;
            textBox3.Text = p.Data.TacGia;
            textBox4.Text = p.Data.ChuDe;
            textBox5.Text = p.Data.NXB;
            textBox7.Text = p.Data.VT;
            textBox6.Text = p.Data.Price.ToString();
            dateTimePicker1.Value = p.Data.NgXB;
            img.Image = new Bitmap(p.Data.ImgSrc);
        }
    }
}
