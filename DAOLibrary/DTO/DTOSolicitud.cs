using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.DTO
{
     public class DTOSolicitud
    {
        private int? codigo = null;
        private DateTime fechsolicitud = new DateTime(1900, 01, 01, 00, 00, 00);
        private string nomsolicitante = null;
        private int areasolicitante = -1;
        private int origen = -1;
        private string codasociado = null;
        private string titulo = null;
        private int razon = -1;
        private int sociedadafectada = -1;
        private int pripropuesta = -1;
        private DateTime fecpropuesta = new DateTime(1900, 01, 01, 00, 00, 00);
        private string sisafectado = null;
        private int ambafectado = -1;
        private int impactoest = -1;
        private int indispropuesta = -1;
        private string areainvolucrada = null;
        private int reuprevia = -1;
        private string descambio = null;
        private string justcambio = null;
        private string criteriosaceptacion = null;
        private string correo = null;
        private string empresa = null;

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public int? Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public DateTime Fechsolicitud
        {
            get { return fechsolicitud; }
            set { fechsolicitud = value; }
        }    
        public string Nomsolicitante
        {
            get { return nomsolicitante; }
            set { nomsolicitante = value; }
        }

        public int Areasolicitante
        {
            get { return areasolicitante; }
            set { areasolicitante = value; }
        }

        public int Origen
        {
            get { return origen; }
            set { origen = value; }
        }

        public string Codasociado
        {
            get { return codasociado; }
            set { codasociado = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int Razon
        {
            get { return razon; }
            set { razon = value; }
        }

        public int Sociedadafectada
        {
            get { return sociedadafectada; }
            set { sociedadafectada = value; }
        }


        public int Pripropuesta
        {
            get { return pripropuesta; }
            set { pripropuesta = value; }
        }

        public DateTime Fecpropuesta
        {
            get { return fecpropuesta; }
            set { fecpropuesta = value; }

         }
                
        public string Sisafectado
        {
            get { return sisafectado; }
            set { sisafectado = value; }
        }
        public int Ambafectado
        {
            get { return ambafectado; }
            set { ambafectado = value; }
        }
        public int Impactoest
        {
            get { return impactoest; }
            set { impactoest = value; }
        }
        public int Indispropuesta
        {
            get { return indispropuesta; }
            set { indispropuesta = value; }
        }
          public string Areainvolucrada
        {
            get { return areainvolucrada; }
            set { areainvolucrada = value; }
        }
          public int Reuprevia
        {
            get { return reuprevia; }
            set { reuprevia = value; }
        }

          public string Descambio
          {
              get { return descambio; }
              set { descambio = value; }
          }

          public string Justcambio
          {
              get { return justcambio; }
              set { justcambio = value; }
          }

          public string Criteriosaceptacion
          {
              get { return criteriosaceptacion; }
              set { criteriosaceptacion = value; }
          }

          public DTOSolicitud()
          {

          }

    }
 }



