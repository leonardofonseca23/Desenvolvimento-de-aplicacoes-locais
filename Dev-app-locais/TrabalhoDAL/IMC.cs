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
    public partial class IMC : Form
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var altura = Convert.ToDouble(txtAltura);
            double peso = Convert.ToDouble(txtPeso);

            double resp = peso / (altura * altura);

            MessageBox.Show ($"Seu IMC é: {resp}");
        }
    }
}
