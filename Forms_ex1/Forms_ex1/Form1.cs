using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_ex1
{
    public partial class Program1 : Form
    {
        int count = 0;

        public Program1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsmiexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiaboutpr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это моя пробная первая программа на С#, \nкоторая содержит набор утилит. \nАвтор: Иванов И.И.", "About program");
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            count++;
            lbcount.Text = count.ToString();
        }

        private void btminus_Click(object sender, EventArgs e)
        {
            count--;
            lbcount.Text = count.ToString();
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            count = 0;
            lbcount.Text = Convert.ToString(count);
        }
    }
}
