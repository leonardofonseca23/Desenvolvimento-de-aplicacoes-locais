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
    public partial class Pares : Form
    {
        public Pares()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);

            for(int i = num1; i < num2; i++)
            {
                if(i%2 == 0)
                {
                    MessageBox.Show($"{i}");
                }
            }
            MessageBox.Show("Obrigado!");
        }
    }
}
