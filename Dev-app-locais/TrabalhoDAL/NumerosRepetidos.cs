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
    public partial class NumerosRepetidos : Form
    {
        public NumerosRepetidos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum1.Text);
            lb1.Items.Add(num);
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum2.Text);
            lb2.Items.Add(num);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int len1 = lb1.Items.Count;
            int len2 = lb2.Items.Count;

            List<int> items_engual = new List<int>();

            for(int i = 0; i < len1; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    if (Convert.ToInt32(lb1.Items[i]) == Convert.ToInt32(lb2.Items[j]))
                    {
                        items_engual.Add(Convert.ToInt32(lb1.Items[i]));
                    }
                };
            }

            string message = "Números repetidos nos arrays:\n";

            for (int x = 0; x < items_engual.Count; x++)
            {
                message += $"{items_engual[x]}\n";
            }

            MessageBox.Show(message);
        }
    }
}
