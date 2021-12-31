using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDesign
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void siticoneRoundedTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        
        }

        private void siticoneRoundedTextBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void siticoneRoundedTextBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void siticoneRoundedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            siticoneRoundedTextBox1.Text = "";
        }

        private void siticoneRoundedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            siticoneRoundedTextBox2.Text = "";
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Form Register = new Register();
            Register.Show();
            this.Hide();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
