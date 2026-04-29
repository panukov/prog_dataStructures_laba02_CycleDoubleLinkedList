using System.DirectoryServices.ActiveDirectory;
using System.Xml.Linq;

namespace Laba2_CycleDoubleLinkedList
{
    public class DoubleNode
    {
        private int _id;
        private string _title;
        private string _author;
        private int _year;
        private double next;
        private double prev;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public DoubleNode Next { get; set; }
        public DoubleNode Prev { get; set; }

        public DoubleNode()
        {

        }

        public DoubleNode(int id, string title, string author, int year)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
        }

        public DoubleNode(int id, string title, string author, int year, DoubleNode next, DoubleNode prev)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;

            Next = next;
            Prev = prev;
        }
    }

    public class CycleDoubleLinkList
    {
        private DoubleNode head;
        public CycleDoubleLinkList()
        {
            head = new DoubleNode();
            head.Next = head;
            head.Prev = head;
        }
        public void FillDataGridView(DataGridView dgv)
        {
            dgv.Rows.Clear();

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("Position", "№ п/п");
                dgv.Columns.Add("Id", "Инв. номер");
                dgv.Columns.Add("Title", "Название");
                dgv.Columns.Add("Author", "Автор");
                dgv.Columns.Add("Year", "Год");
            }

            if (head.Next != head)
            {

                DoubleNode current = head.Next;
                int position = 1;

                while (current != head)
                {
                    dgv.Rows.Add(position, current.Id, current.Title, current.Author, current.Year);
                    current = current.Next;
                    position++;
                }
            }
        }

        public void AddToEnd(int id, string title, string author, int year)
        {
            DoubleNode newNode = new DoubleNode(id, title, author, year);

            newNode.Next = head;
            newNode.Prev = head.Prev;
            head.Prev.Next = newNode;
            head.Prev = newNode;
        }

        public void AddToStart(int id, string title, string author, int year)
        {
            DoubleNode newNode = new DoubleNode(id, title, author, year);

            newNode.Next = head.Next;
            newNode.Prev = head;
            head.Next.Prev = newNode;
            head.Next = newNode;
        }

        public void FindAll(string title, DataGridView datagridview)
        {

            if (head.Next == head) MessageBox.Show("Список пуст");
            else
            {
                datagridview.Rows.Clear();
                
                DoubleNode p = head.Next;
                int position = 1;
                while (p != head)
                {
                    if (p.Title == title)
                    {
                        datagridview.Rows.Add(position, p.Id, p.Title, p.Author, p.Year);
                    }
                    p = p.Next;
                }
                if (datagridview.Rows.Count == 0) MessageBox.Show("Книги не найдены");
                else datagridview.Visible = true;
            }
        }
        public void InsertInAny(int id, string title, string author, int year, int n)
        {
            DoubleNode newNode = new DoubleNode(id, title, author, year);
            if (n == 1)
            {
                newNode.Next = head.Next;
                newNode.Prev = head;
                head.Next.Prev = newNode;
                head.Next = newNode;
            }
            else
            {
                DoubleNode current = head.Next;
                int currentIndex = 1;

                while (current != head && currentIndex < n - 1)
                {
                    current = current.Next;
                    currentIndex++;
                }

                if (current == head)
                {
                    MessageBox.Show("Индекс выходит за пределы списка!");
                }

                else
                {
                    newNode.Next = current.Next;
                    newNode.Prev = current;
                    current.Next.Prev = newNode;
                    current.Next = newNode;
                }
            }

        }

        public void DeleteFirst()
        {
            if (head.Next == head) MessageBox.Show("Голову списка удалить нельзя!");

            else
            {
                head.Next = head.Next.Next;
                head.Next.Prev = head;
            }
        }

        public void DeleteLast()
        {
            if (head.Prev == head) MessageBox.Show("Голову списка удалить нельзя!");

            else
            {
                head.Prev = head.Prev.Prev;
                head.Prev.Next = head;
            }
        }

        public void DeleteAt(int n)
        {
            if (head.Next == head)
            {
                MessageBox.Show("Список пуст!");
            }
            else
            {
                DoubleNode toDelete = head.Next;
                int currentIndex = 1;

                while (toDelete != head && currentIndex < n)
                {
                    toDelete = toDelete.Next;
                    currentIndex++;
                }

                if (toDelete == head || currentIndex != n)
                {
                    MessageBox.Show("Индекс выходит за пределы списка!");
                }
                else
                {
                    toDelete.Prev.Next = toDelete.Next;
                    toDelete.Next.Prev = toDelete.Prev;
                }
            }
        }

        public void DeleteByYear(int year)
        {
            if (head.Next == head) MessageBox.Show("Список пуст!");
            else
            {
                DoubleNode p = head.Next;
                while (p != head)
                {
                    DoubleNode next = p.Next;

                    if (p.Year < year)
                    {
                        p.Prev.Next = p.Next;
                        p.Next.Prev = p.Prev;
                    }
                    p = next;
                }
            }
        }
        public void DestroyList()
        {
            head = null;
        }
    }
}
