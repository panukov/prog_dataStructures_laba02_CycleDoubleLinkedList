
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_2_CycleDoubleLinkedList2
{
    public partial class DeleteAtAny : Form
    {
        CycleDoubleLinkList _list;
        public DeleteAtAny(CycleDoubleLinkList list)
        {
            InitializeComponent();
            _list = list;
            _list.FillDataGridView(dataGridView1);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(int.TryParse(nodeNum.Text, out int n))
            {
                _list.DeleteAt(n);
                _list.FillDataGridView(dataGridView1);

                nodeNum.Clear();
            }

            else
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
    }
}
