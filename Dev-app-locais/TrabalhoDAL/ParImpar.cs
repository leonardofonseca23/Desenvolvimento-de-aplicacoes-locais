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
    public partial class ParImpar : Form
    {
        public ParImpar()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumInt.Text);
            string res;
            if (num % 2 == 0)
            {
                res = $"O dobro de {num} é {num * 2:0.00}";
            }
            else
            {
                res = $"A metade de {num} é {(double)num / 2:0.00}";
            }

            MessageBox.Show($"Resultado: {res:00,00}");
        }
    }
}
