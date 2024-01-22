using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachLienKetDon
{
    class Node
    {
        private float info;
        private Node next;

        public Node(float x)
        {
            info = x;
            next = null;
        }
        public float Info
        {
            get { return info; }
            set { info = value; }
        }
        public Node Next
        {
            get { return next; }
            set { next = value; }

        }
    }
    class SingleLinkList
    {
        private Node Head;
        public SingleLinkList()
        {
            Head = null;
        }
        public void AddHead(float x)
        {
            Node p = new Node(x);
            p.Next = Head;
            Head = p;
        }
        public void AddLast(float x)
        {
            Node p = new Node(x);
            if (Head == null)
                Head = p;
            else
            {
                Node q = Head;
                while (q.Next != null)
                    q = q.Next;
                q.Next=p;
            }
        }
        public void DeleteHead()
        {
            if (Head != null)
            {
                Node p = Head;
                Head = Head.Next;
                p.Next = null;
            }
        }
        public void DeleteLast()
        {
            if (Head != null)
            {
                Node p = Head;
                Node q = null;
                while (p.Next != null)
                {
                    q = p;
                    p = p.Next;
                }
                q.Next = null;
            }
        }
        //tim max
        public Node findMax()
        {
            Node max = Head;
            Node p = Head.Next;
            while (p != null)
            {
                if (p.Info > max.Info)
                    max = p;
                p = p.Next;
            }
            return max;
        }
        //tinh trung binh
        public float Avg()
        {
            float sum = 0;
            int count = 0;
            Node p = Head;
            while (p != null)
            {
                sum += p.Info;
                count++;
                p = p.Next;

            }
            return sum / count;
        }
        // xoa gia tri nut x
        public void DeleteNode(float x)
        {
            Node p = Head;
            Node q = null;
            while (p != null && p.Info != x)
            {
                q = p;
                p = p.Next;
            }
            if (p != null)
            {
                if (p == Head)
                    DeleteHead();
                else
                {
                    q.Next = p.Next;
                    p.Next = null;
                }
            }
        }
        public void ProcessList()
        {
            Node p = Head;
            while (p != null)
            {
                Console.Write($"{ p.Info }  ");
                p = p.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkList a = new SingleLinkList();
            NhapDanhSach(a);
            Console.WriteLine("Danh sach vua tao:");
            a.ProcessList();
            Console.WriteLine($"\nGia tri trung binh cua cac nut la:{a.Avg()}");
            Node max = a.findMax();
            Console.WriteLine($"\nNut co gia tri lon nhat:{max.Info}");
            Console.Write("Nhap gia tri can xoa:");
            float x = float.Parse(Console.ReadLine());
            a.DeleteNode(x);
            Console.WriteLine("\nDanh sach sau khi xoa:");
            a.ProcessList();
            Console.ReadLine();
        }
        static void NhapDanhSach(SingleLinkList l)
        {

            string chon = "y";
            int x;
            while (true)
            {
                Console.Write("Nhap gia tri nut:");
                x = int.Parse(Console.ReadLine());
                l.AddHead(x);
                Console.Write("Tiep tuc y/n:");
                chon = Console.ReadLine();
                if (chon == "n")
                    break;


            }
        }
    }
}
        
 