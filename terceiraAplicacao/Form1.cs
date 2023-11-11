using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace terceiraAplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            uC_adProd1.BringToFront();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            uC_verEst1.BringToFront();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            uC_retPeca1.BringToFront();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            uC_imRel1.BringToFront();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdBtnNao_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
