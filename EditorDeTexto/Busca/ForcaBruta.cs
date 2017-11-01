using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorDeTexto
{
    public class ForcaBruta : Busca
    {
        public void Buscar(string texto, string busca)
        {
            List<int> resultados = new List<int>();

            int n = texto.Length;
            int m = busca.Length;

            desempenho.Start();

            for (int i = 0; i <= n - m; i++)
            {
                int j = 0;
                while (j < m && busca[j] == texto[i + j])
                {
                    j++;
                }
                if (j == m)
                    resultados.Add(i);
            }

            desempenho.Stop();

            this.resultado = resultados.ToArray();
            this.numMatch = resultados.Count;
            this.tempoGasto = desempenho.Elapsed.TotalMilliseconds * 1000;

            desempenho.Reset();
        }
    }
}