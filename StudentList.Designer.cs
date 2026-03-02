namespace WinFormsApp19
{
    partial class StudentList
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox3 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button1.Location = new Point(718, 305);
            button1.Name = "button1";
            button1.Size = new Size(236, 34);
            button1.TabIndex = 23;
            button1.Text = "SAVE RECORD";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9.75F);
            textBox4.Location = new Point(716, 187);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(238, 25);
            textBox4.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.75F);
            textBox2.Location = new Point(718, 276);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 25);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F);
            textBox1.Location = new Point(716, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 25);
            textBox1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(667, 280);
            label6.Name = "label6";
            label6.Size = new Size(36, 17);
            label6.TabIndex = 17;
            label6.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(646, 222);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 16;
            label5.Text = "Course:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(646, 251);
            label4.Name = "label4";
            label4.Size = new Size(57, 17);
            label4.TabIndex = 15;
            label4.Text = "Section:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(626, 193);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 14;
            label3.Text = "Last Name:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(624, 164);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 13;
            label2.Text = "First Name:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(640, 93);
            label1.Name = "label1";
            label1.Size = new Size(314, 25);
            label1.TabIndex = 12;
            label1.Text = "UPDATE STUDENT INFORMATION";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.Location = new Point(718, 345);
            button2.Name = "button2";
            button2.Size = new Size(236, 34);
            button2.TabIndex = 24;
            button2.Text = "DELETE RECORD";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 9.75F);
            textBox6.Location = new Point(714, 129);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(238, 25);
            textBox6.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.Location = new Point(677, 135);
            label7.Name = "label7";
            label7.Size = new Size(26, 17);
            label7.TabIndex = 26;
            label7.Text = "ID:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(718, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 25);
            comboBox1.TabIndex = 27;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 9.75F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(718, 245);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(236, 25);
            comboBox2.TabIndex = 28;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 23);
            textBox3.TabIndex = 30;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(226, 115);
            button3.Name = "button3";
            button3.Size = new Size(116, 33);
            button3.TabIndex = 31;
            button3.Text = "SEARCH";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Location = new Point(461, 85);
            button4.Name = "button4";
            button4.Size = new Size(116, 33);
            button4.TabIndex = 32;
            button4.Text = "REFRESH";
            button4.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 85);
            label8.Name = "label8";
            label8.Size = new Size(181, 21);
            label8.TabIndex = 33;
            label8.Text = "STUDENT MASTERLIST";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(565, 397);
            dataGridView1.TabIndex = 34;
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 567);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentList";
            Text = "StudentList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private TextBox textBox6;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox3;
        private Button button3;
        private Button button4;
        private Label label8;
        private DataGridView dataGridView1;
    }
}