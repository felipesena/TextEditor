using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto.Helper
{
    public class Fonte
    {
        private Font _fonte;

        public Font Font
        {
            get
            {
                return _fonte;
            }
            set
            {
                _fonte = value;
            }
        }

        private HorizontalAlignment alinhamento;

        public Fonte(Font fonte, HorizontalAlignment alinhamento)
        {
            this.alinhamento = alinhamento;
            this.Font = fonte;
        }

        public HorizontalAlignment AlinharAEsquerda()
        {
            return HorizontalAlignment.Left;
        }    
        
        public HorizontalAlignment Centralizar()
        {
            return HorizontalAlignment.Center;
        }

        public HorizontalAlignment AlinharADireita()
        {
            return HorizontalAlignment.Right;
        }

        public Fonte ColocarSublinhado()
        {
            FontStyle novaFontStyle;

            //Verificação os estilos que tem a fonte atual
            bool sublinhado = Font.Underline;
            bool negrito = Font.Bold;
            bool italico = Font.Italic;

            if (sublinhado)
            {
                if (negrito && italico)
                {
                    novaFontStyle = FontStyle.Bold | FontStyle.Italic;
                }
                else if (negrito)
                {
                    novaFontStyle = FontStyle.Bold;
                }
                else if (italico)
                {
                    novaFontStyle = FontStyle.Italic;
                }
                else
                {
                    novaFontStyle = FontStyle.Regular;
                }
            }
            else
            {
                if (negrito && italico)
                {
                    novaFontStyle = FontStyle.Underline | FontStyle.Bold | FontStyle.Italic;
                }
                else if (negrito)
                {
                    novaFontStyle = FontStyle.Underline | FontStyle.Bold;
                }
                else if (italico)
                {
                    novaFontStyle = FontStyle.Underline | FontStyle.Italic;
                }
                else
                {
                    novaFontStyle = FontStyle.Underline;
                }
            }

            return new Fonte(new Font(Font.FontFamily, Font.Size, novaFontStyle), alinhamento);
        }

        public Fonte ColocarItalico()
        {
            FontStyle novaFontStyle;

            //Verificação os estilos que tem a fonte atual
            bool italico = Font.Italic;
            bool sublinhado = Font.Underline;
            bool negrito = Font.Bold;

            if (italico)
            {
                if (negrito && sublinhado)
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
                if (negrito && sublinhado)
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


            return new Fonte(new Font(Font.FontFamily, Font.Size, novaFontStyle), alinhamento);
        }

        public Fonte ColocarNegrito()
        {
            FontStyle novaFontStyle;

            //Verificação os estilos que tem a fonte atual
            bool negrito = Font.Bold;
            bool italico = Font.Italic;
            bool sublinhado = Font.Underline;

            if (negrito)
            {
                if (italico && sublinhado)
                {
                    novaFontStyle = FontStyle.Italic | FontStyle.Underline;
                }
                else if (italico)
                {
                    novaFontStyle = FontStyle.Italic;
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
                if (italico && sublinhado)
                {
                    novaFontStyle = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
                }
                else if (italico)
                {
                    novaFontStyle = FontStyle.Bold | FontStyle.Italic;
                }
                else if (sublinhado)
                {
                    novaFontStyle = FontStyle.Bold | FontStyle.Underline;
                }
                else
                {
                    novaFontStyle = FontStyle.Bold;
                }
            }


            return new Fonte(new Font(Font.FontFamily, Font.Size, novaFontStyle), alinhamento);
        }
    }
}
