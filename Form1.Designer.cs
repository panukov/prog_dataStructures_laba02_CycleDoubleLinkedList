namespace Laba_2_CycleDoubleLinkedList2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            TaskBtn = new ToolStripMenuItem();
            созданиеToolStripMenuItem = new ToolStripMenuItem();
            редактированиеСпискаToolStripMenuItem = new ToolStripMenuItem();
            добавлениеToolStripMenuItem = new ToolStripMenuItem();
            вНачалоToolStripMenuItem = new ToolStripMenuItem();
            вКонецToolStripMenuItem = new ToolStripMenuItem();
            вПроизвольнуюToolStripMenuItem = new ToolStripMenuItem();
            удалениеЭлементаToolStripMenuItem = new ToolStripMenuItem();
            вНачалеToolStripMenuItem = new ToolStripMenuItem();
            вКонцеToolStripMenuItem = new ToolStripMenuItem();
            вПроизвольномToolStripMenuItem = new ToolStripMenuItem();
            обработкаСпискаToolStripMenuItem = new ToolStripMenuItem();
            списатьВсеКнигиИзданныеРанееЗаданногоГодаToolStripMenuItem = new ToolStripMenuItem();
            поискКнигиПоНазваниюToolStripMenuItem = new ToolStripMenuItem();
            выводИнформацииОВсехКнигахToolStripMenuItem = new ToolStripMenuItem();
            разрушениеToolStripMenuItem = new ToolStripMenuItem();
            AboutProgramBtn = new ToolStripMenuItem();
            ExitBtn = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TaskBtn, AboutProgramBtn, ExitBtn });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TaskBtn
            // 
            TaskBtn.DropDownItems.AddRange(new ToolStripItem[] { созданиеToolStripMenuItem, редактированиеСпискаToolStripMenuItem, обработкаСпискаToolStripMenuItem, разрушениеToolStripMenuItem });
            TaskBtn.Name = "TaskBtn";
            TaskBtn.Size = new Size(81, 24);
            TaskBtn.Text = "Задание";
            // 
            // созданиеToolStripMenuItem
            // 
            созданиеToolStripMenuItem.Name = "созданиеToolStripMenuItem";
            созданиеToolStripMenuItem.Size = new Size(257, 26);
            созданиеToolStripMenuItem.Text = "Создание списка";
            созданиеToolStripMenuItem.Click += созданиеToolStripMenuItem_Click;
            // 
            // редактированиеСпискаToolStripMenuItem
            // 
            редактированиеСпискаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавлениеToolStripMenuItem, удалениеЭлементаToolStripMenuItem });
            редактированиеСпискаToolStripMenuItem.Name = "редактированиеСпискаToolStripMenuItem";
            редактированиеСпискаToolStripMenuItem.Size = new Size(257, 26);
            редактированиеСпискаToolStripMenuItem.Text = "Редактирование списка";
            // 
            // добавлениеToolStripMenuItem
            // 
            добавлениеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вНачалоToolStripMenuItem, вКонецToolStripMenuItem, вПроизвольнуюToolStripMenuItem });
            добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
            добавлениеToolStripMenuItem.Size = new Size(247, 26);
            добавлениеToolStripMenuItem.Text = "Добавление элемента";
            // 
            // вНачалоToolStripMenuItem
            // 
            вНачалоToolStripMenuItem.Name = "вНачалоToolStripMenuItem";
            вНачалоToolStripMenuItem.Size = new Size(209, 26);
            вНачалоToolStripMenuItem.Text = "В начало";
            вНачалоToolStripMenuItem.Click += вНачалоToolStripMenuItem_Click;
            // 
            // вКонецToolStripMenuItem
            // 
            вКонецToolStripMenuItem.Name = "вКонецToolStripMenuItem";
            вКонецToolStripMenuItem.Size = new Size(209, 26);
            вКонецToolStripMenuItem.Text = "В конец";
            вКонецToolStripMenuItem.Click += вКонецToolStripMenuItem_Click;
            // 
            // вПроизвольнуюToolStripMenuItem
            // 
            вПроизвольнуюToolStripMenuItem.Name = "вПроизвольнуюToolStripMenuItem";
            вПроизвольнуюToolStripMenuItem.Size = new Size(209, 26);
            вПроизвольнуюToolStripMenuItem.Text = "В произвольную";
            вПроизвольнуюToolStripMenuItem.Click += вПроизвольнуюToolStripMenuItem_Click;
            // 
            // удалениеЭлементаToolStripMenuItem
            // 
            удалениеЭлементаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вНачалеToolStripMenuItem, вКонцеToolStripMenuItem, вПроизвольномToolStripMenuItem });
            удалениеЭлементаToolStripMenuItem.Name = "удалениеЭлементаToolStripMenuItem";
            удалениеЭлементаToolStripMenuItem.Size = new Size(247, 26);
            удалениеЭлементаToolStripMenuItem.Text = "Удаление элемента";
            // 
            // вНачалеToolStripMenuItem
            // 
            вНачалеToolStripMenuItem.Name = "вНачалеToolStripMenuItem";
            вНачалеToolStripMenuItem.Size = new Size(210, 26);
            вНачалеToolStripMenuItem.Text = "В начале";
            вНачалеToolStripMenuItem.Click += вНачалеToolStripMenuItem_Click;
            // 
            // вКонцеToolStripMenuItem
            // 
            вКонцеToolStripMenuItem.Name = "вКонцеToolStripMenuItem";
            вКонцеToolStripMenuItem.Size = new Size(210, 26);
            вКонцеToolStripMenuItem.Text = "В конце";
            вКонцеToolStripMenuItem.Click += вКонцеToolStripMenuItem_Click;
            // 
            // вПроизвольномToolStripMenuItem
            // 
            вПроизвольномToolStripMenuItem.Name = "вПроизвольномToolStripMenuItem";
            вПроизвольномToolStripMenuItem.Size = new Size(210, 26);
            вПроизвольномToolStripMenuItem.Text = "В произвольном";
            вПроизвольномToolStripMenuItem.Click += вПроизвольномToolStripMenuItem_Click;
            // 
            // обработкаСпискаToolStripMenuItem
            // 
            обработкаСпискаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { списатьВсеКнигиИзданныеРанееЗаданногоГодаToolStripMenuItem, поискКнигиПоНазваниюToolStripMenuItem, выводИнформацииОВсехКнигахToolStripMenuItem });
            обработкаСпискаToolStripMenuItem.Name = "обработкаСпискаToolStripMenuItem";
            обработкаСпискаToolStripMenuItem.Size = new Size(257, 26);
            обработкаСпискаToolStripMenuItem.Text = "Обработка списка";
            // 
            // списатьВсеКнигиИзданныеРанееЗаданногоГодаToolStripMenuItem
            // 
            списатьВсеКнигиИзданныеРанееЗаданногоГодаToolStripMenuItem.Name = "списатьВсеКнигиИзданныеРанееЗаданногоГодаToolStripMenuItem";
            списатьВсеКнигиИзданныеРанееЗаданногоГодаToolStripMenuItem.Size = new Size(451, 26);
            списатьВсеКнигиИзданныеРанееЗаданногоГодаToolStripMenuItem.Text = "списать все книги, изданные ранее заданного года";
            списатьВсеКнигиИзданныеРанееЗаданногоГодаToolStripMenuItem.Click += списатьВсеКнигиИзданныеРанееЗаданногоГодаToolStripMenuItem_Click;
            // 
            // поискКнигиПоНазваниюToolStripMenuItem
            // 
            поискКнигиПоНазваниюToolStripMenuItem.Name = "поискКнигиПоНазваниюToolStripMenuItem";
            поискКнигиПоНазваниюToolStripMenuItem.Size = new Size(451, 26);
            поискКнигиПоНазваниюToolStripMenuItem.Text = "поиск книги по названию";
            поискКнигиПоНазваниюToolStripMenuItem.Click += поискКнигиПоНазваниюToolStripMenuItem_Click;
            // 
            // выводИнформацииОВсехКнигахToolStripMenuItem
            // 
            выводИнформацииОВсехКнигахToolStripMenuItem.Name = "выводИнформацииОВсехКнигахToolStripMenuItem";
            выводИнформацииОВсехКнигахToolStripMenuItem.Size = new Size(451, 26);
            выводИнформацииОВсехКнигахToolStripMenuItem.Text = "вывод информации о всех книгах";
            выводИнформацииОВсехКнигахToolStripMenuItem.Click += выводИнформацииОВсехКнигахToolStripMenuItem_Click;
            // 
            // разрушениеToolStripMenuItem
            // 
            разрушениеToolStripMenuItem.Name = "разрушениеToolStripMenuItem";
            разрушениеToolStripMenuItem.Size = new Size(257, 26);
            разрушениеToolStripMenuItem.Text = "Разрушение";
            разрушениеToolStripMenuItem.Click += разрушениеToolStripMenuItem_Click;
            // 
            // AboutProgramBtn
            // 
            AboutProgramBtn.Name = "AboutProgramBtn";
            AboutProgramBtn.Size = new Size(118, 24);
            AboutProgramBtn.Text = "О программе";
            AboutProgramBtn.Click += AboutProgramBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(67, 24);
            ExitBtn.Text = "Выход";
            ExitBtn.Click += ExitBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Лабораторная работа №2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TaskBtn;
        private ToolStripMenuItem AboutProgramBtn;
        private ToolStripMenuItem ExitBtn;
        private ToolStripMenuItem созданиеToolStripMenuItem;
        private ToolStripMenuItem редактированиеСпискаToolStripMenuItem;
        private ToolStripMenuItem добавлениеToolStripMenuItem;
        private ToolStripMenuItem вНачалоToolStripMenuItem;
        private ToolStripMenuItem вКонецToolStripMenuItem;
        private ToolStripMenuItem вПроизвольнуюToolStripMenuItem;
        private ToolStripMenuItem удалениеЭлементаToolStripMenuItem;
        private ToolStripMenuItem вНачалеToolStripMenuItem;
        private ToolStripMenuItem вКонцеToolStripMenuItem;
        private ToolStripMenuItem вПроизвольномToolStripMenuItem;
        private ToolStripMenuItem обработкаСпискаToolStripMenuItem;
        private ToolStripMenuItem разрушениеToolStripMenuItem;
        private ToolStripMenuItem списатьВсеКнигиИзданныеРанееЗаданногоГодаToolStripMenuItem;
        private ToolStripMenuItem поискКнигиПоНазваниюToolStripMenuItem;
        private ToolStripMenuItem выводИнформацииОВсехКнигахToolStripMenuItem;
    }
}
