using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PrototypeModel.Models
{
    public class Orden
    {
        private int _Id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _NumeroOrden;
        public int NumeroOrden
        {
            get { return _NumeroOrden; }
            set { _NumeroOrden = value; }
        }

        private string _Fecha;
        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        private string _EstadoOrden;
        public string EstadoOrden
        {
            get { return _EstadoOrden; }
            set { _EstadoOrden = value; }
        }

        private double _Total;
        public double Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        private int _NumeroMesa;
        public int NumeroMesa
        {
            get { return _NumeroMesa; }
            set { _NumeroMesa = value; }
        }

        private string _Cliente;
        public string Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }









    }
}
