
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_2_CycleDoubleLinkedList2
{
    public partial class DestroyList : Form
    {
        CycleDoubleLinkList _list;
        public DestroyList(CycleDoubleLinkList list)
        {
            InitializeComponent();
            _list = list;
            _list.FillDataGridView(dataGridView1);
        }

        private void destroyBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите уничтожить список?",
                "Подтверждение уничтожения",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _list.DestroyList();
                _list.FillDataGridView(dataGridView1);
            }
        }
    }
}
