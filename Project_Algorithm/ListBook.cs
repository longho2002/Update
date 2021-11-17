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
            book x;
            if (index < 1 || index > n)
                return;
            if (index == 0)
            {
                p = this.root;
                this.root = this.root.Next;
                x = p.Data;
                p = null;
            }
            else
            {
                p = this.root;
                for (int i = 0; i < index - 1; i++)
                {
                    q = p;
                    p = p.Next;
                }
                q.Next = p.Next;
                x = p.Data;
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

    }
}
