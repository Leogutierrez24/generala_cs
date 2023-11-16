using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cubilete
    {
        public static void PonerDados(BE.Cubilete cubilete, List<BE.Dado> dados)
        {
            dados.ForEach(dado => cubilete.Dados.Add(dado));
            cubilete.Vacio = false;
        }

        public static List<BE.Dado> TirarDados(BE.Cubilete cubilete)
        {
            cubilete.Dados.ForEach(dado => Dado.Tirar(dado));
            List<BE.Dado> dadosObtenidos = cubilete.Dados;
            cubilete.Dados.Clear();
            cubilete.Vacio = true;
            return dadosObtenidos;
        }
    }
}
