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
    public partial class vivod_key : Form
    {
        public vivod_key()
        {
            InitializeComponent();
            new_key.Text = Class1.Key;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
