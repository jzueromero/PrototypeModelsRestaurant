using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PrototypeModel.Models
{
    public class Categoria
    {

        private int _id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _Categoria;
        public string CategoriaNombre
        {
            get { return _Categoria; }
            set { _Categoria = value; }
        }

        private string _ImagenCategoria;
        public string ImagenCategoria
        {
            get { return _ImagenCategoria; }
            set { _ImagenCategoria = value; }
        }




    }
}
