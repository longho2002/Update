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
        public static ListBook a = new ListBook();


        public TextBox tb1 = new TextBox();
        public Form1()
        {
            InitializeComponent();
            book temp = new book();
            temp.maSach = "001";
            temp.tenSach = "Nhà giả kim";
            temp.TacGia = "Quốc Trung";
            temp.ChuDe = "Triết học";
            temp.NXB = "Kim Đồng";
            temp.price = 290000;
            temp.vt = "A-03";
            temp.imgSrc = "C:/Users/Thai_Long/Downloads/giakim.jpg";
            temp.NgXB = new DateTime(2019, 1, 1);
            for (int i = 0; i < 20; i++)
            {
                a.Push(temp);
            }
            displayTag();
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

        public void displayTag()
        {
            Panel oldPannel = new Panel() {Width = 0, Height = 0, Location = new Point(0, 0)};
            Node t = Form1.a.getRoot();
            while (t != null)
            {
                book i = t.Data;
                Panel curPan = new Panel()
                {
                    Width = 300,
                    Height = 460,
                    Location = new Point(oldPannel.Location.X + oldPannel.Width + 10, 5),
                };
                curPan.AutoSize = true;
                PictureBox pic = new PictureBox();
                pic.AutoSize = true;
                pic.Location = new Point(0, 0);
                pic.Width = 300;
                pic.Height = 400;
                pic.ImageLocation = i.imgSrc;
                pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pic.Padding = new Padding(10);

                Label lbTG = new Label()
                {
                    Width = 400, 
                    TextAlign = ContentAlignment.MiddleCenter,
                    Margin = new Padding(100,0,0,0)
                };
                lbTG.Text = ("Mã sách: " + i.maSach + " Tác giả: " + i.tenSach).ToString();
                lbTG.Font = new Font("Arial", 10, FontStyle.Bold);
                lbTG.Location = new Point(10, pic.Height + 10);
                lbTG.AutoSize = true;

                curPan.BorderStyle = BorderStyle.FixedSingle;
                curPan.Margin = new Padding(100, 0, 0,5);
                curPan.Controls.Add(pic);
                curPan.Controls.Add(lbTG);
                PannelDisplayForm1.Controls.Add(curPan);

                oldPannel = curPan;
                t = t.Next;
            }
        }
    }
}
