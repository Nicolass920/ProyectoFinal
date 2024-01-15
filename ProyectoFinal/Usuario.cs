using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contraseña;
        private string _mail;

        public Usuario()
        {
            _id = 0;
            _nombre = string.Empty;
            _apellido = string.Empty;
            _nombreUsuario = string.Empty;
            _contraseña = string.Empty;
            _mail = string.Empty;
        }

        public Usuario(int Id, string Nombre, string Apellido, string NombreUsuario,
            string Contraseña, string Mail)
        {
            this._id = Id;
            this._nombre = Nombre;
            this._apellido = Apellido;
            this._nombreUsuario = NombreUsuario;
            this._contraseña = Contraseña;
            this._mail = Mail;
        }

        public int Id
        {
            get { return _id; }
            set { this._id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { this._nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { this._apellido = value; }
        }

        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { this._nombreUsuario = value; }
        }

        public string Contraseña
        {
            get { return _contraseña; }
            set { this._contraseña = value; }
        }

        public string Mail
        {
            get { return _Mail; }
            set { this._Mail = value; }
        }
    }
}


