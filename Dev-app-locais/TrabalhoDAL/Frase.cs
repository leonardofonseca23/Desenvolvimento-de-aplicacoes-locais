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
    public partial class Frase : Form
    {
        public Frase()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string frase = txtFrase.Text;
            string letra = txtLetra.Text;

            if (letra.Length != 1)
            {
                MessageBox.Show("Por favor, insira uma letra.");
                return;
            }

            char letraChar = letra[0];
            int contagem = 0;

            foreach (char c in frase)
            {
                if (c == letraChar)
                {
                    contagem++;
                }
            }

            MessageBox.Show($"A letra '{letraChar}' aparece {contagem} vezes na frase.");
        }
    }
}
