using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoDAL
{
    public partial class DiferencaNumeros : Form
    {
        public DiferencaNumeros()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);

            double res;

            if (num1 > num2)
            {
                res = num1 - num2;
            }
            else
            {
                res = num2 - num1;
            }

            MessageBox.Show($"A diferença é de {res}");
        }
    }
}
