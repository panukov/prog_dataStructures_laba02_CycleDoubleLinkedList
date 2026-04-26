namespace Laba_2_CycleDoubleLinkedList2
{
    partial class AddToAny
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AddToAnyBtn = new Button();
            releaseDate = new TextBox();
            author = new TextBox();
            title = new TextBox();
            inventoryNum = new TextBox();
            nodeNum = new TextBox();
            label6 = new Label();
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
            dataGridView1.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 30;
            label5.Text = "Год выпуска";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 29;
            label4.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 28;
            label3.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 27;
            label2.Text = "Инвентарный номер";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 26;
            label1.Text = "Введите значения узла";
            // 
            // AddToAnyBtn
            // 
            AddToAnyBtn.Location = new Point(444, 125);
            AddToAnyBtn.Name = "AddToAnyBtn";
            AddToAnyBtn.Size = new Size(261, 29);
            AddToAnyBtn.TabIndex = 25;
            AddToAnyBtn.Text = "Добавить в произвольную";
            AddToAnyBtn.UseVisualStyleBackColor = true;
            AddToAnyBtn.Click += AddToAnyBtn_Click;
            // 
            // releaseDate
            // 
            releaseDate.Location = new Point(188, 181);
            releaseDate.Name = "releaseDate";
            releaseDate.Size = new Size(125, 27);
            releaseDate.TabIndex = 24;
            // 
            // author
            // 
            author.Location = new Point(188, 143);
            author.Name = "author";
            author.Size = new Size(125, 27);
            author.TabIndex = 23;
            // 
            // title
            // 
            title.Location = new Point(188, 110);
            title.Name = "title";
            title.Size = new Size(125, 27);
            title.TabIndex = 22;
            // 
            // inventoryNum
            // 
            inventoryNum.Location = new Point(188, 75);
            inventoryNum.Name = "inventoryNum";
            inventoryNum.Size = new Size(125, 27);
            inventoryNum.TabIndex = 21;
            // 
            // nodeNum
            // 
            nodeNum.Location = new Point(188, 42);
            nodeNum.Name = "nodeNum";
            nodeNum.Size = new Size(125, 27);
            nodeNum.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 45);
            label6.Name = "label6";
            label6.Size = new Size(172, 20);
            label6.TabIndex = 33;
            label6.Text = "В какой узел добавить?";
            // 
            // AddToAny
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(nodeNum);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddToAnyBtn);
            Controls.Add(releaseDate);
            Controls.Add(author);
            Controls.Add(title);
            Controls.Add(inventoryNum);
            Name = "AddToAny";
            Text = "AddToAny";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button AddToAnyBtn;
        private TextBox releaseDate;
        private TextBox author;
        private TextBox title;
        private TextBox inventoryNum;
        private TextBox nodeNum;
        private Label label6;
    }
}