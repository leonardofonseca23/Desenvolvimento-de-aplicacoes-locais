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
    public partial class Tempo : Form
    {
        public Tempo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTempo_Click(object sender, EventArgs e)
        {
            int tempo = Int32.Parse(txtTempo.Text);
            int minutos = tempo / 60;
            int horas = minutos / 60;

            string total = $"{horas:00}:{minutos - horas * 60:00}:{tempo - minutos * 60:00}";

            MessageBox.Show($"Horas: {horas}\nMinutos: {minutos}\nSegundos: {tempo}\nHoras total: {total}");
        }
    }
}
