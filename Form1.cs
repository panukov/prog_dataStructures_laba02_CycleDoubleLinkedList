

namespace Laba_2_CycleDoubleLinkedList2
{
    public partial class MainForm : Form
    {
        private CycleDoubleLinkList L = new CycleDoubleLinkList();
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите закрыть приложение?",
                "Подтверждение закрытия",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) Application.Exit();
        }

        private void AboutProgramBtn_Click(object sender, EventArgs e)
        {
            AboutProgram abprg = new AboutProgram();
            abprg.ShowDialog();
        }

        private void созданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatingForm crform = new CreatingForm();
            crform.ShowDialog();

            L = crform.NewList;
        }

        private void вНачалоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAtStart formAddStart = new AddAtStart(L);
            formAddStart.ShowDialog();
        }

        private void вКонецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAtEnd formAddEnd = new AddAtEnd(L);
            formAddEnd.ShowDialog();
        }

        private void вПроизвольнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToAny formAddAny = new AddToAny(L);
            formAddAny.ShowDialog();
        }

        private void вНачалеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAtStart delStart = new DeleteAtStart(L);
            delStart.ShowDialog();
        }

        private void вКонцеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAtEnd delEnd = new DeleteAtEnd(L);
            delEnd.ShowDialog();
        }

        private void вПроизвольномToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAtAny delAny = new DeleteAtAny(L);
            delAny.ShowDialog();
        }

        private void списатьВсеКнигиИзданныеРанееЗаданногоГодаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteByYear delByYear = new DeleteByYear(L);
            delByYear.ShowDialog();
        }

        private void поискКнигиПоНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindByName findByName = new FindByName(L);
            findByName.ShowDialog();
        }

        private void выводИнформацииОВсехКнигахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintAll print = new PrintAll(L);
            print.ShowDialog();
        }

        private void разрушениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DestroyList destroy = new DestroyList(L);
            destroy.ShowDialog();
        }
    }
}
