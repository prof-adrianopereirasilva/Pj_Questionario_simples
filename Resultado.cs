using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pj_Questionario_simples
{
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
        }

        private void bt_avancar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            lb_certa.Text = Variaveis.Certas.ToString();
            lb_errada.Text = Variaveis.Erradas.ToString();
        }
    }
}
