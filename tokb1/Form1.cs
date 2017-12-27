using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using tokb1;

namespace tokb1
{
    public partial class Form1 : Form
    {
        private Class1 b;
        public Form1()
        {
            b = new Class1();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.Pas = password.Text;
            if (!(File.Exists("\\qwerty.txt")))
            {
                string EncodePas;
                Class1.Key = b.GenKey();
                EncodePas = b.Encode(password.Text, Class1.Key);
                b.WriteInFile(EncodePas);
                this.Hide();
                vivod_key vivod_key = new vivod_key();
                vivod_key.ShowDialog();
                this.Close();
            }
            else
            {
                vvod_key vvod_k = new vvod_key();
                this.Hide();
                vvod_k.ShowDialog();
                this.Close();
            }
        }
    }
}
