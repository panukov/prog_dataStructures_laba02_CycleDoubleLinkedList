
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laba_2_CycleDoubleLinkedList2
{
    public partial class CreatingForm : Form
    {

        CycleDoubleLinkList _list;

        public CycleDoubleLinkList NewList { get { return _list; } }
        public CreatingForm()
        {
            InitializeComponent();
        }

        private void SetupDataGridView()
        {
            dataGridView1.Visible = true;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Position", "№ п/п");
            dataGridView1.Columns.Add("Id", "Инв. номер");
            dataGridView1.Columns.Add("Title", "Название");
            dataGridView1.Columns.Add("Author", "Автор");
            dataGridView1.Columns.Add("Year", "Год");

            dataGridView1.Columns["Position"].Width = 50;
            dataGridView1.Columns["Id"].Width = 100;
            dataGridView1.Columns["Title"].Width = 200;
            dataGridView1.Columns["Author"].Width = 150;
            dataGridView1.Columns["Year"].Width = 80;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void createListBtn_Click(object sender, EventArgs e)
        {
            _list = new CycleDoubleLinkList();
            SetupDataGridView();

        }

    }
}
