using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Producto
    {
        private int _Id;
        private string _Drescripcion;
        private int _Costo;
        private int _PrecioVenta;
        private int _Stock;
        private int _IdUsuario;
   
         public Producto()
        {
            _Id = 0;
            _Drescripcion = string.Empty;
            _Costo = 0;
            _PrecioVenta = 0;
            _Stock = 0;
            _IdUsuario = 0;

        }
        public Producto(int Id, string Drescripcion, int Costo, int PrecioVenta, int Stock, int IdUsuario)
        {
            this._Id = Id;
            this._Drescripcion = Drescripcion;
            this._Costo = Costo;
            this._PrecioVenta = PrecioVenta;
            this._Stock = Stock;
            this._IdUsuario = IdUsuario;
        }
        public int Id
        {
            get { return _Id; }
            set { this._Id = value; }
        }
        public string Drescripcion
        {
            get { return _Drescripcion; }
            set { this._Drescripcion = value; }
        }
        public int Costo
        {
            get { return _Costo; }
            set { this._Costo = value; }
        }
        public int PrecioVenta
        {
            get { return _PrecioVenta; }
            set { this._PrecioVenta = value; }
        }
        public int Stock
        {
            get { return _Stock; }
            set { this._Stock = value; }
        }
        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { this._IdUsuario = value; }
        }
    }
}
