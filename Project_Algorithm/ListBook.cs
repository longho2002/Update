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
            ListBook temp = new ListBook() { };
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

        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        ///         COPPY TỪ ĐÂY TRỞ ĐI
        ///         Bool x vào mỗi hàm sort : TRUE là tăng dần, FALSE là giảm dần.
        ///         Tên tác giả so sánh tên , nếu tên trùng thì so sánh từ ký tự đầu tiên.
        ///         Còn các kiểu string còn lại so sánh từ ký tự đầu tiên
        ///         CÁC KIỂU SORT SỬ DỤNG:
        ///         - QuickSort (Mã sách)
        ///         - MergeSort (Tên sách)
        ///         - Sort thông thường (2 vòng lặp) (Tên tác giả, Vị trí, Ngày xuất bản)
        ///         - SelectionSort (Giá)
        ///         - InsertionSort (Chủ đề)
        ///         - BubbleSort (Nhà xuất bản)
        ///         

        protected Node sorted; //InsertionSort sử dụng
        public void MaSach_Sort(bool x)
        {
            // for loop thứ nhất
            for (Node pTmp = root; pTmp != null; pTmp = pTmp.Next)
            {
                //for loop thứ hai
                for (Node pTmp2 = pTmp.Next; pTmp2 != null; pTmp2 = pTmp2.Next)
                {
                    if (x != false) // sap xep tang dan
                    {
                        if (String.Compare(pTmp.Data.MaSach, pTmp2.Data.MaSach, true) > 0)
                        {
                            book tmp = pTmp.Data;
                            pTmp.Data = pTmp2.Data;
                            pTmp2.Data = tmp;
                        }
                    }
                    else // sap xep giam dan
                        if (String.Compare(pTmp.Data.MaSach, pTmp2.Data.MaSach, true) < 0)
                    {
                        book tmp = pTmp.Data;
                        pTmp.Data = pTmp2.Data;
                        pTmp2.Data = tmp;
                    }

                }
            }
        }
        public void TenSach_MergeSort(bool x)
        {
            root = mergeSort(root, x);
        }
        public void TenTacGia_Sort(bool x)
        {
            // for loop thứ nhất
            for (Node pTmp = root; pTmp != null; pTmp = pTmp.Next)
            {
                //for loop thứ hai
                for (Node pTmp2 = pTmp.Next; pTmp2 != null; pTmp2 = pTmp2.Next)
                {
                    string[] arrListStr1 = pTmp.Data.TacGia.Split(' ');
                    string[] arrListStr2 = pTmp2.Data.TacGia.Split(' ');
                    int l1 = arrListStr1.Length;
                    int l2 = arrListStr2.Length;
                    if (x != false) // sap xep tang dan
                    {
                        if (String.Compare(arrListStr1[l1 - 1], arrListStr2[l2 - 1], true) > 0) // so sanh ten
                        {
                            book tmp = pTmp.Data;
                            pTmp.Data = pTmp2.Data;
                            pTmp2.Data = tmp;
                        }
                        else if (String.Compare(arrListStr1[l1 - 1], arrListStr2[l2 - 1], true) == 0) // Neu ten giong nhau
                        {
                            if (String.Compare(pTmp.Data.TacGia, pTmp2.Data.TacGia, true) > 0) // sp sanh tu dau
                            {
                                book tmp = pTmp.Data;
                                pTmp.Data = pTmp2.Data;
                                pTmp2.Data = tmp;
                            }
                        }
                    }
                    else // sap xep giam dan
                    {
                        if (String.Compare(arrListStr1[l1 - 1], arrListStr2[l2 - 1], true) < 0) // so sanh ten
                        {
                            book tmp = pTmp.Data;
                            pTmp.Data = pTmp2.Data;
                            pTmp2.Data = tmp;
                        }
                        else if (String.Compare(arrListStr1[l1 - 1], arrListStr2[l2 - 1], true) == 0) // Neu ten giong nhau
                        {
                            if (String.Compare(pTmp.Data.TacGia, pTmp2.Data.TacGia, true) < 0) // so sanh tu dau
                            {
                                book tmp = pTmp.Data;
                                pTmp.Data = pTmp2.Data;
                                pTmp2.Data = tmp;
                            }
                        }
                    }
                }
            }
        }
        public void Gia_SelectionSort(bool x)
        {
            Node temp = root;

            while (temp != null)
            {
                Node min_max = temp;
                Node r = temp.Next;

                while (r != null)
                {
                    if (x != false) // tang dan
                    {
                        if (min_max.Data.Price > r.Data.Price)
                            min_max = r;
                    }
                    else  // giam dan
                    {
                        if (min_max.Data.Price < r.Data.Price)
                            min_max = r;
                    }

                    r = r.Next;
                }

                book a = temp.Data;
                temp.Data = min_max.Data;
                min_max.Data = a;
                temp = temp.Next;
            }
        }
        public void ViTri_Sort(bool x)
        {
            // for loop thứ nhất
            for (Node pTmp = root; pTmp != null; pTmp = pTmp.Next)
            {
                //for loop thứ hai
                for (Node pTmp2 = pTmp.Next; pTmp2 != null; pTmp2 = pTmp2.Next)
                {
                    if (x != false) // sap xep tang dan
                    {
                        if (String.Compare(pTmp.Data.VT, pTmp2.Data.VT, true) > 0)
                        {
                            book tmp = pTmp.Data;
                            pTmp.Data = pTmp2.Data;
                            pTmp2.Data = tmp;
                        }
                    }
                    else // sap xep giam dan
                        if (String.Compare(pTmp.Data.VT, pTmp2.Data.VT, true) < 0)
                    {
                        book tmp = pTmp.Data;
                        pTmp.Data = pTmp2.Data;
                        pTmp2.Data = tmp;
                    }

                }
            }
        }
        public void NgXB_Sort(bool x)
        {
            // for loop thứ nhất
            for (Node pTmp = root; pTmp != null; pTmp = pTmp.Next)
            {
                //for loop thứ hai
                for (Node pTmp2 = pTmp.Next; pTmp2 != null; pTmp2 = pTmp2.Next)
                {
                    if (x != false) // sap xep tang dan
                    {
                        if (DateTime.Compare(pTmp.Data.NgXB, pTmp2.Data.NgXB) > 0)
                        {
                            book tmp = pTmp.Data;
                            pTmp.Data = pTmp2.Data;
                            pTmp2.Data = tmp;
                        }
                    }
                    else
                        if (DateTime.Compare(pTmp.Data.NgXB, pTmp2.Data.NgXB) < 0)
                    {
                        book tmp = pTmp.Data;
                        pTmp.Data = pTmp2.Data;
                        pTmp2.Data = tmp;
                    }
                }
            }
        }
        public void ChuDe_InsertionSort(bool x)
        {
            root = insertionSortLinkedList(x);
        }
        public void NXB_BubbleSort(bool x)
        {

            Node current = null;

            int status = 0;
            do
            {
                current = root;
                status = 0;
                while (current != null && current.Next != null)
                {
                    if (x != false)
                    {
                        if (String.Compare(current.Data.NXB, current.Next.Data.NXB, true) > 0)
                        {
                            status = 1;
                            book tmp = current.Data;
                            current.Data = current.Next.Data;
                            current.Next.Data = tmp;
                        }
                    }
                    else
                    {
                        if (String.Compare(current.Data.NXB, current.Next.Data.NXB, true) < 0)
                        {
                            status = 1;
                            book tmp = current.Data;
                            current.Data = current.Next.Data;
                            current.Next.Data = tmp;
                        }
                    }
                    current = current.Next;
                }

            } while (status == 1);
        }

        ///////    Hàm phụ phục vụ cho các sort
        Node sortedMerge(Node a, Node b, bool x)
        {
            Node result = null;
            if (a == null)
                return b;
            if (b == null)
                return a;

            if (x != false)
            {
                if (String.Compare(a.Data.TenSach, b.Data.TenSach, true) <= 0)
                {
                    result = a;
                    result.Next = sortedMerge(a.Next, b, x);
                }
                else
                {
                    result = b;
                    result.Next = sortedMerge(a, b.Next, x);
                }
            }
            else
            {
                if (String.Compare(a.Data.TenSach, b.Data.TenSach, true) > 0)
                {
                    result = a;
                    result.Next = sortedMerge(a.Next, b, x);
                }
                else
                {
                    result = b;
                    result.Next = sortedMerge(a, b.Next, x);
                }
            }
            return result;
        }
        Node mergeSort(Node h, bool x)
        {
            Node sortedlist;
            if (h == null || h.Next == null)
            {
                return h;
            }
            Node middle = getMiddle(h);
            Node Nextofmiddle = middle.Next;
            middle.Next = null;

            Node left = mergeSort(h, x);
            Node right = mergeSort(Nextofmiddle, x);

            sortedlist = sortedMerge(left, right, x);

            return sortedlist;
        }
        Node getMiddle(Node h)
        {
            if (h == null)
                return h;
            Node fastptr = h.Next;
            Node slowptr = h;

            while (fastptr != null)
            {
                fastptr = fastptr.Next;
                if (fastptr != null)
                {
                    slowptr = slowptr.Next;
                    fastptr = fastptr.Next;
                }
            }
            return slowptr;
        }
        Node paritionLast(Node start, Node end, bool x)
        {
            if (start == end || start == null || end == null)
                return start;

            Node pivot_prev = start;
            Node curr = start;
            book pivot = end.Data;
            book temp;
            while (start != end)
            {
                if (x != false)
                {
                    if (String.Compare(start.Data.MaSach, pivot.MaSach, true) < 0)
                    {
                        pivot_prev = curr;
                        temp = curr.Data;
                        curr.Data = start.Data;
                        start.Data = temp;
                        curr = curr.Next;
                    }
                }
                else
                {
                    if (String.Compare(start.Data.MaSach, pivot.MaSach, true) > 0)
                    {
                        pivot_prev = curr;
                        temp = curr.Data;
                        curr.Data = start.Data;
                        start.Data = temp;
                        curr = curr.Next;
                    }
                }
                start = start.Next;
            }
            temp = curr.Data;
            curr.Data = pivot;
            end.Data = temp;
            return pivot_prev;
        }
        void sort(Node start, Node end, bool x)
        {
            if (start == end)
                return;
            Node pivot_prev = paritionLast(start, end, x);
            sort(start, pivot_prev, x);

            if (pivot_prev != null && pivot_prev == start)
                sort(pivot_prev.Next, end, x);

            else if (pivot_prev != null
                     && pivot_prev.Next != null)
                sort(pivot_prev.Next.Next, end, x);
        }
        Node insertionSortLinkedList(bool x)
        {
            Node curr = root;
            Node sorted_head = null;
            while (curr != null)
            {
                Node currNext = curr.Next; ;
                sorted_head = sortedInsert(sorted_head, curr, x);
                curr = currNext;
            }
            return sorted_head;
        }
        Node sortedInsert(Node sorted_head, Node new_node, bool x)
        {
            // Insertion at first position
            if (x != false)
            {
                if (sorted_head == null || String.Compare(sorted_head.Data.ChuDe, new_node.Data.ChuDe, true) >= 0)
                {
                    new_node.Next = sorted_head;
                    return new_node;
                }
                else
                {
                    Node curr = sorted_head;
                    while (curr.Next != null && String.Compare(curr.Next.Data.ChuDe, new_node.Data.ChuDe, true) < 0)
                        curr = curr.Next;
                    new_node.Next = curr.Next;
                    curr.Next = new_node;
                }
            }
            else
            {
                if (sorted_head == null || String.Compare(sorted_head.Data.ChuDe, new_node.Data.ChuDe, true) <= 0)
                {
                    new_node.Next = sorted_head;
                    return new_node;
                }
                else
                {
                    Node curr = sorted_head;
                    while (curr.Next != null && String.Compare(curr.Next.Data.ChuDe, new_node.Data.ChuDe, true) < 0)
                        curr = curr.Next;
                    new_node.Next = curr.Next;
                    curr.Next = new_node;
                }
            }
            return sorted_head;
        }
    }
}
