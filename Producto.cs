using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PrototypeModel.Models
{
    public class Producto
    {
        private int _Id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Codigo;
        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private int _IdCategoria;
        public int IdCategoria
        {
            get { return _IdCategoria; }
            set { _IdCategoria = value; }
        }

        private string _CategoriaNombre;
        public string CategoriaNombre
        {
            get { return _CategoriaNombre; }
            set { _CategoriaNombre = value; }
        }

        private double _Precio;
        public double Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        private string _Imagen;
        public string Imagen
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }




    }
}
