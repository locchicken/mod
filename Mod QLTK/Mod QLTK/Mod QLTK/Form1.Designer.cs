
namespace Mod_QLTK
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.cbsever = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkhide = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbto = new System.Windows.Forms.TextBox();
            this.tbgo = new System.Windows.Forms.TextBox();
            this.checkadd = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnloginAll = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgo = new System.Windows.Forms.TextBox();
            this.txtto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtwidth = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checklogin = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXoaMap = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Silver;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(504, 258);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tài khoản";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mật khẩu";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Máy chủ";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sức mạnh";
            this.columnHeader5.Width = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản";
            // 
            // txtuser
            // 
            this.txtuser.Enabled = false;
            this.txtuser.Location = new System.Drawing.Point(69, 5);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(185, 20);
            this.txtuser.TabIndex = 2;
            // 
            // cbsever
            // 
            this.cbsever.Enabled = false;
            this.cbsever.FormattingEnabled = true;
            this.cbsever.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbsever.Location = new System.Drawing.Point(69, 85);
            this.cbsever.Name = "cbsever";
            this.cbsever.Size = new System.Drawing.Size(63, 21);
            this.cbsever.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PassWord";
            // 
            // txtpass
            // 
            this.txtpass.Enabled = false;
            this.txtpass.Location = new System.Drawing.Point(69, 45);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(185, 20);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Máy chủ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkhide);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbto);
            this.panel1.Controls.Add(this.tbgo);
            this.panel1.Controls.Add(this.checkadd);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbsever);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Location = new System.Drawing.Point(516, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 152);
            this.panel1.TabIndex = 5;
            // 
            // checkhide
            // 
            this.checkhide.AutoSize = true;
            this.checkhide.Checked = true;
            this.checkhide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkhide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkhide.Location = new System.Drawing.Point(260, 45);
            this.checkhide.Name = "checkhide";
            this.checkhide.Size = new System.Drawing.Size(56, 20);
            this.checkhide.TabIndex = 9;
            this.checkhide.Text = "Hide";
            this.checkhide.UseVisualStyleBackColor = true;
            this.checkhide.CheckedChanged += new System.EventHandler(this.checkhide_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "=>";
            this.label4.Visible = false;
            // 
            // tbto
            // 
            this.tbto.Location = new System.Drawing.Point(188, 111);
            this.tbto.Margin = new System.Windows.Forms.Padding(2);
            this.tbto.Name = "tbto";
            this.tbto.Size = new System.Drawing.Size(37, 20);
            this.tbto.TabIndex = 7;
            this.tbto.Visible = false;
            // 
            // tbgo
            // 
            this.tbgo.Location = new System.Drawing.Point(102, 111);
            this.tbgo.Margin = new System.Windows.Forms.Padding(2);
            this.tbgo.Name = "tbgo";
            this.tbgo.Size = new System.Drawing.Size(37, 20);
            this.tbgo.TabIndex = 6;
            this.tbgo.Visible = false;
            // 
            // checkadd
            // 
            this.checkadd.AutoSize = true;
            this.checkadd.Location = new System.Drawing.Point(12, 112);
            this.checkadd.Margin = new System.Windows.Forms.Padding(2);
            this.checkadd.Name = "checkadd";
            this.checkadd.Size = new System.Drawing.Size(81, 17);
            this.checkadd.TabIndex = 5;
            this.checkadd.Text = "Add Sll Acc";
            this.checkadd.UseVisualStyleBackColor = true;
            this.checkadd.CheckedChanged += new System.EventHandler(this.checkadd_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btnloginAll);
            this.panel2.Controls.Add(this.btnlogin);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(516, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 100);
            this.panel2.TabIndex = 6;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(115, 72);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnloginAll
            // 
            this.btnloginAll.Location = new System.Drawing.Point(3, 72);
            this.btnloginAll.Name = "btnloginAll";
            this.btnloginAll.Size = new System.Drawing.Size(75, 23);
            this.btnloginAll.TabIndex = 4;
            this.btnloginAll.Text = "Login All";
            this.btnloginAll.UseVisualStyleBackColor = true;
            this.btnloginAll.Click += new System.EventHandler(this.btnloginAll_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(233, 42);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sắp Xếp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(3, 42);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Enabled = false;
            this.btnedit.Location = new System.Drawing.Point(233, 3);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 0;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Location = new System.Drawing.Point(115, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Lưu";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Login từ";
            // 
            // txtgo
            // 
            this.txtgo.Location = new System.Drawing.Point(79, 288);
            this.txtgo.Margin = new System.Windows.Forms.Padding(2);
            this.txtgo.Name = "txtgo";
            this.txtgo.Size = new System.Drawing.Size(37, 20);
            this.txtgo.TabIndex = 9;
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(150, 289);
            this.txtto.Margin = new System.Windows.Forms.Padding(2);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(37, 20);
            this.txtto.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "=>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(392, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "SETTING";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Size";
            // 
            // txtwidth
            // 
            this.txtwidth.Location = new System.Drawing.Point(79, 322);
            this.txtwidth.Name = "txtwidth";
            this.txtwidth.Size = new System.Drawing.Size(37, 20);
            this.txtwidth.TabIndex = 13;
            this.txtwidth.Text = "240";
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(150, 322);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(37, 20);
            this.txtheight.TabIndex = 14;
            this.txtheight.Text = "240";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(122, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "X";
            // 
            // checklogin
            // 
            this.checklogin.AutoSize = true;
            this.checklogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checklogin.Location = new System.Drawing.Point(236, 291);
            this.checklogin.Name = "checklogin";
            this.checklogin.Size = new System.Drawing.Size(90, 20);
            this.checklogin.TabIndex = 16;
            this.checklogin.Text = "Auto Login";
            this.checklogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnXoaMap
            // 
            this.btnXoaMap.AutoSize = true;
            this.btnXoaMap.Location = new System.Drawing.Point(236, 317);
            this.btnXoaMap.Name = "btnXoaMap";
            this.btnXoaMap.Size = new System.Drawing.Size(69, 17);
            this.btnXoaMap.TabIndex = 18;
            this.btnXoaMap.Text = "Xóa Map";
            this.btnXoaMap.UseVisualStyleBackColor = true;
            this.btnXoaMap.CheckedChanged += new System.EventHandler(this.btnXoaMap_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(853, 371);
            this.Controls.Add(this.btnXoaMap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checklogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtwidth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtgo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "By Lộc Chicken";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.ComboBox cbsever;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbto;
        private System.Windows.Forms.TextBox tbgo;
        private System.Windows.Forms.CheckBox checkadd;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgo;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnloginAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtwidth;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkhide;
        private System.Windows.Forms.CheckBox checklogin;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox btnXoaMap;
        private System.Windows.Forms.Timer timer1;
    }
}

