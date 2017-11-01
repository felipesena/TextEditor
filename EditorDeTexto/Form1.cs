using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace EditorDeTexto
{
    public partial class frmEditorDeTexto : Form
    {
        //Filtro de formatos a serem salvos e lidos
        string formatos = "Formato Rich Text |*.rtf|Texto sem formatação |*.txt*";

        DialogResult result;
        SaveFileDialog salvar;

        //Vetor para receber os locais em que estão as strings encontradas no Rich Text
        public Busca busca;

        //Variavel utilizada para armazenar o caminho do arquivo e verificar já existe algum arquivo com aquele nome
        string nomeArquivo = "";

        //Variavel auxiliar utilizada na seleção das strings da busca
        int aux = 1;

        //Variavel para verificar qual metodo foi usado por ultimo
        int metodoBusca;

        bool analiseDesempenho;

        public frmEditorDeTexto()
        {
            InitializeComponent();
        }

        //Alinhar a esquerda
        private void toolStripEsquerda_Click(object sender, EventArgs e)
        {
            rtbTexto.SelectionAlignment = HorizontalAlignment.Left;            
        }

        //Centralizar
        private void toolStripCentro_Click(object sender, EventArgs e)
        {
            rtbTexto.SelectionAlignment = HorizontalAlignment.Center;
        }

        //Alinhar a direita
        private void toolStripDireita_Click(object sender, EventArgs e)
        {
            rtbTexto.SelectionAlignment = HorizontalAlignment.Right;
        }
        
        private void toolStripNegrito_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void negrito()
        {
            //Salva qual a fonte que está sendo usada atualmente
            Font currentFont = rtbTexto.SelectionFont;

            FontStyle novaFontStyle;

            //Verificação os estilos que tem a fonte
            bool negrito = rtbTexto.SelectionFont.Bold;
            bool italico = rtbTexto.SelectionFont.Italic;
            bool sublinhado = rtbTexto.SelectionFont.Underline;

            if (negrito)
            {
                if(italico && sublinhado)
                {
                    novaFontStyle = FontStyle.Italic | FontStyle.Underline;
                }
                else if (italico)
                {
                    novaFontStyle = FontStyle.Italic;
                }
                else if(sublinhado)
                {
                    novaFontStyle = FontStyle.Underline;
                }
                else
                {
                    novaFontStyle = FontStyle.Regular;
                }
            }
            else
            {
                if(italico && sublinhado)
                {
                    novaFontStyle = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
                }
                else if (italico)
                {
                    novaFontStyle = FontStyle.Bold | FontStyle.Italic;
                }
                else if(sublinhado)
                {
                    novaFontStyle = FontStyle.Bold | FontStyle.Underline;
                }
                else
                {
                    novaFontStyle = FontStyle.Bold;
                }
            }

            //Alteração da fonte
            rtbTexto.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, novaFontStyle);
        }

        private void italico()
        {
            Font currentFont = rtbTexto.SelectionFont;

            FontStyle novaFontStyle;

            //Verificação os estilos que tem a fonte
            bool italico = rtbTexto.SelectionFont.Italic;
            bool sublinhado = rtbTexto.SelectionFont.Underline;
            bool negrito = rtbTexto.SelectionFont.Bold;

            if (italico)
            {
                if(negrito && sublinhado)
                {
                    novaFontStyle = FontStyle.Bold | FontStyle.Underline;
                }
                else if (negrito)
                {
                    novaFontStyle = FontStyle.Bold;
                }
                else if (sublinhado)
                {
                    novaFontStyle = FontStyle.Underline;
                }
                else
                {
                    novaFontStyle = FontStyle.Regular;
                }
            }
            else
            {
                if(negrito && sublinhado)
                {
                    novaFontStyle = FontStyle.Italic | FontStyle.Bold | FontStyle.Underline;
                }
                else if (negrito)
                {
                    novaFontStyle = FontStyle.Italic | FontStyle.Bold;
                }
                else if (sublinhado)
                {
                    novaFontStyle = FontStyle.Italic | FontStyle.Underline;
                }
                else
                {
                    novaFontStyle = FontStyle.Italic;
                }
            }

            //Alteração da fonte
            rtbTexto.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, novaFontStyle);
        }

        private void toolStripItalico_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void sublinhado()
        {
            Font currentFont = rtbTexto.SelectionFont;

            FontStyle novaFontStyle;

            //Verificação os estilos que tem a fonte
            bool sublinhado = rtbTexto.SelectionFont.Underline;
            bool negrito = rtbTexto.SelectionFont.Bold;
            bool italico = rtbTexto.SelectionFont.Italic;

            if (sublinhado)
            {
                if(negrito && italico)
                {
                    novaFontStyle = FontStyle.Bold | FontStyle.Italic;
                }
                else if(negrito)
                {
                    novaFontStyle = FontStyle.Bold;
                }
                else if (sublinhado)
                {
                    novaFontStyle = FontStyle.Underline;
                }
                else
                {
                    novaFontStyle = FontStyle.Regular;
                }
            }
            else
            {
                if(negrito && italico)
                {
                    novaFontStyle = FontStyle.Underline | FontStyle.Bold | FontStyle.Italic;
                }
                else if (negrito)
                {
                    novaFontStyle = FontStyle.Underline | FontStyle.Bold;
                }
                else if(italico)
                {
                    novaFontStyle = FontStyle.Underline | FontStyle.Italic;
                }
                else
                {
                    novaFontStyle = FontStyle.Underline;
                }
            }

            rtbTexto.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, novaFontStyle);
        }

        private void toolStripSublinhado_Click(object sender, EventArgs e)
        {
            sublinhado();
        }

        public void salvarArquivo()
        {
            salvar = new SaveFileDialog();
            salvar.Filter = formatos;
            salvar.Title = "Salvar arquivo de texto";

            result = salvar.ShowDialog();

            if (result == DialogResult.OK)
            {
                //Caso o formato selecionado seja o .rtf
                if (salvar.FilterIndex == 1)
                {
                    rtbTexto.SaveFile(salvar.FileName);                    
                }
                //Caso o formato selecionado seja o .txt
                else
                {
                    StreamWriter sw = new StreamWriter(salvar.FileName + ".txt");

                    for (int linha = 0; linha < rtbTexto.Lines.Length; linha++)
                    {
                        sw.WriteLine(rtbTexto.Lines[linha]);
                    }

                    sw.Close();
                }

                nomeArquivo = salvar.FileName;                
            }
        }

        public void salvarArquivo(FormClosingEventArgs e)
        {
            salvar = new SaveFileDialog();
            salvar.Filter = formatos;
            salvar.Title = "Salvar arquivo de texto";

            result = salvar.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (salvar.FilterIndex == 1)
                {
                    rtbTexto.SaveFile(salvar.FileName);
                }
                else if (salvar.FilterIndex == 2)
                {
                    StreamWriter sw = new StreamWriter(salvar.FileName + ".txt");

                    for (int i = 0; i < rtbTexto.Lines.Length; i++)
                    {
                        sw.WriteLine(rtbTexto.Lines[i]);
                    }

                    sw.Close();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void novoForm()
        {
            frmEditorDeTexto novo = new frmEditorDeTexto();
            novo.Show();
            Application.Run(novo);
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread novo = new Thread(novoForm);
            novo.Start();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvarArquivo();
        }

        private DialogResult messageSalvar()
        {
            DialogResult opcao;
            return opcao = MessageBox.Show("Deseja salvar as alterações?", "Editor de Texto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog formata = new FontDialog();

            if (formata.ShowDialog() == DialogResult.OK)
            {
                rtbTexto.Font = formata.Font;
            }
        }

        private void frmEditorDeTexto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(nomeArquivo))
            {
                frmEditorDeTexto verificacao = new frmEditorDeTexto();

                if (Path.GetExtension(nomeArquivo) == ".rtf")
                {
                    //Carregar o texto do arquivo a ser aberto no Rich Text Box
                    verificacao.rtbTexto.LoadFile(nomeArquivo);
                }
                //Verifica se a extensão selecionada foi .txt
                else if (Path.GetExtension(nomeArquivo) == ".txt")
                {
                    verificacao.rtbTexto.Text = "";

                    StreamReader sr = new StreamReader(nomeArquivo, Encoding.GetEncoding(28591));

                    string InputLine = "";

                    //Copia cada linha do texto do aquivo a ser aberto para o Rich Text Box
                    while ((InputLine = sr.ReadLine()) != null)
                    {
                        verificacao.rtbTexto.Text += InputLine + "\n";
                    }

                    sr.Close();
                }

                if(verificacao.rtbTexto.Text != rtbTexto.Text)
                {
                    result = MessageBox.Show("Deseja salvar as alerações?", "Editor de Texto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                    if(result == DialogResult.Yes)
                    {
                        reescrever();
                    }
                    else if(result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
            //Verifica na hora de fechar o arquivo se há algo escrito
            else if(rtbTexto.Lines.Length > 0)
            {
                //Caso tenha algo escrito, pergunta se deseja salvar as alterações feitas
                DialogResult salvar = MessageBox.Show("Deseja salvar as alterações?", "Editor de Texto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (salvar == DialogResult.Yes)
                {
                    salvarArquivo(e);
                }
                else if (salvar == DialogResult.Cancel) 
                {
                    e.Cancel = true;
                }        
            }            
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir();
        }

        public void abrir()
        {
            //Se já houver algo escrito no Rich Text Box ele abrirá o arquivo em um novo Form            
            if (rtbTexto.Lines.Length > 0)
            {
                Thread novo = new Thread(novoForm);
                novo.Start();
            }
            //Senão "escreve o arquivo no Rich Text Box do Form atual"
            else
            {
                abrirArquivo(this);
            }            
        }

        public void abrirArquivo(frmEditorDeTexto novo)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = formatos;

            if (abrir.ShowDialog(novo) == DialogResult.OK)
            {
                //Verifica se a extensão selecionada foi .rtf
                if (Path.GetExtension(abrir.FileName) == ".rtf")
                {
                    //Carregar o texto do arquivo a ser aberto no Rich Text Box
                    novo.rtbTexto.LoadFile(abrir.FileName);

                }

                //Verifica se a extensão selecionada foi .txt
                else if (Path.GetExtension(abrir.FileName) == ".txt")
                {
                    novo.rtbTexto.Text = "";

                    StreamReader sr = new StreamReader(abrir.FileName, Encoding.GetEncoding(28591));

                    string InputLine = "";

                    //Copia cada linha do texto do aquivo a ser aberto para o Rich Text Box
                    while ((InputLine = sr.ReadLine()) != null)
                    {
                        rtbTexto.Text += InputLine + "\n";
                    }

                    sr.Close();
                }

                nomeArquivo = abrir.FileName;
                novo.Show();                
            }
        }

        private void toolStripNovo_Click(object sender, EventArgs e)
        {
            Thread novo = new Thread(novoForm);
            novo.Start();
        }

        private void toolStripAbrir_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void toolStripSalvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(nomeArquivo)) 
            {
                reescrever();
            }
            else
            {
                salvarArquivo();
            }
        }

        public void reescrever()
        {
            File.Delete(nomeArquivo);

            if (Path.GetExtension(nomeArquivo) == ".rtf")
            {
                rtbTexto.SaveFile(nomeArquivo);
            }
            else
            {
                StreamWriter sw = new StreamWriter(nomeArquivo + ".txt");

                for (int linha = 0; linha < rtbTexto.Lines.Length; linha++)
                {
                    sw.WriteLine(rtbTexto.Lines[linha]);
                }

                sw.Close();
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(nomeArquivo))
            {
                reescrever();
            }
            else
            {
                salvarArquivo();
            }
        }

        private void rtbTexto_MouseDown(object sender, MouseEventArgs e)
        {
            MouseButtons mouse = e.Button;
            if (mouse == MouseButtons.Right)
            {                
                ToolStripDropDownMenu opcoes = new ToolStripDropDownMenu();
                opcoes.Items.Add("Negrito");
                opcoes.Items.Add("Sublinhado");
                opcoes.Items.Add("Itálico");
                opcoes.Show(MousePosition);

            }     
        }        

        private void toolStripProximo_Click(object sender, EventArgs e)
        { 
            //Seleciona as strings que foram encontradas na busca
            if(aux <= busca.numMatch - 1)
            {
                rtbTexto.Select(busca.resultado[aux], toolStripProcura.Text.Length);
                aux++;
            }
            else
            {
                rtbTexto.Select(busca.resultado[0], toolStripProcura.Text.Length);
                aux = 1;
            }
        }

        private void forçaBrutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busca = new ForcaBruta(rtbTexto.Text,toolStripProcura.Text);
            infoBusca(busca);

            metodoBusca = 1;
        }

        public void infoBusca(Busca busca)
        {
            if (analiseDesempenho)
            {
                rtbTexto.Select();
                rtbTexto.Select(busca.resultado[0], toolStripProcura.Text.Length);
                infoStripBuscaLabel.Text = string.Format("{0} encontrado(s)", busca.numMatch);
                toolStripBuscaTempo.Text = "";
            }     
            else if (busca.numMatch == 0)
            {
                MessageBox.Show("Não há resultados", "Procura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                toolStripProximo.Visible = false;
                infoStripBuscaLabel.Text = "Nenhum resultado encontrado";
                toolStripBuscaTempo.Text = "";
            }
            else
            {
                rtbTexto.Select();
                rtbTexto.Select(busca.resultado[0], toolStripProcura.Text.Length);
                toolStripProximo.Visible = true;
                infoStripBuscaLabel.Text = string.Format("{0} encontrado(s)", busca.numMatch);
                toolStripBuscaTempo.Text = busca.tempoGasto + " µs";
            }
        }

        private void bMSearchBoyerMooreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tamanhoVetor = (rtbTexto.Text.Length < 100) ? 256 : 8249;

            busca = new BMSearch(rtbTexto.Text, toolStripProcura.Text, tamanhoVetor);
            infoBusca(busca);
            metodoBusca = 2;
        }

        private void toolStripSplitBusca_ButtonClick(object sender, EventArgs e)
        {
            if (metodoBusca == 1)
            {
                busca = new ForcaBruta(rtbTexto.Text, toolStripProcura.Text);
                infoBusca(busca);
            }
            else if (metodoBusca == 2)
            {
                int tamanhoVetor = (rtbTexto.Text.Length < 100) ? 256 : 8249;

                busca = new BMSearch(rtbTexto.Text, toolStripProcura.Text, tamanhoVetor);
                infoBusca(busca);
            }
            else
            {
                int tamanhoVetor = (rtbTexto.Text.Length < 100) ? 256 : 8249;

                busca = new BMSearch(rtbTexto.Text, toolStripProcura.Text, tamanhoVetor);
                infoBusca(busca);
            }
        }

        private void análiseDeDesempenhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProcura.Text == "")
            {
                MessageBox.Show("Gentileza insira o texto que deseja buscar para medir o desempenho.", "Análise de Desempenho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int tamanhoVetor = (rtbTexto.Text.Length < 100) ? 256 : 8249;

                Busca forca = new ForcaBruta(rtbTexto.Text, toolStripProcura.Text);
                Busca bm = new BMSearch(rtbTexto.Text, toolStripProcura.Text, tamanhoVetor);

                busca = bm;

                analiseDesempenho = true;

                calculaDifTempo(forca, bm);

                analiseDesempenho = false;
            }            
        }       
        
        public void calculaDifTempo(Busca forca, Busca bm)
        {
            string mostraTempo = string.Format("Tempo de execução do algoritmo de Força Bruta: {0} µs\nTempo de execução do algoritmo BM(Boyer-Moore): {1} µs\n", forca.tempoGasto, bm.tempoGasto);
            double dif = forca.tempoGasto - bm.tempoGasto;

            

            if (bm.numMatch > 0)
            {
                infoBusca(forca);
                MessageBox.Show(string.Format("{0}Diferença de tempo de execução: {1} µs", mostraTempo, dif), "Análise de Desempenho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripProximo.Visible = true;
            }
            else
            {
                MessageBox.Show("Não houve resultados do texto desejado.", "Análise de Desempenho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                toolStripProximo.Visible = false;
            }
        }
    }
}