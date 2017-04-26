using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV.view;
namespace QLTV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSACH form = new FormSACH();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormKHACH form = new FormKHACH();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPM form = new FormPM();
            form.Show();
        }

    }
}
