using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachLienKetDon
{
    class Node
    {
        private int info;
        private Node next;

        public Node(int x)
        {
            info = x;
            next = null;
        }
        public int Info
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
        public void AddHead(int x)
        {
            Node p = new Node(x);
            p.Next = Head;
            Head = p;
        }
        public void AddLast(int x)
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
            a.AddHead(1);
            a.AddHead(3);
            a.AddHead(9);
            a.AddLast(5);
            a.AddHead(7);
            Console.WriteLine("Danh sach lien ket");
            a.ProcessList();

            a.DeleteHead();
            Console.WriteLine("\nDanh sach lien ket sau khi xoa dau");
            a.ProcessList();

            a.DeleteLast();
            Console.WriteLine("\nDanh  sach lien ket sau khi xoa cuoi");
            a.ProcessList();
            Console.ReadKey();
        }
        
    }
}
