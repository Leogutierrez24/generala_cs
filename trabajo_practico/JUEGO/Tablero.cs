using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class Tablero
    {
        private List<Dado> _dadosEnTablero = new List<Dado>();
        public List<Dado> DadosEnTablero
        {
            get { return _dadosEnTablero; }
        }

        private List<Dado> _dadosApartados = new List<Dado>();
        public List<Dado> DadosApartados
        {
            get { return _dadosApartados; }
        }

        private List<Dado> _dadosEnCubilete = new List<Dado>();
        public List<Dado> DadosEnCubilete
        {
            get { return _dadosEnCubilete; }
        }
        
        public Tablero(List<Dado> dados) 
        { 
            _dadosEnTablero = dados;
        }

        public void PonerDadosEnTablero(List<Dado> dados)
        {
            dados.ForEach(dado => _dadosEnTablero.Add(dado));
        }

        public void PonerDadosEnCubilete(List<Dado> dados)
        {
            dados.ForEach(dado => _dadosEnCubilete.Add(dado));
            _dadosEnCubilete.ForEach(dadoEnCubilete => _dadosEnTablero.Remove(dadoEnCubilete));
        }

        public void ApartarDados(List<Dado> dados)
        {
            dados.ForEach(dado => _dadosApartados.Add(dado));
            _dadosApartados.ForEach(dadoApartado => _dadosEnTablero.Remove(dadoApartado));
        }

        public void RestablecerDadosApartados()
        {
            while (_dadosApartados.Count != 0)
            {
                _dadosEnTablero.Add(_dadosApartados[0]);
                _dadosApartados.RemoveAt(0);
            }
        }
    }
}
