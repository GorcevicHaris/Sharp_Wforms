namespace register_login
{
    partial class Form3
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
            label1 = new Label();
            nameCell = new DataGridViewTextBoxColumn();
            passwordCell = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            addbtn = new Button();
            deletebtn = new Button();
            editbtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            LogoutBtn = new Button();
            GoToForm4 = new Button();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(700, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "ulogovali ste se";
            // 
            // nameCell
            // 
            nameCell.HeaderText = "Ime";
            nameCell.Name = "nameCell";
            // 
            // passwordCell
            // 
            passwordCell.HeaderText = "Sifra";
            passwordCell.Name = "passwordCell";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Location = new Point(-3, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1003, 278);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(469, 25);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(75, 23);
            addbtn.TabIndex = 6;
            addbtn.Text = "add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(550, 25);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(75, 23);
            deletebtn.TabIndex = 7;
            deletebtn.Text = "delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Location = new Point(469, 63);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 23);
            editbtn.TabIndex = 8;
            editbtn.TabStop = false;
            editbtn.Text = "edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(344, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(344, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 9);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 11;
            label4.Text = "ime";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 52);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 12;
            label5.Text = "sifra";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(344, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 103);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 14;
            label6.Text = "roomNum";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(592, 71);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 15;
            label7.Text = "label7";
            // 
            // LogoutBtn
            // 
            LogoutBtn.AllowDrop = true;
            LogoutBtn.BackColor = Color.Red;
            LogoutBtn.ForeColor = SystemColors.ControlLight;
            LogoutBtn.Location = new Point(12, 187);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(75, 23);
            LogoutBtn.TabIndex = 16;
            LogoutBtn.Text = "logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // GoToForm4
            // 
            GoToForm4.Location = new Point(0, 0);
            GoToForm4.Name = "GoToForm4";
            GoToForm4.Size = new Size(75, 23);
            GoToForm4.TabIndex = 17;
            GoToForm4.Text = "gotoform4";
            GoToForm4.UseVisualStyleBackColor = true;
            GoToForm4.Click += GoToForm4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(711, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 138);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(801, 169);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.TabStop = false;
            button1.Text = "Add Photo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 494);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(GoToForm4);
            Controls.Add(LogoutBtn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(editbtn);
            Controls.Add(deletebtn);
            Controls.Add(addbtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridViewTextBoxColumn nameCell;
        private DataGridViewTextBoxColumn passwordCell;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button addbtn;
        private Button deletebtn;
        private Button editbtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private Button LogoutBtn;
        private Button GoToForm4;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
    }
}