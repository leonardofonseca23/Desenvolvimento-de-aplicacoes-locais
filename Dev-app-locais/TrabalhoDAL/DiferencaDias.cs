﻿using System;
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
    public partial class DiferencaDias : Form
    {
        public DiferencaDias()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DateTime data1 = dtp1.Value;
            DateTime data2 = dtp2.Value;

            TimeSpan diferenca = data2 - data1;
            int diasDiferenca = Math.Abs(diferenca.Days);

            MessageBox.Show($"A diferença é de {diasDiferenca} dias.");
        }
    }
}
