using System.Data;

namespace TrabalhoDAL
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void segundosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tempo tempo = new Tempo();
            tempo.MdiParent = this;
            tempo.Show();
        }

        private void númerosParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pares pares = new Pares();
            pares.MdiParent = this;
            pares.Show();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temperatura temperatura = new Temperatura();
            temperatura.MdiParent = this;
            temperatura.Show();
        }

        private void divisívelPor3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PorTres portres = new PorTres();
            portres.MdiParent = this;
            portres.Show();
        }

        private void idadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Idade idade = new Idade();
            idade.MdiParent = this;
            idade.Show();
        }

        private void inteiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParImpar parimpar = new ParImpar();
            parimpar.MdiParent = this;
            parimpar.Show();
        }

        private void diferençaDosNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiferencaNumeros diferencanumeros = new DiferencaNumeros();
            diferencanumeros.MdiParent = this;
            diferencanumeros.Show();
        }

        private void pesoEAlturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IMC imc = new IMC();
            imc.MdiParent = this;
            imc.Show();
        }

        private void notaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            nota.MdiParent = this;
            nota.Show();
        }

        private void diferençaDeDiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiferencaDias diferencadias = new DiferencaDias();
            diferencadias.MdiParent = this;
            diferencadias.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void de0A100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZeroaCem zeroacem = new ZeroaCem();
            zeroacem.MdiParent = this;
            zeroacem.Show();
        }
    }
}
