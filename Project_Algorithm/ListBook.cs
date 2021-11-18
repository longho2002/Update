using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Algorithm
{

    public class ListBook
    {
        protected Node root = new Node();
        public ListBook()
        {
            this.root = null;
        }
        public ListBook(book t)
        {
            this.root.Data = t;
            this.root.Next = null;
        }
        public Node getRoot()
        {
            return this.root;
        }
        public void Push(book t) // them vao cuoi
        {
            Node tmp = new Node();
            tmp.Data = t;
            tmp.Next = null;
            if (this.root == null)
                this.root = tmp;
            else
            {
                Node q = this.root;
                while (q.Next != null)
                {
                    q = q.Next;
                }
                q.Next = tmp;
            }
        }
        public void PushBack(book t)
        {
            if (this.root != null)
                this.root.Data = t;
            else
            {
                Node tmp = new Node();
                tmp.Data = t;
                tmp.Next = this.root;
                this.root = tmp;
            }
        }
        public int Len()
        {
            int l = 0;
            Node t = this.root;
            while (t != null)
            {
                t = t.Next;
                l++;
            }

            return l;
        }
        public void Add(book t, int index)
        {
            int n = Len();
            Node p = this.root;
            Node tmp = new Node();
            tmp.Data = t;
            tmp.Next = null;
            if (index > n)
            {
                return;
            }
            else if (index == 0)
            {
                PushBack(t);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    p = p.Next;
                tmp.Next = p.Next;
                p.Next = tmp;
            }
        }
        public void Remove(int index)
        {
            int n = Len();
            Node p, q = null;
            if (index < 0 || index > n)
                return;
            if (index == 0)
            {
                p = this.root;
                this.root = this.root.Next;
                p = null;
            }
            else
            {
                p = this.root;
                q = p.Next;
                for (int i = 0; i < index; i++)
                {
                    q = p;
                    p = p.Next;
                }
                q.Next = p.Next;
                p = null;
            }
        }

        public void RemoveAll()
        {
            while (this.root != null)
            {
                Node p = this.root;
                this.root = this.root.Next;
                p = null;
            }
        }
        public book GetBook(int index)
        {
            Node q = this.root;
            book b = new book();
            if (index > Len() || index < 0)
                return b;
            for (int i = 0; i <= index; i++)
            {
                q = q.Next;
            }
            b = q.Data;
            return b;
        }
        public void Display()
        {
            Node p = this.root;
            int i = 1;
            while (p != null)
            {
                Console.WriteLine("Quyển sách thứ {0}", i++);
                Console.WriteLine("Mã sách: {0}", p.Data.MaSach);
                Console.WriteLine("Tên sách: {0}", p.Data.TenSach);
                Console.WriteLine("Tác giả: {0}", p.Data.TacGia);
                Console.WriteLine("Chủ đề {0}", p.Data.ChuDe);
                Console.WriteLine("Nhà xuất bản: {0}", p.Data.NXB);
                Console.WriteLine("Giá bán: {0}", p.Data.Price);
                Console.WriteLine("Vị trí: {0}", p.Data.VT);
                Console.WriteLine("Ngày xuất bản: " + p.Data.NgXB.Day + "/" + p.Data.NgXB.Month + "/"
                    + p.Data.NgXB.Year);
                p = p.Next;
            }
        }
        public void SortMaSach(int x)
        {
            // for loop thứ nhất
            for (Node pTmp = this.root; pTmp != null; pTmp = pTmp.Next)
            {
                //for loop thứ hai
                for (Node pTmp2 = pTmp.Next; pTmp2 != null; pTmp2 = pTmp2.Next)
                {
                    if (x == 0) // sap xep tang dan
                    {
                        if (String.Compare(pTmp.Data.MaSach, pTmp2.Data.MaSach, true) > 0)
                        {
                            book tmp = pTmp.Data;
                            pTmp.Data = pTmp2.Data;
                            pTmp2.Data = tmp;
                        }
                    }
                    else if (x == 1) // sap xep giam dan
                        if (String.Compare(pTmp.Data.MaSach, pTmp2.Data.MaSach, true) < 0)
                        {
                            book tmp = pTmp.Data;
                            pTmp.Data = pTmp2.Data;
                            pTmp2.Data = tmp;
                        }

                }
            }
        }
        public void SortTenSach(int x)
        {
            // for loop thứ nhất
            for (Node pTmp = this.root; pTmp != null; pTmp = pTmp.Next)
            {
                //for loop thứ hai
                for (Node pTmp2 = pTmp.Next; pTmp2 != null; pTmp2 = pTmp2.Next)
                {
                    if (x == 0) // sap xep tang dan
                    {
                        if (String.Compare(pTmp.Data.TenSach, pTmp2.Data.TenSach, true) > 0)
                        {
                            book tmp = pTmp.Data;
                            pTmp.Data = pTmp2.Data;
                            pTmp2.Data = tmp;
                        }
                    }
                    else if (x == 1) // sap xep giam dan
                        if (String.Compare(pTmp.Data.TenSach, pTmp2.Data.TenSach, true) < 0)
                        {
                            book tmp = pTmp.Data;
                            pTmp.Data = pTmp2.Data;
                            pTmp2.Data = tmp;
                        }

                }
            }
        }

        public ListBook findTenSach(string s)
        {
            string s1;
            string s2;
            Node p = this.root;
            ListBook temp = new ListBook();
            while (p != null)
            {
                s1 = p.Data.TenSach.ToUpper();
                s2 = s.ToUpper();
                if (s1.Contains(s2))
                    temp.Push(p.Data);
                p = p.Next;
            }
            return temp;
        }
        public ListBook findTacGia(string s)
        {
            string s1;
            string s2;
            Node p = this.root;
            ListBook temp = new ListBook();
            while (p != null)
            {
                s1 = p.Data.TacGia.ToUpper();
                s2 = s.ToUpper();
                if (s1.Contains(s2))
                    temp.Push(p.Data);
                p = p.Next;
            }
            return temp;
        }
        public ListBook findMaSach(string s)
        {
            string s1;
            string s2;
            Node p = this.root;
            ListBook temp = new ListBook();
            while (p != null)
            {
                s1 = p.Data.MaSach.ToUpper();
                s2 = s.ToUpper();
                if (s1.Contains(s2))
                    temp.Push(p.Data);
                p = p.Next;
            }
            return temp;
        }
        public ListBook findNXB(string s)
        {
            string s1;
            string s2;
            Node p = this.root;
            ListBook temp = new ListBook();
            while (p != null)
            {
                s1 = p.Data.NXB.ToUpper();
                s2 = s.ToUpper();
                if (s1.Contains(s2))
                    temp.Push(p.Data);
                p = p.Next;
            }
            return temp;
        }
        public ListBook findPrice(string s)
        {
            string s1;
            string s2;
            Node p = this.root;
            ListBook temp = new ListBook();
            while (p != null)
            {
                if (p.Data.Price.ToString().Contains(s))
                    temp.Push(p.Data);
                p = p.Next;
            }
            return temp;
        }
        public ListBook findCat(string s)
        {
            string s1;
            string s2;
            Node p = this.root;
            ListBook temp = new ListBook();
            while (p != null)
            {
                s1 = p.Data.ChuDe.ToUpper();
                s2 = s.ToUpper();
                if (s1.Contains(s2))
                    temp.Push(p.Data);
                p = p.Next;
            }
            return temp;
        }
        public ListBook findLocation(string s)
        {
            string s1;
            string s2;
            Node p = this.root;
            ListBook temp = new ListBook();
            while (p != null)
            {
                s1 = p.Data.VT.ToUpper();
                s2 = s.ToUpper();
                if (s1.Contains(s2))
                    temp.Push(p.Data);
                p = p.Next;
            }
            return temp;
        }
        public ListBook findDate(string s)
        {
            Node p = this.root;
            string year;
            ListBook temp = new ListBook();
            while (p != null)
            {
                year = p.Data.NgXB.Year.ToString();
                if (s.Contains(year))
                    temp.Push(p.Data);
                p = p.Next;
            }
            return temp;
        }
    }
}
