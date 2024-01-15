using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Venta
    {
        private int _id;
        private string _Comentarios;
        private int _IdUsuarios;

        public Venta()

        {
            _id = 0;
            _Comentarios = string.Empty;
            _IdUsuarios = 0;
        }
        public Venta(int Id, string Comentarios, int IdUsuarios)
        {
            this._id = Id;
            this._Comentarios = Comentarios;
            this._IdUsuarios = IdUsuarios;
        }
        public int Id
        {
            get { return _id; }

            set { this._id = value; }
        }
        public string Comentarios
        {
            get { return _Comentarios; }

            set { this._Comentarios = value; }
        }
        public int IdUsuarios
        {
            get { return _IdUsuarios; }

            set { this._IdUsuarios = value; }
        }
    }
}