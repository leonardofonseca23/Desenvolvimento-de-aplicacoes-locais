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
    public partial class AnoBissexto : Form
    {
        public AnoBissexto()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int ano = Convert.ToInt32(txtAno.Text);

            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                MessageBox.Show($"{ano} é um ano bissexto.");
            }
            else 
            {
                MessageBox.Show($"{ano} não é um ano bissexto.");
            }
        }
    }
}
