using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cubilete
    {
        public void PonerDados(BE.Cubilete cubilete, List<BE.Dado> dados)
        {
            dados.ForEach(dado => cubilete.Dados.Add(dado));
            cubilete.Vacio = false;
        }

        public void TirarDados(BE.Cubilete cubilete)
        {
            cubilete.Dados.ForEach(dado => Dado.Tirar(dado));
        }
    }
}
