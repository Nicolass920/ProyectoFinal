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
        private string _comentarios;
        private int _idUsuarios;

        public Venta()

        {
            _id = 0;
            _comentarios = string.Empty;
            _idUsuarios = 0;
        }
        public Venta(int Id, string Comentarios, int IdUsuarios)
        {
            this._id = Id;
            this._comentarios = Comentarios;
            this._idUsuarios = IdUsuarios;
        }
        public int Id
        {
            get { return _id; }

            set { this._id = value; }
        }
        public string Comentarios
        {
            get { return _comentarios; }

            set { this._comentarios = value; }
        }
        public int IdUsuarios
        {
            get { return _idUsuarios; }

            set { this._idUsuarios = value; }
        }
    }
}