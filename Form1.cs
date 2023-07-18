using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula06Streaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string titulo = "Eu, a patroa e as crianças";
            string descricao = "O amoroso pai de família Michael Kyle engravidou Janet quando ela ainda era uma adolescente. Os dois se casaram e tiveram três filhos, mas o fantasma de sua própria história faz com que Michael alimente um verdadeiro pavor de que o mesmo aconteça com seus filhos.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula06Streaming/Aula06Streaming/imagens/Eu_apatroa_eas_crianças.jpg";
            string link_video = " https://www.youtube.com/embed/Zhryrju4CaE ";


            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.caminho_imagem = caminho_imagem;
            telaInfo.link_video = link_video;
            telaInfo.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string titulo = "Um maluco no pedaço";
            string descricao = "Will Smith interpreta um adolescente da Filadélfia que acabou indo parar na Califórnia para morar com seus tios ricos. A expectativa da família era ensinar a ele alguns valores tradicionais.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula06Streaming/Aula06Streaming/imagens/um_maluco_no_pedaço.jpg";
            string link_video = "https://www.youtube.com/embed/E47zkZjv6PE";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.caminho_imagem = caminho_imagem;
            telaInfo.link_video = link_video;
            telaInfo.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string titulo = "Supernatural";
            string descricao = "A série narra a história de dois irmãos, Sam Winchester e Dean Winchester, interpretados respectivamente por Jared Padalecki e Jensen Ackles, que caçam demônios, fantasmas, monstros vampiros e outras criaturas sobrenaturais no mundo.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula06Streaming/Aula06Streaming/imagens/supernatural.jpg";
            string link_video = "https://www.youtube.com/embed/t-775JyzDTk";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.link_video = link_video;
            telaInfo.caminho_imagem = caminho_imagem;
            telaInfo.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            String titulo = "Fique rico ou morra tentando";
            string descricao = "Marcus (50 Cent) é um jovem da periferia que sofreu uma atentado que por pouco não lhe tirou a vida. Em meio à sua recuperação, ele se lembra de uma vida difícil como órfão nas ruas violentas do Bronx. Sua vida muda após conhecer um ex-condenado, que luta para transforma-lo em uma estrela do rap.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula06Streaming/Aula06Streaming/imagens/fique_rico_ou_morra_tentando.jpg";
            string link_video = "https://www.youtube.com/embed/Cg_nHAMXCCM";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.link_video = link_video;
            telaInfo.caminho_imagem = caminho_imagem;
            telaInfo.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            String titulo = "Corra!";
            string descricao = "Chris é um jovem fotógrafo negro que está prestes a conhecer os pais de Rose, sua namorada caucasiana. Na luxuosa propriedade dos pais dela, Chris percebe que a família esconde algo muito perturbador.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula06Streaming/Aula06Streaming/imagens/corra!.jpg";
            string link_video = "https://www.youtube.com/embed/mDGV5UucTu8";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.caminho_imagem = caminho_imagem;
            telaInfo.link_video = link_video;
            telaInfo.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            String titulo = "Sem medo no coração";
            string descricao = "Justice é cabeleireira e escreve poesias para amenizar a dor pela morte do namorado gângster e o suicídio de sua mãe. Lucky é carteiro e tenta educar a filha longe da mãe prostituta e viciada.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula06Streaming/Aula06Streaming/imagens/Sem_medo_no_Coração.jpg";
            string link_video = "https://www.youtube.com/embed/Ek6jk408STU";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.caminho_imagem = caminho_imagem;
            telaInfo.link_video = link_video;
            telaInfo.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            String titulo = "As Branquelas";
            string descricao = "Os irmãos Marcus e Kevin Copeland são detetives do FBI que estão com problemas no trabalho. A última investigação da dupla foi um grande fracasso e eles estão sob a ameaça de serem demitidos. Quando um plano para sequestrar as mimadas irmãs Brittany e Tiffany Wilson é descoberto.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula06Streaming/Aula06Streaming/imagens/as_branquelas.jpg";
            string link_video = "https://www.youtube.com/embed/seoJIPLLWp0";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.caminho_imagem = caminho_imagem;
            telaInfo.link_video = link_video;
            telaInfo.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            String titulo = "Gente Grande";
            string descricao = "Os irmãos Marcus e Kevin Copeland são detetives do FBI que estão com problemas no trabalho. A última investigação da dupla foi um grande fracasso e eles estão sob a ameaça de serem demitidos. Quando um plano para sequestrar as mimadas irmãs Brittany e Tiffany Wilson é descoberto.";
            string caminho_imagem = "C:/Users/Public/Source/Repos/Aula06Streaming/Aula06Streaming/imagens/gente_grande.jpg";
            string link_video = "https://www.youtube.com/embed/HKVve_VSz58";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.caminho_imagem = caminho_imagem;
            telaInfo.link_video = link_video;
            telaInfo.Show();
        }
    }
}
