
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_2_CycleDoubleLinkedList2
{
    public partial class PrintAll : Form
    {
        CycleDoubleLinkList _list;
        public PrintAll(CycleDoubleLinkList list)
        {
            InitializeComponent();
            _list = list;
            _list.FillDataGridView(dataGridView1);
        }
    }
}
