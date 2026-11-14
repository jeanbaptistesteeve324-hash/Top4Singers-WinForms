using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Top_4_Cantores
{
    public partial class Frm_Top4 : Form
    {
        public Frm_Top4()
        {
            InitializeComponent();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Frm_CentralCee segundo = new Frm_CentralCee(); //iniciando (criado) um projeto
            segundo.Show(); //chamado a nova tela renomeada segundo
            Hide(); //Ocultando a tela 1
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Frm_NBAYoungBoy segundo = new Frm_NBAYoungBoy(); //instanciando (criado) um projeto
            segundo.Show(); //chamado a nova tela renomeada segundo
            Hide(); //Ocultando a tela 2
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Frm_MCKako segundo = new Frm_MCKako(); //instanciando (criado) um projeto
            segundo.Show(); //chamado a nova tela renomeada segundo
            Hide(); //Ocultando a tela 3
        }

        private void Btn_3_Click_1(object sender, EventArgs e)
        {
            Frm_CardiB segundo = new Frm_CardiB(); //instanciando (criado) um projeto
            segundo.Show(); //chamado a nova tela renomeada segundo
            Hide(); //Ocultando a tela 4
        }

        private void Pic_1_Click(object sender, EventArgs e)
        {
            Txt_CentralCee.Text = "Central Cee (nome artístico de Oakley Neil Caesar-Su, nascido em 4 de junho de 1998) é um dos principais rappers, cantores e compositores da cena de UK rap e UK drill da atualidade"; //Para mostrar o text
        }

        private void Pic_2_Click(object sender, EventArgs e)
        {
            Txt_NBA.Text = "NBA YoungBoy (nome verdadeiro: Kentrell DeSean Gaulden) é um conhecido rapper, cantor e compositor americano. Nascimento: 20 de outubro de 1999 (tem 27 anos) em Baton Rouge, Louisiana, EUA. Significado de NBA: Nunca Mais Quebrado, e não tem nenhuma relação com a liga de basquete National Basketball "; //Para mostrar o text
        }

        private void Pic_3_Click(object sender, EventArgs e)
        {
            Txt_CardiB.Text = " Cardi B (nome artístico de Belcalis Marlenis Almánzar) é uma famosa rapper, compositora, atriz e personalidade de televisão americana. Nascida em Nova York em 11 de outubro de 1992, ela se tornou um dos maiores nomes da cultura pop e do hip-hop global."; //Para mostrar o text
        }

        private void Pic_4_Click(object sender, EventArgs e)
        {
            Txt_MCKako.Text = " MC Kako (nome real Jackson Frayle Toledo Campos) é um cantor e compositor brasileiro de funk, trap e rap, conhecido por focar no estilo de funk consciente."; //Para mostrar o text
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"c:\Cantores Avaliação\textoo" + DateTime.Now.ToString("dd_MM_ss") + ".txt", Txt_CentralCee.Text);
            Txt_CentralCee.Clear();
            MessageBox.Show("Artista Foi Avaliada");//Para aparecer artista foi avaliada
        }

        private void Frm_Top4_Load(object sender, EventArgs e)
        {

        }

        
        private void Btn_Voltar1_Click(object sender, EventArgs e)
        {
            Frm_Top4 terceiro = new Frm_Top4(); //instanciando (criado) um projeto
            terceiro.Show(); //chamado a nova tela renomeada Top4
            Hide(); //Ocultando a tela 1
        }

        private void Txt_NBA_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar)) //Se não

            {
                e.Handled = true; //Verifica as teclas precionadas
                MessageBox.Show("Só Permite Letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.KeyChar == 13) //A tecla enter 13 foi Precionada
            {
                if (Txt_NBA.Text != "") //Verifica se o text esta vazio
                {
                    Txt_NBA.Focus(); //Passa e vai para o proximo campo TXT Idade
                }

                else
                {
                    MessageBox.Show("O nome não foi digitado...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
