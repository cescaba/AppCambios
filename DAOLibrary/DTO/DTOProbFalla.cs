using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.DTO
{
    public class DTOProbFalla
    {
        private int? codigo = null;
        private int? cod_reu_coor = null;
        private int? cod_pre_elabo = null;
        private int? cod_recu_ejecu = null;

        public int? Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int? Cod_reu_coor
        {
            get { return cod_reu_coor; }
            set { cod_reu_coor = value; }
        }

        public int? Cod_pre_elabo
        {
            get { return cod_pre_elabo; }
            set { cod_pre_elabo = value; }
        }

        public int? Cod_recu_ejecu
        {
            get { return cod_recu_ejecu; }
            set { cod_recu_ejecu = value; }
        }

    }
}
