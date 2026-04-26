namespace Laba_2_CycleDoubleLinkedList2
{
    partial class AddAtStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            inventoryNum = new TextBox();
            title = new TextBox();
            author = new TextBox();
            releaseDate = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            AddToStartBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 188);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 1;
            label1.Text = "Введите данные нового узла";
            // 
            // inventoryNum
            // 
            inventoryNum.Location = new Point(218, 53);
            inventoryNum.Name = "inventoryNum";
            inventoryNum.Size = new Size(125, 27);
            inventoryNum.TabIndex = 2;
            // 
            // title
            // 
            title.Location = new Point(218, 94);
            title.Name = "title";
            title.Size = new Size(125, 27);
            title.TabIndex = 3;
            // 
            // author
            // 
            author.Location = new Point(218, 137);
            author.Name = "author";
            author.Size = new Size(125, 27);
            author.TabIndex = 4;
            // 
            // releaseDate
            // 
            releaseDate.Location = new Point(218, 184);
            releaseDate.Name = "releaseDate";
            releaseDate.Size = new Size(125, 27);
            releaseDate.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 53);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 6;
            label2.Text = "Инвентарный номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 94);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 7;
            label3.Text = "Название";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 137);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 8;
            label4.Text = "Автор";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 184);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 9;
            label5.Text = "Год выпуска";
            // 
            // AddToStartBtn
            // 
            AddToStartBtn.Location = new Point(447, 115);
            AddToStartBtn.Name = "AddToStartBtn";
            AddToStartBtn.Size = new Size(177, 29);
            AddToStartBtn.TabIndex = 10;
            AddToStartBtn.Text = "Добавить в начало";
            AddToStartBtn.UseVisualStyleBackColor = true;
            AddToStartBtn.Click += AddToStartBtn_Click;
            // 
            // AddAtStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddToStartBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(releaseDate);
            Controls.Add(author);
            Controls.Add(title);
            Controls.Add(inventoryNum);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "AddAtStart";
            Text = "AddAtStart";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox inventoryNum;
        private TextBox title;
        private TextBox author;
        private TextBox releaseDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button AddToStartBtn;
    }
}