namespace Laba_2_CycleDoubleLinkedList2
{
    partial class AddAtEnd
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
            inventoryNum = new TextBox();
            AddToEndBtn = new Button();
            releaseDate = new TextBox();
            author = new TextBox();
            title = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // inventoryNum
            // 
            inventoryNum.Location = new Point(188, 79);
            inventoryNum.Name = "inventoryNum";
            inventoryNum.Size = new Size(125, 27);
            inventoryNum.TabIndex = 3;
            // 
            // AddToEndBtn
            // 
            AddToEndBtn.Location = new Point(444, 129);
            AddToEndBtn.Name = "AddToEndBtn";
            AddToEndBtn.Size = new Size(177, 29);
            AddToEndBtn.TabIndex = 14;
            AddToEndBtn.Text = "Добавить в конец";
            AddToEndBtn.UseVisualStyleBackColor = true;
            AddToEndBtn.Click += AddToEndBtn_Click;
            // 
            // releaseDate
            // 
            releaseDate.Location = new Point(188, 185);
            releaseDate.Name = "releaseDate";
            releaseDate.Size = new Size(125, 27);
            releaseDate.TabIndex = 13;
            // 
            // author
            // 
            author.Location = new Point(188, 147);
            author.Name = "author";
            author.Size = new Size(125, 27);
            author.TabIndex = 12;
            // 
            // title
            // 
            title.Location = new Point(188, 114);
            title.Name = "title";
            title.Size = new Size(125, 27);
            title.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 15;
            label1.Text = "Введите значения узла";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 16;
            label2.Text = "Инвентарный номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 17;
            label3.Text = "Название";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 18;
            label4.Text = "Автор";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 192);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 19;
            label5.Text = "Год выпуска";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 188);
            dataGridView1.TabIndex = 20;
            // 
            // AddAtEnd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddToEndBtn);
            Controls.Add(releaseDate);
            Controls.Add(author);
            Controls.Add(title);
            Controls.Add(inventoryNum);
            Name = "AddAtEnd";
            Text = "AddAtEnd";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inventoryNum;
        private Button AddToEndBtn;
        private TextBox releaseDate;
        private TextBox author;
        private TextBox title;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
    }
}