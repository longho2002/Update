using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Algorithm
{
    public struct book
    {
        public string maSach; //MS01
        public string tenSach; //
        public string TacGia; // nguyen quoc trung
        public string ChuDe; //
        public string NXB; // 
        public int price;
        public string vt; // vitri // A-1 split('-') tryParse
        public DateTime NgXB;
        public string imgSrc;
    }
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}



