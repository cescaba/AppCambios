using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.DTO
{
    public class DTOEmpresa
    {
        private string idEmpresa = null;
        private string nomEmpresa = null;

        public string IdEmpresa
        {
            get { return idEmpresa; }
            set { idEmpresa = value; }
        }

        public string NomEmpresa
        {
            get { return nomEmpresa; }
            set { nomEmpresa = value; }
        }
    }
}
