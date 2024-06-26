﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombreUsuario;
        public string Nombre
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _nick;
        public string Nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        private int _victorias;
        public int Victorias
        {
            get { return _victorias; }
            set { _victorias = value; }
        }

        private int _derrotas;
        public int Derrotas
        {
            get { return _derrotas; }
            set { _derrotas = value; }
        }

        private int _empates;
        public int Empates
        {
            get { return _empates; }
            set { _empates = value; }
        }
    }
}
