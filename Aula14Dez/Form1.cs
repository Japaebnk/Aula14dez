using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Aula14Dez.Form1;

namespace Aula14Dez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class ChecaForcaSenha
        {

            public enum ForcaDaSenha
            {
                Inaceitavel,
                Fraca,
                Aceitavel,
                Forte,
                Segura
            }

            public int geraPontosSenha(string senha)
            {
                if (senha == null) return 0;
                int pontosPorTamanho = GetPontoPorTamanho(senha);
                int pontosPorMinusculas = GetPontoPorMinusculas(senha);
                int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
                int pontosPorDigitos = GetPontoPorDigitos(senha);
                int pontosPorSimbolos = GetPontoPorSimbolos(senha);
                int pontosPorRepeticao = GetPontoPorRepeticao(senha);
                return pontosPorTamanho + pontosPorMinusculas +
                    pontosPorMaiusculas + pontosPorDigitos +
                    pontosPorSimbolos - pontosPorRepeticao;
            }

            private int GetPontoPorTamanho(string senha)
            {
                return Math.Min(10, senha.Length) * 7;
            }

            private int GetPontoPorMinusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorMaiusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorDigitos(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
                return Math.Min(2, rawplacar) * 6;
            }

            private int GetPontoPorSimbolos(string senha)
            {
                int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorRepeticao(string senha)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
                bool repete = regex.IsMatch(senha);
                if (repete)
                {
                    return 30;
                }
                else
                {
                    return 0;
                }
            }

            public ForcaDaSenha GetForcaDaSenha(string senha)
            {
                int placar = geraPontosSenha(senha);

                if (placar < 50)//Se tiver mais de uma resposta,se for menor que 50.
                    return ForcaDaSenha.Inaceitavel;//Imprime na tela.
                else if (placar < 60)//Se tiver mais de duas respostas,se for maior que 50 e menor que 60.
                    return ForcaDaSenha.Fraca;//Imprime na tela.
                else if (placar < 80)//Se tiver mais de duas respostas,menor que 80.
                    return ForcaDaSenha.Aceitavel;
                else if (placar < 100)//Se tiver mais de duas respostas,menor que 100.
                    return ForcaDaSenha.Forte;//Imprime na tela.
                else
                    return ForcaDaSenha.Segura;//Imprime na tela.
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
        }

        private void botaolimpar_Click(object sender, EventArgs e)
        {
            imputmensagem.Text = "";//Edita a mensagem dentro da caixa TextBox.
            labelmensagem.Text = "";//Edita a mensagem dentro da caixa Label.
        }

        private void imputmensagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void VerificaçãoDeCaracteres(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();//Verificando o Objetivo "Verifica" da classe + O Construtor.
            ChecaForcaSenha.ForcaDaSenha forca;//classe guarda as informações de ForcaDaSenha e a variavel(forca).
            forca = verifica.GetForcaDaSenha(imputmensagem.Text);//Variavel "Forca" verifica a mensagem exibida no TextBox.
            labelmensagem.Text = forca.ToString();//Nome da Label,variavel "Forca" guarda a variavel de caractéres.
        }
    }
}
