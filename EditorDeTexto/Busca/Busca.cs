using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EditorDeTexto
{
    public abstract class Busca
    {
        public int[] resultado { get; set; }
        public int numMatch { get; set; }
        public double tempoGasto { get; set; }        

        protected static Stopwatch desempenho = new Stopwatch();         
    }
}

