using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.DTO
{
    public class DTOLogreprogramacion
    {
        private int? idLogReprogramacion = null;
        private int? codigo = null;
        private DateTime fecFinPosLogReprogramacion = new DateTime(1900, 01, 01, 00, 00, 00);
        private DateTime fecIniAntLogReprogramacion = new DateTime(1900, 01, 01, 00, 00, 00);
        private DateTime fecFinAntLogReprogramacion = new DateTime(1900, 01, 01, 00, 00, 00);
        private DateTime fecIniPosLogReprogramacion = new DateTime(1900, 01, 01, 00, 00, 00);
        private string motivoLogReprogramacion = null;

        public string MotivoLogReprogramacion
        {
            get { return motivoLogReprogramacion; }
            set { motivoLogReprogramacion = value; }
        }

        public int? IdLogReprogramacion
        {
            get { return idLogReprogramacion; }
            set { idLogReprogramacion = value; }
        }

        public int? Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        

        public DateTime FecIniAntLogReprogramacion
        {
            get { return fecIniAntLogReprogramacion; }
            set { fecIniAntLogReprogramacion = value; }
        }
        

        public DateTime FecFinAntLogReprogramacion
        {
            get { return fecFinAntLogReprogramacion; }
            set { fecFinAntLogReprogramacion = value; }
        }
        

        public DateTime FecIniPosLogReprogramacion
        {
            get { return fecIniPosLogReprogramacion; }
            set { fecIniPosLogReprogramacion = value; }
        }


        public DateTime FecFinPosLogReprogramacion
        {
            get { return fecFinPosLogReprogramacion; }
            set { fecFinPosLogReprogramacion = value; }
        }

    }
}
