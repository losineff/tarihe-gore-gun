using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            switch (a)
            {
                case 1: listBox1.Items.Add("Pazartesi"); break;
                case 2: listBox1.Items.Add("Salı"); break;
                case 3: listBox1.Items.Add("Çarşamba"); break;
                case 4: listBox1.Items.Add("Perşembe"); break;
                case 5: listBox1.Items.Add("Cuma"); break;
                case 6: listBox1.Items.Add("Cumartesi"); break;
                case 7: listBox1.Items.Add("Pazar"); break;
                case 8: listBox1.Items.Add("Pazartesi"); break;
                case 9: listBox1.Items.Add("Salı"); break;
                case 10: listBox1.Items.Add("Çarşamba"); break;
                case 11: listBox1.Items.Add("Perşembe"); break;
                case 12: listBox1.Items.Add("Cuma"); break;
                case 13: listBox1.Items.Add("Cumartesi"); break;
                case 14: listBox1.Items.Add("Pazar"); break;
                case 15: listBox1.Items.Add("Pazartesi"); break;
                case 16: listBox1.Items.Add("Salı"); break;
                case 17: listBox1.Items.Add("Çarşamba"); break;
                case 18: listBox1.Items.Add("Perşembe"); break;
                case 19: listBox1.Items.Add("Cuma"); break;
                case 20: listBox1.Items.Add("Cumartesi"); break;
                case 21: listBox1.Items.Add("Pazar"); break;
                case 22: listBox1.Items.Add("Pazartesi"); break;
                case 23: listBox1.Items.Add("Salı"); break;
                case 24: listBox1.Items.Add("Çarşamba"); break;
                case 25: listBox1.Items.Add("Perşembe"); break;
                case 26: listBox1.Items.Add("Cuma"); break;
                case 27: listBox1.Items.Add("Cumartesi"); break;
                case 28: listBox1.Items.Add("Pazar"); break;
                case 29: listBox1.Items.Add("Pazartesi"); break;
                case 30: listBox1.Items.Add("Salı"); break;
                case 31: listBox1.Items.Add("Çarşamba"); break;
                default: listBox1.Items.Add("mevcut tarih giriniz"); break;
            }
               

        }
    }
}
