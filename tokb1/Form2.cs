using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tokb1;

namespace tokb1
{
    public partial class Form2 : Form
    {
        Class1 b;
        public Form2()
        {
            b = new Class1();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text1.Text != "" && text2.Text != "" && text3.Text != "")
            {
                if (text1.Text == text2.Text)
                {
                    string EnterPas;
                    EnterPas = b.ReadFromFile();
                    if (b.Encode(text3.Text, Class1.Key) == EnterPas)
                    {
                        string EncodePas;
                        Class1.Key = b.GenKey();
                        EncodePas = b.Encode(text1.Text, Class1.Key);
                        b.WriteInFile(EncodePas);
                        this.Hide();
                        vivod_key vivod_key = new vivod_key();
                        vivod_key.ShowDialog();
                        this.Close();

                    }
                    else
                        MessageBox.Show("Старый пароль введен неверно!");
                }
                else
                    MessageBox.Show("Пароли не совпадают!");
            }
            else
                MessageBox.Show("Поля не могут быть пустыми!");
        }
    }
}
