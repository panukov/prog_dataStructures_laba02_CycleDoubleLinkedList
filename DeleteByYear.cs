
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_2_CycleDoubleLinkedList2
{
    public partial class DeleteByYear : Form
    {
        CycleDoubleLinkList _list;
        CycleDoubleLinkList _secondList;
        public DeleteByYear(CycleDoubleLinkList list)
        {
            InitializeComponent();
            _list = list;
            _secondList = list;
            _secondList.FillDataGridView(dataGridView1);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(int.TryParse(yearBox.Text, out int n))
            {
                _list.DeleteByYear(n);
                dataGridView2.Visible = true;
                _list.FillDataGridView(dataGridView2);
            }
            else
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
    }
}
