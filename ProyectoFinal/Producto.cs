using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Producto
    {
        private int _id;
        private string _drescripcion;
        private double _costo;
        private double _precioVenta;
        private int _stock;
        private int _idUsuario;
   
         public Producto()
        {
            _id = 0;
            _drescripcion = string.Empty;
            _costo = 0;
            _precioVenta = 0;
            _stock = 0;
            _idUsuario = 0;

        }
        public Producto(int Id, string Drescripcion, int Costo, int PrecioVenta, int Stock, int IdUsuario)
        {
            this._id = Id;
            this._drescripcion = Drescripcion;
            this._costo = Costo;
            this._precioVenta = PrecioVenta;
            this._stock = Stock;
            this._idUsuario = IdUsuario;
        }
        public int Id
        {
            get { return _id; }
            set { this._id = value; }
        }
        public string Drescripcion
        {
            get { return _drescripcion; }
            set { this._drescripcion = value; }
        }
        public double Costo
        {
            get { return _costo; }
            set { this._costo = value; }
        }
        public double PrecioVenta
        {
            get { return _precioVenta; }
            set { this._precioVenta = value; }
        }
        public int Stock
        {
            get { return _stock; }
            set { this._stock = value; }
        }
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { this._idUsuario = value; }
        }
    }
}
