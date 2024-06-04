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
    public partial class ZeroaCem : Form
    {
        public ZeroaCem()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numericUpDown1.Value);
            lbNumeros.Items.Add(num);
            numericUpDown1.Value = 0;
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            int len = lbNumeros.Items.Count;
            int a=0, b=0, c=0, d=0;

            for (int x = 0; x < len; x++)
            {
                int num = Convert.ToInt32(lbNumeros.Items[x]);
                if (num <= 25)
                {
                    a++;
                }
                else if (num <= 50)
                {
                    b++;
                } else if (num <= 75)
                {
                    c++;
                }
                else if (num <= 100)
                {
                    d++;
                }
            }

            MessageBox.Show(
                $"Números de 0 à 25: {a}\n" +
                $"Números de 26 à 50: {b}\n" +
                $"Números de 51 à 75: {c}\n" +
                $"Números de 76 à 100: {d}\n"
            );
        }
    }
}
