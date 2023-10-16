using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class Cubilete
    {
        private List<Dado> _dados = new List<Dado>();
        public List<Dado> Dados 
        { 
            get { return _dados; }
        }

        private bool _vacio = false;
        public bool Vacio
        {
            get { return _vacio; }
        }

        public void PonerDados(List<Dado> dados)
        {
            dados.ForEach(dado => _dados.Add(dado));
            _vacio = false;
        }

        public List<Dado> TirarDados()
        {
            _dados.ForEach(dado => dado.Tirar());
            List<Dado> dadosTirados = _dados;
            _dados = new List<Dado>();
            _vacio = true;
            return dadosTirados;
        }
    }
}
