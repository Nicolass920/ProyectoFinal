using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Usuario
    {
        private int _Id;
        private string _Nombre;
        private string _Apellido;
        private string _NombreUsuario;
        private string _Contraseña;
        private string _Mail;

        public Usuario()
        {
            _Id = 0;
            _Nombre = string.Empty;
            _Apellido = string.Empty;
            _NombreUsuario = string.Empty;
            _Contraseña = string.Empty;
            _Mail = string.Empty;
        }

        public Usuario(int Id, string Nombre, string Apellido, string NombreUsuario,
            string Contraseña, string Mail)
        {
            this._Id = Id;
            this._Nombre = Nombre;
            this._Apellido = Apellido;
            this._NombreUsuario = NombreUsuario;
            this._Contraseña = Contraseña;
            this._Mail = Mail;
        }

        public int Id
        {
            get { return _Id; }
            set { this._Id = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { this._Nombre = value; }
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { this._Apellido = value; }
        }

        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { this._NombreUsuario = value; }
        }

        public string Contraseña
        {
            get { return _Contraseña; }
            set { this._Contraseña = value; }
        }

        public string Mail
        {
            get { return _Mail; }
            set { this._Mail = value; }
        }
    }
}


