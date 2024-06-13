namespace Pj_Questionario_simples
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variaveis.Certas = 0;
            Variaveis.Erradas = 0;  
            Q1 questionari1 = new Q1();
            questionari1.ShowDialog();
        }
    }
}
