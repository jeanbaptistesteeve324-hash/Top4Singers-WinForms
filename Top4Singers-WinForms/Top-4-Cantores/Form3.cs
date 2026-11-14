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

namespace Top_4_Cantores
{
    public partial class Frm_NBAYoungBoy : Form
    {
        bool liked = false; //Guarda se o coração foi clicado (false = não curtiu, true = curtiu)

        public Frm_NBAYoungBoy()
        {
            InitializeComponent();
        }

        private void Frm_NBAYoungBoy_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"Cantores\NBAYoungBoy.mp4";
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Top4 terceiro = new Frm_Top4(); //instanciando (criado) um projeto
            terceiro.Show(); //chamado a nova tela renomeada Top4
            Hide(); //Ocultando a tela 1
        }

        private void Frm_NBAYoungBoy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Nome.Clear(); //Limpar o text
        }

        private void Btn_Like_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você curtiu o NBA YoungBoy"); //Mostra a mensagem para o usuário
            liked = !liked; //Inverte o valor: se era false vira true, se era true vira false

        }


        private void Txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar))

            {
                e.Handled = true; //Verifica as teclas precionadas
                MessageBox.Show("Só Permite Letras e números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.KeyChar == 13) //A tecla enter 13 foi Precionada
            {
                if (Txt_Nome.Text != "") //Verifica se o text esta vazio
                {

                }

                else
                {
                    MessageBox.Show("O nome não foi digitado...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Avaliar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu comentário foi enviado com sucesso!"); //Mostra a mensagem para o usuário

            //Cria o texto do like: se liked for true escreve "Sim", se não escreve "Não"
            string like = liked ? "Like: Sim" : "Like: Não";

            //Junta o comentário com o like, um embaixo do outro
            string conteudo = Txt_Nome.Text + Environment.NewLine + like;

            //Salve o conteúdo em um arquivo .txt
            //O nome do arquivo termina com dia, mês, ano, hora, minuto e segundo
            File.WriteAllText(@"c:\Comentar\NBA YoungBoy" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".txt", conteudo);

            Txt_Nome.Clear(); //Limpar o texto
            liked = false;    //Zera o like para o próximo comentário
        }

        private void Txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
