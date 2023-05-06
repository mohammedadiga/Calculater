using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculater
{
    public partial class Form1 : Form
    {

        /*
         *  mersin üniversitesi bilgisayar programcılığı
         *  Project Name : Hesap Makinesi
         *  User: Mohamad Younes
         *  GitHub: https://github.com/mohammedadiga
         */

        public Form1()
        {
            InitializeComponent();
        }


        // değişkenler

        float num;
        int count;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Düğme Kapat

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Düğme Eksi

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "-";
                txtstore.Clear();
                count = 1;
            }
        }

        // Düğme Arti

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "+";
                txtstore.Clear();
                count = 2;
            }
        }

        // Düğme Çarpma

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "x";
                txtstore.Clear();
                count = 3;
            }
        }

        // Düğme Bolme

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "/";
                txtstore.Clear();
                count = 4;
            }
        }

        // Düğme Yüzde

        private void btnrd_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "%";
                txtstore.Clear();
                count = 5;
            }
        }

        // Düğme Eşetli

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            float ans;

            switch(count){
                case 1:
                    ans = num - float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 2:
                    ans = num + float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 5:
                    ans = num % float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
            }

        }

        // Düğme 0

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "0";
        }

        // Düğme 1

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "1";
        }

        // Düğme 2

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "2";
        }

        // Düğme 3

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "3";
        }

        // Düğme 4

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "4";
        }

        // Düğme 5

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "5";
        }

        // Düğme 6

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "6";
        }

        // Düğme 7

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "7";
        }

        // Düğme 8

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "8";
        }

        // Düğme 9

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "9";
        }

        // Düğme Nokta
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + ".";
        }

        // Düğme Nokta

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        // Düğme Temizle

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtresualt.Clear();
            txtstore.Clear();
            txtresualt.Text = "0";
        }

        // Düğme GitHub

        private void github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mohammedadiga/Calculater");
        }
    }
}
