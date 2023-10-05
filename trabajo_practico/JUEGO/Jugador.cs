using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    public class Jugador
    {
        private int _id;
        public int Id
        {
            get { return _id; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
        }

        private TablaPuntos _puntaje;
        public TablaPuntos Puntaje
        {
            get { return _puntaje; }
        }

        private int _tiros;
        public int Tiros
        {
            get { return _tiros; }
        }

        public Jugador(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }

        public void TirarDados(List<Dado> dados)
        {
            dados.ForEach(dado => dado.Tirar());
            _tiros--;
        }

        public void ApartarDados(List<Dado> dados)
        {

        }

        public void EstablecerTiros()
        {
            _tiros = 3;
        }

        public void CerrarCategoria()
        {

        }
    }
}
