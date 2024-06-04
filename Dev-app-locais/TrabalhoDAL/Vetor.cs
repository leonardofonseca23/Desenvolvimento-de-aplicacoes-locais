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
    public partial class Vetor : Form
    {
        public Vetor()
        {
            InitializeComponent();
        }

        private List<int> nums = new List<int>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            lbVetor.Items.Add($"{nums.Count}: {num}");
            nums.Add(num);
            if (nums.Count == 8)
            {
                calculate();
            }
            txtNum.Clear();
        }

        private void calculate()
        {
            int soma = 0;
            for(int x = 0; x < 8; x++)
            {
                soma += nums[x] * x;
            }

            MessageBox.Show($"Soma: {soma}");
            lbVetor.Items.Clear();
            nums.Clear();
        }
    }
}
