using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Algorithm
{
    public partial class FormDisplay : Form
    {
        public FormDisplay()
        {
            InitializeComponent();
            createTag();
        }

        void createTag()
        {
            int n = Form1.books.Count();
            Panel oldPannel = new Panel(){Width = 0,Height = 0, Location = new Point(0,0)};

            foreach (book i in Form1.books)
            {
                Panel curPan = new Panel()
                {
                    Width = 200,
                    Height = 370,
                    Location = new Point(oldPannel.Location.X + oldPannel.Width, 0),
                };

                PictureBox pic = new PictureBox();
                pic.Location = new Point(0, 0);
                pic.Width = 200;
                pic.Height = 300;
                pic.ImageLocation = i.imgSrc;
                pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pic.Padding = new Padding(10);

                Label lbTG = new Label() { Width = 200, TextAlign = ContentAlignment.MiddleCenter };
                lbTG.Text = ("Mã sách: " + i.maSach + " Tác giả: " + i.TacGia).ToString();
                lbTG.Location = new Point(10, pic.Height);


                Label lbVT = new Label() { Width = 200, TextAlign = ContentAlignment.MiddleCenter };
                lbVT.Text = ("Vị trí: "+ i.vt).ToString();
                lbVT.Location = new Point(lbTG.Location.X, lbTG.Location.Y + 20);

                curPan.Controls.Add(pic);
                curPan.Controls.Add(lbTG);
                curPan.Controls.Add(lbVT);

                panel1.Controls.Add(curPan);
                oldPannel = curPan;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
