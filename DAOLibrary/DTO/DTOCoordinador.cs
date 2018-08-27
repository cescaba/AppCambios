using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.DTO
{
    public class DTOCoordinador
    {

        private int? idCoordinador = null;
        private string nombre = null;
        private string area = null;

        public int? IdCoordinador
        {
            get { return idCoordinador; }
            set { idCoordinador = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Area
        {
            get { return area; }
            set { area = value; }
        }
    }
}
