using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class ProductoVendido
    {   
        private int _Id;
        private string _IdProducto;
        private int _Stock;
        private int _IdVenta;

        public ProductoVendido() { 
            _Id = 0;
            _IdProducto = string.Empty;
            _Stock = 0;
            _IdVenta = 0;

        }
        public ProductoVendido(int Id, string IdProducto, int Stock, int IdVenta)
        {
            this._Id = Id;
            this._IdProducto = IdProducto;
            this._Stock = Stock;
            this._IdVenta = IdVenta;
        }
        public int Id
        {
            get { return _Id; }
            set { this._Id = value; }
        }
        public string IdProducto
        {
            get { return _IdProducto; }
            set { this._IdProducto = value; }
        }
        public int Stock
        {
            get { return _Stock; }
            set { this._Stock = value; }
        }
        public int IdVenta
        {
            get { return _IdVenta; }
            set { this._IdVenta = value; }
        }
    }
}
