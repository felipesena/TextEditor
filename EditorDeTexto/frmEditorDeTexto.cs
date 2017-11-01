using System;
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
        //Vetor para receber os locais em que estão as strings encontradas no Rich Text
        public Busca busca;        

        //Variavel auxiliar utilizada na seleção das strings da busca
        int aux = 1;

        //Variavel para verificar qual metodo foi usado por ultimo
        int metodoBusca;

        bool analiseDesempenho;

        public frmEditorDeTexto()
        {
            InitializeComponent();
            Arquivo.CriaDocumento(ref rtbTexto);
        }

        //Alinhar a esquerda
        private void toolStripEsquerda_Click(object sender, EventArgs e)
        {
            Arquivo.AlinharAEsquerda();         
        }

        //Centralizar
        private void toolStripCentro_Click(object sender, EventArgs e)
        {
            Arquivo.Centralizar();
        }

        //Alinhar a direita
        private void toolStripDireita_Click(object sender, EventArgs e)
        {
            Arquivo.AlinharADireita();
        }
        
        private void toolStripNegrito_Click(object sender, EventArgs e)
        {
            Arquivo.Negrito();
        }

        private void toolStripItalico_Click(object sender, EventArgs e)
        {
            Arquivo.Italico();
        }        

        private void toolStripSublinhado_Click(object sender, EventArgs e)
        {
            Arquivo.Sublinhado();
        }

                
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Thread paralela = new Thread(novoForm);
            paralela.SetApartmentState(ApartmentState.STA);
            paralela.Start();            
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arquivo.SalvarArquivo();
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
            Arquivo.FoiSalvo(ref e);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arquivo.Abrir(this);
        }              

        private void novoForm()
        {
            frmEditorDeTexto novo = new frmEditorDeTexto();
            novo.Show();
            Application.Run(novo);
        }

        private void toolStripNovo_Click(object sender, EventArgs e)
        {
            Thread paralela = new Thread(novoForm);
            paralela.SetApartmentState(ApartmentState.STA);
            paralela.Start();            
        }

        private void toolStripAbrir_Click(object sender, EventArgs e)
        {
            Arquivo.Abrir(this);
        }

        private void toolStripSalvar_Click(object sender, EventArgs e)
        {
            Arquivo.Salvar();
        }
        
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arquivo.Salvar();
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
            string texto, pesquisa;

            texto = rtbTexto.Text;
            pesquisa = toolStripProcura.Text;

            busca = new ForcaBruta();

            Thread forcaBruta = new Thread(() => ((ForcaBruta)busca).Buscar(texto, pesquisa));

            forcaBruta.Start();

            forcaBruta.Join();

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
                rtbTexto.DeselectAll();
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
            string texto, pesquisa;

            texto = rtbTexto.Text;
            pesquisa = toolStripProcura.Text;

            int tamanhoVetor = (rtbTexto.Text.Length < 100) ? 256 : 8249;

            busca = new BMSearch();

            Thread bmThread = new Thread(() => ((BMSearch)busca).Buscar(texto, pesquisa, tamanhoVetor));

            bmThread.Start();
            bmThread.Join();

            infoBusca(busca);

            metodoBusca = 2;
        }

        private void toolStripSplitBusca_ButtonClick(object sender, EventArgs e)
        {
            string texto, pesquisa;

            texto = rtbTexto.Text;
            pesquisa = toolStripProcura.Text;

            if (metodoBusca == 1)
            {
                busca = new ForcaBruta();

                Thread forcaBruta = new Thread(() => ((ForcaBruta)busca).Buscar(texto, pesquisa));

                forcaBruta.Start();

                forcaBruta.Join();
                infoBusca(busca);
            }
            else if (metodoBusca == 2)
            {
                int tamanhoVetor = (rtbTexto.Text.Length < 100) ? 256 : 8249;

                busca = new BMSearch();

                Thread bmThread = new Thread(() => ((BMSearch)busca).Buscar(texto, pesquisa, tamanhoVetor));

                infoBusca(busca);
            }
            else
            {
                int tamanhoVetor = (rtbTexto.Text.Length < 100) ? 256 : 8249;

                busca = new BMSearch();

                Thread bmThread = new Thread(() => ((BMSearch)busca).Buscar(texto, pesquisa, tamanhoVetor));

                infoBusca(busca);
            }
        }

        private void análiseDeDesempenhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string texto, pesquisa;

            texto = rtbTexto.Text;

            if (toolStripProcura.Text == "")
            {
                MessageBox.Show("Gentileza insira o texto que deseja buscar para medir o desempenho.", "Análise de Desempenho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pesquisa = toolStripProcura.Text;

                int tamanhoVetor = (rtbTexto.Text.Length < 100) ? 256 : 8249;

                Busca forca = new ForcaBruta();
                Busca bm = new BMSearch();

                Thread forcaBruta = new Thread(() => ((ForcaBruta)forca).Buscar(texto, pesquisa));
                Thread bmThread = new Thread(() => ((BMSearch)bm).Buscar(texto, pesquisa, tamanhoVetor));

                forcaBruta.Start();
                bmThread.Start();
                
                bmThread.Join();
                forcaBruta.Join();

                busca = bm;

                analiseDesempenho = true;

                CalculaDifTempo(forca, bm);

                analiseDesempenho = false;
            }            
        }

        private void CalculaDifTempo(Busca forca, Busca bm)
        {
            string mostraTempo = string.Format("Tempo de execução do algoritmo de Força Bruta: {0} µs\nTempo de execução do algoritmo BM(Boyer-Moore): {1} µs\n", forca.tempoGasto, bm.tempoGasto);
            double dif = forca.tempoGasto - bm.tempoGasto;

            if (bm.numMatch > 0)
            {
                infoBusca(forca);
                MessageBox.Show(string.Format("{0}Diferença de tempo de execução: {1} µs", mostraTempo, Math.Abs(dif)), "Análise de Desempenho", MessageBoxButtons.OK, MessageBoxIcon.Information);
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