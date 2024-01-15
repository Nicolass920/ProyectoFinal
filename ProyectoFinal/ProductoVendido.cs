using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class ProductoVendido
    {   
        private int _id;
        private string _idProducto;
        private int _stock;
        private int _idVenta;

        public ProductoVendido() { 
            _id = 0;
            _idProducto = string.Empty;
            _stock = 0;
            _idVenta = 0;

        }
        public ProductoVendido(int Id, string IdProducto, int Stock, int IdVenta)
        {
            this._id = Id;
            this._idProducto = IdProducto;
            this._stock = Stock;
            this._idVenta = IdVenta;
        }
        public int Id
        {
            get { return _id; }
            set { this._id = value; }
        }
        public string IdProducto
        {
            get { return _idProducto; }
            set { this._idProducto = value; }
        }
        public int Stock
        {
            get { return _stock; }
            set { this._stock = value; }
        }
        public int IdVenta
        {
            get { return _idVenta; }
            set { this._idVenta = value; }
        }
    }
}
