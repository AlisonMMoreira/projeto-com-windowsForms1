using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using terceiraAplicacao;

namespace terceiraAplicacao
{
    public partial class UC_adProd : UserControl
    {
        public UC_adProd()
        {
            InitializeComponent();
        }

        private void rdBtnNao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdBtnSim_CheckedChanged(object sender, EventArgs e)
        {
            object value = uC_prodCad.BringToFront();
        }
    }
}