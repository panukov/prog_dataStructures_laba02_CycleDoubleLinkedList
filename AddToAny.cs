
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_2_CycleDoubleLinkedList2
{
    public partial class AddToAny : Form
    {
        CycleDoubleLinkList _list;
        public AddToAny(CycleDoubleLinkList l)
        {
            InitializeComponent();
            _list = l;
            _list.FillDataGridView(dataGridView1);
        }

        private void AddToAnyBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(releaseDate.Text, out int n) &&
                int.TryParse(inventoryNum.Text, out int j) &&
                int.TryParse(nodeNum.Text, out int nodeNumber) && 
                nodeNumber > 0)
            {
                _list.InsertInAny(j, title.Text, author.Text, n, nodeNumber);
                _list.FillDataGridView(dataGridView1);

                title.Clear();
                author.Clear();
                inventoryNum.Clear();
                releaseDate.Clear();
                nodeNum.Clear();
            }
            else
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
    }
}
