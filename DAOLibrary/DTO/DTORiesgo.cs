using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.DTO
{
    public class DTORiesgo
    {
        private int? rfc;
        private int codigo;
        private string titulo;
        private int impacto;


        public int Impacto
        {
            get { return impacto; }
            set { impacto = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int? Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }
    }
}
