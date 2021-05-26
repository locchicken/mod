using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading;
using System.Text.RegularExpressions;

namespace Mod_QLTK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
            btnedit.Enabled = true;
            txtuser.Enabled = true;
            txtpass.Enabled = true;
            cbsever.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
                if(checkadd.Checked)
                {
                    int go = int.Parse(tbgo.Text);
                    int to = int.Parse(tbto.Text);
                    string tk = txtuser.Text;
                    string[] mang = tk.Split('x');
                    for (int i = go; i <= to; i++)
                    {
                        string acc = mang[0] + i + mang[1];
                    ListViewItem list = new ListViewItem((listView1.Items.Count + 1).ToString());
                    list.SubItems.Add(acc);
                    list.SubItems.Add(/*mahoa(laychuoingaunhien(10) + */txtpass.Text);
                    list.SubItems.Add(cbsever.SelectedItem.ToString());
                    list.SubItems.Add(string.Empty);
                    listView1.Items.Add(list);
                }
                 }
                else
                {
                    btnAdd.Enabled = true;
                    btnedit.Enabled = false;
                    btnsave.Enabled = false;
                    ListViewItem list = new ListViewItem((listView1.Items.Count + 1).ToString());
                    list.SubItems.Add(txtuser.Text);

                    list.SubItems.Add(/*mahoa(laychuoingaunhien(10) + */txtpass.Text);
                    list.SubItems.Add(cbsever.SelectedItem.ToString());
                    list.SubItems.Add(string.Empty);
                    
                    listView1.Items.Add(list);
                }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                timer1.Enabled = true;
                string[] mang = File.ReadAllLines(Application.StartupPath + "//Account.txt");
                int i = 0;
            nhatloc:
                string[] row = mang[i].Split('|');
                ListViewItem list = new ListViewItem((listView1.Items.Count+1).ToString());
                list.SubItems.Add(row[0]);
                list.SubItems.Add(row[1]);
                list.SubItems.Add(row[2]);
                list.SubItems.Add(string.Empty);
                listView1.Items.Add(list);
                i++;
                if (i < mang.Length)
                    goto nhatloc;
            }
            catch(Exception ex)
            {

            }
            
        }
       
        private int index;
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            index = e.ItemIndex;
            txtuser.Text = listView1.Items[index].SubItems[1].Text.ToString();
            txtpass.Text = listView1.Items[index].SubItems[2].Text.ToString();
            cbsever.SelectedItem = listView1.Items[index].SubItems[3].Text.ToString();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
           for(int i=0;i<listView1.Items.Count;i++)
            {
                if(listView1.Items[i].Selected)
                {
                    listView1.Items.RemoveAt(i);
                }
            }
            
        }
        public string laychuoingaunhien(int n)
        {
            string chuoi = "zxcvbnmlkjhgfdsapoiuytrewq0987623451#$%&#";
            Random rd = new Random();
            string kq = "";
            for(int i=0;i<n;i++)
            {
                kq += chuoi[rd.Next(0, chuoi.Length)].ToString();
            }
            return kq;
        }
        public string mahoa(string dulieu)
        {
            
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            return Convert.ToBase64String(md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(dulieu)));
        }
        private void ketnoisever()
        {
            try
            {
                FileStream file = new FileStream(Application.StartupPath + "//LocChicken_Data//Acc", FileMode.Create, FileAccess.Write);
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.Write(txtuser.Text + "|" + txtpass.Text + "|" + cbsever.SelectedIndex);
                    writer.Close();
                }
                   
            }
            catch(Exception ex)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sapxep();
        }
        public void sapxep()
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            Process[] processes = Process.GetProcesses();
            List<Process> list = new List<Process>();
            foreach (Process process in processes)
            {
                bool flag = process.ProcessName.Contains("Chicken");
                if (flag)
                {
                    list.Add(process);
                }
            }
            int num = 0;
            int num2 = 0;
            foreach (Process process2 in list)
            {
                IntPtr mainWindowHandle = process2.MainWindowHandle;
                int num3 = 200 * num;
                bool flag2 = num3 > width;
                if (flag2)
                {
                    num3 = 0;
                    num = 0;
                    num2 += 248;
                }
                Form1.MoveWindow(mainWindowHandle, num3, num2, 200, 248, true);
                num++;
            }
        }

        [DllImport("user32.dll")]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        public static extern bool SetWindowText(IntPtr hwnd, string lpString);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           try
            {
                string[] mang = new string[listView1.Items.Count];
                int i = 0;
            nhatloc:
                mang[i] = listView1.Items[i].SubItems[1].Text + "|" +
                    listView1.Items[i].SubItems[2].Text + "|" +
                    listView1.Items[i].SubItems[3].Text+ "|"+
                    listView1.Items[i].SubItems[4].Text;
                i++;
                if (i < listView1.Items.Count)
                    goto nhatloc;
                File.WriteAllLines(Application.StartupPath + "//Account.txt", mang);
            }
            catch(Exception ex)
            {

            }
        }
      
        private void btnedit_Click(object sender, EventArgs e)
        {
            listView1.Items[index].SubItems[1].Text = txtuser.Text;
            listView1.Items[index].SubItems[2].Text = txtpass.Text;
            listView1.Items[index].SubItems[3].Text = cbsever.SelectedItem.ToString();
        }

        private void checkadd_CheckedChanged(object sender, EventArgs e)
        {
            if(checkadd.Checked)
            {
                tbgo.Visible = true;
                tbto.Visible = true;
                label4.Visible = true;          
            }
            else
            {
                tbgo.Visible = false;
                tbto.Visible = false;
                label4.Visible = false;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Process.Start("LocChicken.exe", $"--acc {txtuser.Text} --pass {txtpass.Text} --server {cbsever.SelectedIndex} --width {txtwidth.Text} --height {txtheight.Text} --xoamap {btnXoaMap.Checked}");
        }

        private void btnloginAll_Click(object sender, EventArgs e)
        {
                index = int.Parse(txtgo.Text);
                int t = (txtto.Text != null) ? int.Parse(txtto.Text) : listView1.Items.Count; 
                for (int i = index; i <= t; i++)
                {
                Process.Start("LocChicken.exe", $"--acc {listView1.Items[i].SubItems[1].Text} --pass {listView1.Items[i].SubItems[2].Text} --server {listView1.Items[i].SubItems[3].Text} --width {txtwidth.Text} --height {txtheight.Text} --xoamap {btnXoaMap.Checked}");
                Thread.Sleep(1000);
                Form1.SetWindowText(Form1.FindWindow(null, "Dragonboy177"), "Chicken");
                Thread.Sleep(4000);
                }
        }    
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Yellow, 6, 265, 841, 100);
            e.Graphics.DrawRectangle(Pens.Yellow, 512, 4, 1, 258);
        }

        private void checkhide_CheckedChanged(object sender, EventArgs e)
        {
            if(checkhide.Checked)
            {
                txtpass.UseSystemPasswordChar = true;
            }
            else
            {
                txtpass.UseSystemPasswordChar = false;
            }
        }
        public void updateCharData(string path)
        {
            if (File.Exists(path))
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    StreamReader streamReader = new StreamReader(fileStream);
                    string[] array = streamReader.ReadLine().Split(new char[]
                    {
                    '|'
                    });
                    listView1.Items[index].SubItems[4].Text = array[3];

                    streamReader.Close();
                    fileStream.Close();
                }
                    
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                this.power("LocChicken_Data//Data//data" + listView1.Items[i].SubItems[1].Text);
            }
        }
       
        private void btnXoaMap_CheckedChanged(object sender, EventArgs e)
        {
            if(btnXoaMap.Checked==true)
            {
                string s = "xoamap";
                FileStream file = new FileStream("LocChicken_Data//XoaMap", FileMode.Create, FileAccess.Write);
                using (StreamWriter ghi = new StreamWriter(file))
                {
                    ghi.Write(s);
                    ghi.Close();
                }
            }
            else
            {
                File.Delete("LocChicken_Data//XoaMap");
            }
        }
        public void power(string path)
        {
            try
            {
                FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string[] mang = reader.ReadLine().Split('|');
                if(listView1.Items[index].SubItems[1].Text==mang[0])
                {
                    listView1.Items[index].SubItems[4].Text = mang[3];
                }
                reader.Close();
                file.Close();
            }
            catch(Exception)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                this.power("LocChicken_Data//Data//data" + listView1.Items[i].SubItems[1].Text);
            }
        }
    }
}
