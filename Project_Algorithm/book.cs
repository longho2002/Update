using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Algorithm
{
    public class book
    {
        private string maSach; //MS01
        private string tenSach; //
        private string tacGia; // nguyen quoc trung
        private string chuDe; //
        private string nxb; // 
        private int price;
        private string vt; // vitri // A-1 split('-') tryParse
        private DateTime ngXB;
        private string imgSrc;

        public string MaSach
        {
            get { return this.maSach; }
            set { this.maSach = value; }
        }
        public string TenSach
        {
            get { return this.tenSach; }
            set { this.tenSach = value; }
        }
        public string TacGia
        {
            get { return this.tacGia; }
            set { this.tacGia = value; }
        }
        public string ChuDe
        {
            get { return this.chuDe; }
            set { this.chuDe = value; }
        }
        public string NXB
        {
            get { return this.nxb; }
            set { this.nxb = value; }
        }
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string VT
        {
            get { return this.vt; }
            set { this.vt = value; }
        }
        public DateTime NgXB
        {
            get { return this.ngXB; }
            set { this.ngXB = value; }
        }
        public string ImgSrc
        {
            get { return this.imgSrc; }
            set { this.imgSrc = value; }
        }

        public book()
        {

        }
        public book(string maSach, string tenSach, string TacGia, string ChuDe, string NXB, int price, string vt, DateTime NgXB, string imgSrc)
        {
            this.TenSach = tenSach;
            this.MaSach = maSach;
            this.TacGia = TacGia;
            this.ChuDe = ChuDe;
            this.NXB = NXB;
            this.Price = price;
            this.VT = vt;
            this.NgXB = NgXB;
            this.ImgSrc = imgSrc;
        }
    }
}
