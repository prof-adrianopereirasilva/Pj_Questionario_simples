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
    public partial class Q1 : Form
    {
        public Q1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rbt_certa.Checked==true)
            {
                SoundPlayer sound = new SoundPlayer("woohoo.wav");
                sound.PlaySync();

                MessageBox.Show("Resposta Certa!");
                Variaveis.Certas++;
                
                Q2 questionario2 = new Q2();   
                questionario2.ShowDialog();
                this.Dispose();
            }
            else if (rbt_errada1.Checked || rbt_errada2.Checked || rbt_errada3.Checked)
            {
                SoundPlayer sound = new SoundPlayer("ah.wav");
                sound.PlaySync();

                MessageBox.Show("Resposta Errada!");
                Variaveis.Erradas++;
                
                Q2 questionario2 = new Q2();
                questionario2.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma opção!");

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbt_certa_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
