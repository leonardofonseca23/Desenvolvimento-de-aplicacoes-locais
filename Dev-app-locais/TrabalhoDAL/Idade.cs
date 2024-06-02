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
    public partial class Idade : Form
    {
        public Idade()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            DateTime dtNasc = dtpIdade.Value;
            DateTime now = DateTime.Now;
            int idade = now.Year - dtNasc.Year;
            if (now.DayOfYear < dtNasc.DayOfYear)
            {
                idade--;
            }

            MessageBox.Show($"Idade: {idade} ano(s).");
        }
    }
}
