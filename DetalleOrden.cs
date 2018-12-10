using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PrototypeModel.Models
{
    public class DetalleOrden
    {
        private int _Id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _FechaHora;
        public string Fecha
        {
            get { return _FechaHora; }
            set { _FechaHora = value; }
        }

        private int _IdOrden;
        public int IdOrden
        {
            get { return _IdOrden; }
            set { _IdOrden = value; }
        }

        private int _IdProducto;
        public int ÏdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }

        private string _CodigoProducto;
        public string CodigoProducto
        {
            get { return _CodigoProducto; }
            set { _CodigoProducto = value; }
        }

        private string _NombreProducto;
        public string NombreProducto
        {
            get { return _NombreProducto; }
            set { _NombreProducto = value; }
        }

        private double _Precio;
        public double Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        private int _Cantidad;
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        private double _SubTotal;
        public double SubTotal
        {
            get { return _SubTotal; }
            set { _SubTotal = value; }
        }


    }
}
