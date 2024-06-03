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
    public partial class Nota : Form
    {
        public Nota()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var nota = Convert.ToDecimal(txtNota.Text);
            string resultado;


            if (nota == 10)
            {
                resultado = "Excelente";
            }
            else if (nota >= 8 && nota < 10)
            {
                resultado = "Muito bom";
            }
            else if (nota >= 7 && nota < 8)
            {
                resultado = "Bom";
            }
            else if (nota >= 0 && nota < 7)
            {
                resultado = "Insatisfatório";
            }
            else
            {
                resultado = "Nota inválida";
            }

            MessageBox.Show($"{resultado}");

        }
    }
}
