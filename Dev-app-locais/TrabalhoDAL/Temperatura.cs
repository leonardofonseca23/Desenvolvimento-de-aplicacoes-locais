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
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            int temperatura = Convert.ToInt32(txtTemperatura.Text);
            double res;
            if (rbK.Checked)
            {
                res = temperatura + 273.15;
            } else
            {
                res = (temperatura * 9 / 5) + 32;
            }
            MessageBox.Show($"{res}");
        }
    }
}
