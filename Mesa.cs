using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PrototypeModel.Models
{
    public class Mesa
    {
       
        private int _id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _mesa;
        public string MesaNombre
        {
            get { return _mesa; }
            set { _mesa = value; }
        }

        private string _area;
        public string Area
        {
            get { return _area; }
            set { _area = value; }
        }

        private int _IdMesero;
        public int IdMesero
        {
            get { return _IdMesero; }
            set { _IdMesero = value; }
        }

        private string _Mesero;
        public string Mesero
        {
            get { return _Mesero; }
            set { _Mesero = value; }
        }




    }
}
