namespace Laba_2_CycleDoubleLinkedList2
{
    partial class FindByName
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
            FindBtn = new Button();
            titleBox = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // FindBtn
            // 
            FindBtn.Location = new Point(32, 111);
            FindBtn.Name = "FindBtn";
            FindBtn.Size = new Size(94, 29);
            FindBtn.TabIndex = 11;
            FindBtn.Text = "Поиск";
            FindBtn.UseVisualStyleBackColor = true;
            FindBtn.Click += FindBtn_Click;
            // 
            // titleBox
            // 
            titleBox.Location = new Point(32, 59);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(125, 27);
            titleBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 7);
            label1.Name = "label1";
            label1.Size = new Size(216, 20);
            label1.TabIndex = 9;
            label1.Text = "Введите название для поиска";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(394, 188);
            dataGridView1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(421, 262);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(378, 188);
            dataGridView2.TabIndex = 12;
            // 
            // FindByName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(FindBtn);
            Controls.Add(titleBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FindByName";
            Text = "FindByName";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FindBtn;
        private TextBox titleBox;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}