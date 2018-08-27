using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.DTO
{
    public class DTOUsuario
    {
        private int? idUsuario = null;
        private string nombre = null;
        private string password = null;
        private string rol = null;
        private string correo = null;

        public int? IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }


    }
}
