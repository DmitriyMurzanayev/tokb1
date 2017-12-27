using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tokb1
{
    public partial class vvod_key : Form
    {
        Class1 b;
        public vvod_key()
        {
            b = new Class1();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NewPas;
            string EnterPas;

            if (Key.Text == "")
            {
                MessageBox.Show("Поле ключа не может быть пустым!");
            }
            else
            {
                EnterPas = b.Encode(Class1.Pas, Key.Text);
                if (b.ReadFromFile() == EnterPas)
                {
                    Class1.Key = b.GenKey();
                    NewPas = b.Encode(Class1.Pas, Class1.Key);
                    b.WriteInFile(NewPas);
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(String.Format("Неправильный пароль или ключ!\nОсталось попыток: {0}", Class1.PopytkaNum));
                    Class1.PopytkaNum--;
                    if (Class1.PopytkaNum < 0)
                    {
                        MessageBox.Show("Попытки закончились!");
                        Application.Exit();
                    }

                    Form1 f = new Form1();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
