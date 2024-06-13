using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pj_Questionario_simples
{
    public partial class Q2 : Form
    {
        public Q2()
        {
            InitializeComponent();
        }

        private void Q2_Load(object sender, EventArgs e)
        {

        }

        private void bt_avancar_Click(object sender, EventArgs e)
        {
            if (rbt_certa.Checked == true)
            {
                SoundPlayer sound = new SoundPlayer("woohoo.wav");
                sound.PlaySync();

                MessageBox.Show("Resposta Certa!");
                Variaveis.Certas++;
                
                Resultado resultado = new Resultado();
                resultado.ShowDialog();
                this.Dispose();
            }
            else if (rbt_errada1.Checked || rbt_errada2.Checked || rbt_errada3.Checked)
            {
                SoundPlayer sound = new SoundPlayer("ah.wav");
                sound.PlaySync();

                MessageBox.Show("Resposta Errada!");
                Variaveis.Erradas++;
                
                Resultado resultado = new Resultado();
                resultado.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma opção!");
            }
        }
    }
}
