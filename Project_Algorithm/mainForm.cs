using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace Project_Algorithm
{

    public partial class mainForm : Form
    {
        public static ListBook a = new ListBook();
        public static bool flag = true;
        public static string slideID;
        public TextBox tb1 = new TextBox();
        public int chooseFind = -1;
        protected bool changeDisplay = true;
        public mainForm()
        {
            InitializeComponent();
            pushData();
            listShow.Hide();
            showList(a);
            displayTag(a);
        }

        private void pushData()
        {
            a.Push(new book("001", "Code dạo ký sự", "Phạm Huy Hoàng", "Lập trình", "Dân Trí", 119000, "A-04", new DateTime(2017, 01, 01), Application.StartupPath + "\\Resources\\" + "code dao ky su.jpg"));
            a.Push(new book("002", "Ngày xưa có một chuyện tình", "Nguyễn Nhật Ánh", "Văn học", "Kim Đồng", 110000, "A-06", new DateTime(2017, 10, 24), Application.StartupPath + "\\Resources\\" + "ngay xua co 1 chuyen tinh.jpg"));
            a.Push(new book("003", "Tôi thấy hoa vàng trên cỏ xanh", "Nguyễn Nhật Ánh", "Văn học", "Kim Đồng", 150000, "A-06", new DateTime(2018, 08, 14), Application.StartupPath + "\\Resources\\" + "toi thay hoa vang tren co xanh.jpg"));
            a.Push(new book("004", "Đắc Nhân Tâm", "Dale Carnegie", "Triết học", "Tổng Hợp", 70000, "A-01", new DateTime(2008, 9, 12), Application.StartupPath + "\\Resources\\" + "dac nhan tam.jpg"));
            a.Push(new book("005", "300 Bài code thiếu nhi", "Nhiều tác giả", "Lập trình", "Tổng hợp", 100000, "A-02", new DateTime(2018, 5, 27), Application.StartupPath + "\\Resources\\" + "code thieu nhi.jpg"));
            a.Push(new book("006", "Tuổi trẻ đáng giá bao nhiêu", "Quốc Trung", "Văn học", "Hội nhà văn", 700000, "A-04", new DateTime(2019, 1, 15), Application.StartupPath + "\\Resources\\" + "tuoi tre dang gia bao nhieu.jpg"));
            a.Push(new book("007", "Cho tôi xin một vé đi tuổi thơ", "Nguyễn Nhật Ánh", "Văn học", "Kim Đồng", 108000, "A - 06", new DateTime(2019, 05, 06), Application.StartupPath + "\\Resources\\" + "cho toi xin 1 ve di tuoi tho.jpg"));
            a.Push(new book("008", "Đời thay đổi khi chúng ta thay đổi", " Andrew Matthews", "Văn học", "Trẻ", 50000, "A - 04", new DateTime(2019, 04, 28), Application.StartupPath + "\\Resources\\" + "doi thay doi khi chung ta thay doi.jpg"));
            a.Push(new book("009", "Cô gái đến từ hôm qua", "Nguyễn Nhật Ánh", "Văn học", "Trẻ ", 68000, "A-04", new DateTime(2017, 06, 10), Application.StartupPath + "\\Resources\\" + "cô gái đén từ hôm qua.jpg"));
            a.Push(new book("010", "Khi hơi thở hóa thinh không", "Pual Kalathini", "Hồi kí", "Omega plus", 872000, "A-01", new DateTime(2016, 1, 12), Application.StartupPath + "\\Resources\\" + "KHI HƠI THỞ HÓA THINH KHÔNG.jpg"));
            a.Push(new book("011", "Đi tìm lẽ sống", "Viktor Frankl", "Tâm lý học", "Tổng Hợp ", 70200, "A-01", new DateTime(2016, 07, 01), Application.StartupPath + "\\Resources\\" + "di-tim-le-song.jpg"));
            a.Push(new book("012", "Phi lí một cách hợp lí", "Dan Ariely", "Tâm lý học", "Thế giới ", 74250, "A-02", new DateTime(2016, 08, 06), Application.StartupPath + "\\Resources\\" + "phi ly mot cach hop ly.jpg"));
            a.Push(new book("013", "Cánh đồng bất tận ", "Nguyễn Ngọc Tư", "Văn học", "Trẻ ", 68000, "A-06", new DateTime(2006, 1, 1), Application.StartupPath + "\\Resources\\" + "Canh-dong-bat-tan.jpg"));
            a.Push(new book("014", "Tôi đi học", "Nguyễn Ngọc Kí", "Tự truyện", "Tổng hợp ", 43200, "A-05", new DateTime(2019, 09, 10), Application.StartupPath + "\\Resources\\" + "toi di hoc.jpg"));
            a.Push(new book("015", "Những tâm hồn dấu yêu", "Nguyễn Ngọc Ký", "Tự truyện", "Trẻ ", 99750, "A-04", new DateTime(2012, 02, 9), Application.StartupPath + "\\Resources\\" + "nhung_tam_hon_dau_yeu.jpg"));
            //a.Push(new book("016", "Để gió cuốn đi", "Ái Vân", "Văn học", "Phương Đông ", 168000, "A - 02",  new DateTime(2016, 05, 21),""));
            //a.Push(new book("017", "Cỗ máy thời gian", "H.G.WELLS", "Khoa học viễn tưởng", "Đông A ", 60000, "A-01", new DateTime(2018, 10, 10), ""));
            //a.Push(new book("018", "Cỗ máy thời gian", "H.G.WELLS", "Khoa học viễn tưởng", "Đông A ", 60000, "A-03", new DateTime(2018, 10, 10), ""));
            //a.Push(new book("019", "Tam thể", "Lưu Từ Hân", "Khoa học viễn tưởng", "Trùng Khánh", 135000, "A-05", new DateTime(2008, 05, 01), ""));
        }
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedIndex != null)
            {
                int res;
                int.TryParse(cb.SelectedIndex.ToString(), out res);
                if (res == 0)
                    a.SortMaSach(0);
                else if (res == 1)
                    a.SortTenSach(0);
                displayTag(a);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            FormDisplay b = new FormDisplay();
            b.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            flag = true;
            FormBook b = new FormBook();
            b.ShowDialog();
            if (changeDisplay)
                displayTag(a);
            else
                showList(a);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb1.Location = new Point(CB_search.Location.X + 20 + CB_search.Width, CB_search.Location.Y);
            tb1.Width = 450;
            tb1.Height = 39;
            tb1.Font = new Font("Arial", 20);
            tb1.TextChanged += textFindChange;
            panel3.Controls.Add(tb1);
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedIndex != null)
            {
                int.TryParse(cb.SelectedIndex.ToString(), out chooseFind);
            }
        }
        private void textFindChange(object sender, EventArgs e)
        {
            string s = (sender as TextBox).Text;
            switch (chooseFind)
            {
                case 0:
                    displayTag(a.findMaSach(s));
                    break;
                case 1:
                    displayTag(a.findTenSach(s));
                    break;
                case 2:
                    displayTag(a.findTacGia(s));
                    break;
                case 3:
                    displayTag(a.findNXB(s));
                    break;
                case 4:
                    displayTag(a.findPrice(s));
                    break;
                case 5:
                    displayTag(a.findCat(s));
                    break;
                case 6:
                    displayTag(a.findLocation(s));
                    break;
                case 7:
                    {
                        if (s != "")
                            displayTag(a.findDate(s));
                        else
                            displayTag(a);
                        break;
                    }
            }

        }
        public void displayTag(ListBook b)
        {
            if (b == null)
                return;
            PannelDisplayForm1.Controls.Clear(); // xóa toàn bộ thẻ pannel
            Panel oldPannel = new Panel() { Width = 0, Height = 0, Location = new Point(0, 0) };
            Node t = b.getRoot();
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
                pic.ImageLocation = i.ImgSrc;
                pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pic.Padding = new Padding(10);

                Label lbTG = new Label()
                {
                    Width = 300,
                    Height = 50,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Margin = new Padding(100, 0, 0, 0)
                };
                lbTG.Text = ("Mã sách: " + i.MaSach + "--" + i.TenSach).ToString();
                lbTG.Font = new Font("Arial", 10, FontStyle.Bold);
                lbTG.Location = new Point(10, pic.Height + 5);
                //lbTG.AutoSize = true;
                lbTG.Padding = new Padding(10, 0, 0, 0);

                // gán id cho từng pannel
                Label id = new Label();
                id.Text = i.MaSach;
                id.Hide();

                // add pannel con vào pannel cha
                curPan.BorderStyle = BorderStyle.FixedSingle;
                curPan.Controls.Add(id);
                curPan.Controls.Add(pic);
                curPan.Controls.Add(lbTG);
                PannelDisplayForm1.Controls.Add(curPan);
                // add event cho từng thuộc tính pannel con
                curPan.Click += showForm;
                pic.Click += showForm;
                lbTG.Click += showForm;
                oldPannel = curPan;
                t = t.Next;
            }
        }
        private void showList(ListBook b)
        {
            PannelDisplayForm1.Controls.Clear();
            PannelDisplayForm1.Controls.Add(listShow);
            listShow.Controls.Clear();
            listShow.Columns.Clear();
            listShow.Items.Clear();
            listShow.MouseDoubleClick -= test;

            listShow.View = View.Details;
            listShow.Font = new Font("Arial", 15);

            listShow.Columns.Add("Mã sách").Width = 150;
            listShow.Columns.Add("Tên sách").Width = 400;
            listShow.Columns.Add("Tác giả").Width = 243;
            listShow.Columns.Add("Chủ đề").Width = 200;
            listShow.Columns.Add("NXB").Width = 200;
            listShow.Columns.Add("Vị trí").Width = 90;
            listShow.Columns.Add("Ngày phát hành").Width = 200;
            listShow.Columns.Add("Giá").Width = 200;
            listShow.Columns[0].TextAlign = HorizontalAlignment.Center;
            listShow.Columns[6].TextAlign = HorizontalAlignment.Center;
            listShow.Columns[7].TextAlign = HorizontalAlignment.Center;
            Node t = b.getRoot();
            listShow.MouseDoubleClick += test;
            while (t != null)
            {
                ListViewItem item = new ListViewItem();
                listShow.Items.Add(item);
                item.Text = t.Data.MaSach.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = t.Data.TenSach.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = t.Data.TacGia.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = t.Data.ChuDe.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = t.Data.NXB.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = t.Data.VT });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (t.Data.NgXB.ToShortDateString()) });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = t.Data.Price.ToString() + " VND" });
                t = t.Next;
            }
        }
        public void test(object sender, MouseEventArgs e)
        {
            // luu tru dia chi hien tai
            flag = false;
            for (int i = 0; i < listShow.Items.Count; i++)
            {
                var rectangle = listShow.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    slideID = listShow.Items[i].Text;
                    break;
                }
            }
            FormBook.choose = 1; // đổi cách hiển thị form book
            FormBook b = new FormBook();
            b.ShowDialog();
            showList(a);
        }

        public void showForm(object sender, EventArgs e)
        {
            // luu tru dia chi hien tai
            int x = PannelDisplayForm1.HorizontalScroll.Value;
            flag = false;
            Panel p;
            // lấy ra pannel gốc
            if (sender.GetType() == typeof(Panel))
            {
                p = sender as Panel;
            }
            else if (sender.GetType() == typeof(PictureBox))
            {
                p = (sender as PictureBox).Parent as Panel;
            }
            else
            {
                p = (sender as Label).Parent as Panel;
            }
            slideID = ""; // có tác dụng lưu pannel được chọn
            foreach (Panel i in PannelDisplayForm1.Controls)
            {
                if (i == p)
                {
                    slideID = i.Controls[0].Text;
                    break;
                }
            }
            FormBook.choose = 1; // đổi cách hiển thị form book
            FormBook b = new FormBook();
            b.ShowDialog();
            if (FormBook.choose == 0) // kiểm tra lựa chọn từ  form book
            {
                PannelDisplayForm1.Controls.Remove(p);
            }
            else if (FormBook.choose == 1)
            {
                p.Controls[1].Text = ("Mã sách: " + FormBook.curNode.Data.MaSach + "--" + FormBook.curNode.Data.TenSach).ToString();
            }
            // gán lại tọa độ thanh scroll bar
            PannelDisplayForm1.HorizontalScroll.Value = x;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (changeDisplay)
                displayTag(a);
            else
                showList(a);
        }
        private void CheckBoxChange_CheckedChanged(object sender, EventArgs e)
        {
            changeDisplay = !changeDisplay;
            if (!changeDisplay)
            {
                PannelDisplayForm1.Controls.Clear();
                PannelDisplayForm1.Controls.Add(listShow);
                showList(a);
                listShow.Show();
            }
            else
            {
                displayTag(a);
                listShow.Hide();
            }
        }
    }
}
