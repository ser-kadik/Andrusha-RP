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

namespace Andrusha_RP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int a = 0;
        public bool used;
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Недастаточно средств");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(a == 0)
            {
                used = true;
                button5.Text = "Играть";
                a++;
            }

            else
            {
                Form1 andrusha = new Form1();
                Hide();
                andrusha.ShowDialog();
                this.Close();
            }
        }

       
    }
}
