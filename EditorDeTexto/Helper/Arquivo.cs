using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using EditorDeTexto.Helper;

namespace EditorDeTexto
{
    public class Arquivo
    {
        //Filtro de formatos a serem salvos e lidos
        private static string formatos = "Formato Rich Text |*.rtf|Texto sem formatação |*.txt*";

        private static SaveFileDialog salvar;
        private static DialogResult result;
        
        private static string path;
        private static RichTextBox conteudoArq;
        private static Fonte fonte;

        public static void CriaDocumento(ref RichTextBox richTextBox)
        {
            conteudoArq = richTextBox;
            fonte = new Fonte(richTextBox.SelectionFont, richTextBox.SelectionAlignment);
            path = "";            
        }

        public static void AlinharAEsquerda()
        {
            conteudoArq.SelectionAlignment = fonte.AlinharAEsquerda();
        }

        public static void AlinharADireita()
        {
            conteudoArq.SelectionAlignment = fonte.AlinharADireita();
        }

        public static void Centralizar()
        {
            conteudoArq.SelectionAlignment = fonte.Centralizar();
        }

        public static void Negrito()
        {
            fonte = fonte.ColocarNegrito();
            conteudoArq.SelectionFont = fonte.Font;
        }

        public static void Italico()
        {
            fonte = fonte.ColocarItalico();
            conteudoArq.SelectionFont = fonte.Font;
        }

        public static void Sublinhado()
        {
            fonte = fonte.ColocarSublinhado();
            conteudoArq.SelectionFont = fonte.Font;
        }

        public static void SalvarArquivo(FormClosingEventArgs e)
        {
            salvar = new SaveFileDialog();
            salvar.Filter = formatos;
            salvar.Title = "Salvar arquivo de texto";

            result = salvar.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (salvar.FilterIndex == 1)
                {
                    conteudoArq.SaveFile(salvar.FileName);
                }
                else if (salvar.FilterIndex == 2)
                {
                    StreamWriter sw = new StreamWriter(salvar.FileName + ".txt");

                    for (int i = 0; i < conteudoArq.Lines.Length; i++)
                    {
                        sw.WriteLine(conteudoArq.Lines[i]);
                    }

                    sw.Close();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        public static void Salvar()
        {
            if (File.Exists(path))
            {
                Reescrever();
            }
            else
            {
                SalvarArquivo();
            }
        }

        public static void Reescrever()
        {
            File.Delete(path);

            if (Path.GetExtension(path) == ".rtf")
            {
                conteudoArq.SaveFile(path);
            }
            else
            {
                StreamWriter sw = new StreamWriter(path + ".txt");

                for (int linha = 0; linha < conteudoArq.Lines.Length; linha++)
                {
                    sw.WriteLine(conteudoArq.Lines[linha]);
                }

                sw.Close();
            }
        }

        public static void FoiSalvo(ref FormClosingEventArgs e)
        {
            if (File.Exists(path))
            {
                frmEditorDeTexto verificacao = new frmEditorDeTexto();

                if (Path.GetExtension(path) == ".rtf")
                {
                    //Carregar o texto do arquivo a ser aberto no Rich Text Box
                    verificacao.rtbTexto.LoadFile(path);
                }
                //Verifica se a extensão selecionada foi .txt
                else if (Path.GetExtension(path) == ".txt")
                {
                    verificacao.rtbTexto.Text = "";

                    StreamReader sr = new StreamReader(path, Encoding.GetEncoding(28591));

                    string InputLine = "";

                    //Copia cada linha do texto do aquivo a ser aberto para o Rich Text Box
                    while ((InputLine = sr.ReadLine()) != null)
                    {
                        verificacao.rtbTexto.Text += InputLine + "\n";
                    }

                    sr.Close();
                }

                if (verificacao.rtbTexto.Text != conteudoArq.Text)
                {
                    result = MessageBox.Show("Deseja salvar as alerações?", "Editor de Texto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        Reescrever();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
            //Verifica na hora de fechar o arquivo se há algo escrito
            else if (conteudoArq.Lines.Length > 0)
            {
                //Caso tenha algo escrito, pergunta se deseja salvar as alterações feitas
                DialogResult salvar = MessageBox.Show("Deseja salvar as alterações?", "Editor de Texto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (salvar == DialogResult.Yes)
                {
                    SalvarArquivo(e);
                }
                else if (salvar == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        public static void SalvarArquivo()
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
                    conteudoArq.SaveFile(salvar.FileName);
                }
                //Caso o formato selecionado seja o .txt
                else
                {
                    StreamWriter sw = new StreamWriter(salvar.FileName + ".txt");

                    for (int linha = 0; linha < conteudoArq.Lines.Length; linha++)
                    {
                        sw.WriteLine(conteudoArq.Lines[linha]);
                    }

                    sw.Close();
                }

                path = salvar.FileName;
            }
        }

        public static void AbrirArquivo(frmEditorDeTexto novo)
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
                        conteudoArq.Text += InputLine + "\n";
                    }

                    sr.Close();
                }

                path = abrir.FileName;
                novo.Show();
            }
        }

        public static void Abrir(frmEditorDeTexto editor)
        {
            //Se já houver algo escrito no Rich Text Box ele abrirá o arquivo em um novo Form            
            if (conteudoArq.Lines.Length > 0)
            {
                frmEditorDeTexto novo = new frmEditorDeTexto();
                AbrirArquivo(novo);
            }
            //Senão "escreve o arquivo no Rich Text Box do Form atual"
            else
            {
                AbrirArquivo(editor);
            }
        }

    }
}
