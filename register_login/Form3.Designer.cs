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
            label1 = new Label();
            nameCell = new DataGridViewTextBoxColumn();
            passwordCell = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 28);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "ime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 153);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "sifra";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-3, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(804, 289);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(-3, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(681, 34);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 5;
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
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(editbtn);
            Controls.Add(deletebtn);
            Controls.Add(addbtn);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView tabela;
        private DataGridViewTextBoxColumn nameCell;
        private DataGridViewTextBoxColumn passwordCell;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private ListBox listBox1;
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
    }
}