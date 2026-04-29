using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_2_CycleDoubleLinkedList2
{
    public partial class FindByName : Form
    {
        CycleDoubleLinkList _list;
        public FindByName(CycleDoubleLinkList list)
        {
            InitializeComponent();
            _list = list;
            _list.FillDataGridView(dataGridView1);
            _list.FillDataGridView(dataGridView2);
            dataGridView2.Visible = false;
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
             _list.FindAll(titleBox.Text, dataGridView2);
        }
    }
}
