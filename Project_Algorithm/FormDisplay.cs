﻿using System;
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
using System.Windows.Forms.VisualStyles;
using ContentAlignment = System.Drawing.ContentAlignment;

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
            Panel oldPannel = new Panel(){Width = 0,Height = 0, Location = new Point(0,0)};
            Node t = Form1.a.getRoot();
            int num = 1;
            while(t != null)
            {
                book i = t.Data;
                Panel curPan = new Panel()
                {
                    Width = 200,
                    Height = 370,
                    Location = new Point(oldPannel.Location.X + oldPannel.Width, oldPannel.Location.Y),
                };

                PictureBox pic = new PictureBox();
                pic.Location = new Point(0, 0);
                pic.Width = 200;
                pic.Height = 300;
                pic.ImageLocation = i.ImgSrc;
                pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pic.Padding = new Padding(10);

                Label lbTG = new Label() { Width = 200, TextAlign = ContentAlignment.MiddleCenter };
                lbTG.Text = ("Mã sách: " + i.MaSach + " Tác giả: " + i.TacGia).ToString();
                lbTG.Location = new Point(10, pic.Height);


                Label lbVT = new Label() { Width = 200, TextAlign = ContentAlignment.MiddleCenter };
                lbVT.Text = ("Vị trí: "+ i.VT).ToString();
                lbVT.Location = new Point(lbTG.Location.X, lbTG.Location.Y + 20);

                curPan.Controls.Add(pic);
                curPan.Controls.Add(lbTG);
                curPan.Controls.Add(lbVT);

                panel1.Controls.Add(curPan);
                oldPannel = curPan;
                t = t.Next;
                if (num == 6)
                {
                    num = 0;
                    oldPannel.Location = new Point(0, oldPannel.Location.Y + 370);
                    oldPannel.Width = 0;
                    oldPannel.Height = 0;
                }
                num++;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
