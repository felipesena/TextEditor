using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EditorDeTexto
{
    public class BMSearch : Busca
    {
        public void Buscar(string str, string busca, int tamanhoVetor)
        {
            List<int> resultado = new List<int>();
            int m = busca.Length;
            int n = str.Length;

            int[] caracterErrado = new int[tamanhoVetor];            

            Busca.desempenho.Start();

            CaracterErradoHeuristica(busca, m, ref caracterErrado);

            int s = 0;
            while (s <= (n - m))
            {
                int j = m - 1;

                while (j >= 0 && busca[j] == str[s + j])
                {
                    --j;
                }

                if (j < 0)
                {
                    resultado.Add(s);
                    s += (s + m < n) ? m - caracterErrado[str[s + m]] : 1;
                }
                else
                {
                    s += Math.Max(1, j - caracterErrado[str[s + j]]);
                }
            }

            Busca.desempenho.Stop();

            this.resultado = resultado.ToArray();
            this.numMatch = resultado.Count;
            this.tempoGasto = Busca.desempenho.Elapsed.TotalMilliseconds * 1000;

            Busca.desempenho.Reset();
        }        

        protected static void CaracterErradoHeuristica(string busca, int tamanho, ref int[] badChar)
        {
            int i;

            for (i = 0; i < badChar.Length; i++)
            {
                badChar[i] = -1;
            }

            for (i = 0; i < tamanho; i++)
            {
                badChar[busca[i]] = i;
            }
        }
    }
}