using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_2_CycleDoubleLinkedList2
{
    public partial class AddAtEnd : Form
    {
        CycleDoubleLinkList _list;
        public AddAtEnd(CycleDoubleLinkList l)
        {
            InitializeComponent();
            _list = l;
            _list.FillDataGridView(dataGridView1);
        }

        private void AddToEndBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(releaseDate.Text, out int n) &&
                int.TryParse(inventoryNum.Text, out int j))
            {
                _list.AddToEnd(j, title.Text, author.Text, n);
                _list.FillDataGridView(dataGridView1);

                title.Clear();
                author.Clear();
                inventoryNum.Clear();
                releaseDate.Clear();

            }
            else
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
    }
}
