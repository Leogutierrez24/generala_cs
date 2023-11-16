using System;
using BE;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Dado
    {
        public static BE.Dado CrearDado(int id)
        {
            BE.Dado dado = new BE.Dado();
            dado.Id = id;

            return dado;
        }

        public static void Tirar(BE.Dado dado)
        {
            Random valorAleatorio = Helper.random;
            dado.Valor = valorAleatorio.Next(1, 7);
        }

        public static void Restablecer(BE.Dado dado)
        {
            dado.Valor = 1;
        }
    }
}
