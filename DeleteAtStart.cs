
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_2_CycleDoubleLinkedList2
{
    public partial class DeleteAtStart : Form
    {
        CycleDoubleLinkList _list;
        public DeleteAtStart(CycleDoubleLinkList list)
        {
            InitializeComponent();
            _list = list;
            _list.FillDataGridView(dataGridView1);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            _list.DeleteFirst();
            _list.FillDataGridView(dataGridView1);
        }
    }
}
