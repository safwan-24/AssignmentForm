namespace AssignmentForm
{
    partial class Form1
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
            AddBtn = new Button();
            ClearBtn = new Button();
            EditBtn = new Button();
            ResetBtn = new Button();
            label1 = new Label();
            StudentDGV = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)StudentDGV).BeginInit();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DarkOrange;
            AddBtn.ForeColor = Color.Black;
            AddBtn.Location = new Point(79, 166);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 29);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.Chocolate;
            ClearBtn.Location = new Point(244, 166);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(94, 29);
            ClearBtn.TabIndex = 1;
            ClearBtn.Text = "Delete";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Orange;
            EditBtn.Location = new Point(617, 166);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(94, 29);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Peru;
            ResetBtn.Location = new Point(445, 166);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(94, 29);
            ResetBtn.TabIndex = 3;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(768, 6);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 4;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // StudentDGV
            // 
            StudentDGV.BackgroundColor = Color.White;
            StudentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDGV.Location = new Point(79, 211);
            StudentDGV.Name = "StudentDGV";
            StudentDGV.RowHeadersWidth = 51;
            StudentDGV.Size = new Size(632, 260);
            StudentDGV.TabIndex = 5;
            StudentDGV.CellClick += StudentDGV_CellContentClick;
            StudentDGV.CellContentClick += StudentDGV_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(244, 30);
            label2.Name = "label2";
            label2.Size = new Size(295, 35);
            label2.TabIndex = 6;
            label2.Text = "Student Showcase";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 89);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 89);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 9;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(607, 89);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 10;
            label6.Text = "Phone No.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(322, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(586, 112);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 500);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(StudentDGV);
            Controls.Add(label1);
            Controls.Add(ResetBtn);
            Controls.Add(EditBtn);
            Controls.Add(ClearBtn);
            Controls.Add(AddBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)StudentDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private Button ClearBtn;
        private Button EditBtn;
        private Button ResetBtn;
        private Label label1;
        private DataGridView StudentDGV;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
