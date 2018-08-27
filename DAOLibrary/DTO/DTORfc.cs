using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.DTO
{
    public class DTORfc
    {
        private int? codigo;
        private string estado =null; 
        private DateTime fecaceptacion = new DateTime(1900,01,01,00,00,00);
        private string nomaceptador = null;
        private string prioridad = null;
        private string categoria = null;
        private string tipocambio_normal = null;
        private string ejecutornombre = null;
        private string ejecutorequipo = null;
        private string coordinador = null;
        private string coordinadorequipo = null;
        private string codatenciontercero = null;
        private int indisponibilidad = -1;
        private string depencambioidentificado = null;
        private string personasacomunicar = null;
        private DateTime fecaprobacion = new DateTime(1900, 01, 01, 00, 00, 00);
        private string aprobador = null;
        private DateTime fecrechazo = new DateTime(1900, 01, 01, 00, 00, 00);
        private string razonrechazo = null;
        private DateTime fecprogramadaejecucion = new DateTime(1900, 01, 01, 00, 00, 00);
        private DateTime fecprogramadafinalizacion = new DateTime(1900, 01, 01, 00, 00, 00);
        private DateTime fecharealejecucion = new DateTime(1900, 01, 01, 00, 00, 00);
        private DateTime fecharealfinalizacion = new DateTime(1900, 01, 01, 00, 00, 00);
        private int rollback = -1;
        private DateTime fecrollback = new DateTime(1900, 01, 01, 00, 00, 00);
        private string autorizarollback = null;
        private int prueba = -1;
        private int conformidadPrueba = -1;
        private DateTime fecrevisionfinal = new DateTime(1900, 01, 01, 00, 00, 00);
        private string revisador = null;
        private int cambiosatifactorio = -1;
        private string detalrevision = null;
        private int volvioprocedimiento = -1;
        private string rutaplan = null;
        private int planTrabajo = -1;
        private int planPruebas = -1;
        private int planContigencia = -1;
        private DateTime feccierre = new DateTime(1900, 01, 01, 00, 00, 00);
        private DateTime feccomite = new DateTime(1900, 01, 01, 00, 00, 00);
        private string incidenteseje = null;
        private string incidenteprue = null;
        private string cateinfra = null;
        private string cod_bau = null;
        private string tipocambio = null;
        private int probfalla = -1;
        private string correo_aprobacion = null;
        private string tipo_finalizacion = null;
        private string motivo = null;

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        public string Tipo_finalizacion
        {
            get { return tipo_finalizacion; }
            set { tipo_finalizacion = value; }
        }

        public string Correo_aprobacion
        {
            get { return correo_aprobacion; }
            set { correo_aprobacion = value; }
        }


        public string Cateinfra
        {
            get { return cateinfra; }
            set { cateinfra = value; }
        }

        public int Probfalla
        {
            get { return probfalla; }
            set { probfalla = value; }
        }

        public string Incidenteprue
        {
            get { return incidenteprue; }
            set { incidenteprue = value; }
        }

        public string Incidenteseje
        {
            get { return incidenteseje; }
            set { incidenteseje = value; }
        }


        public DateTime Fecharealfinalizacion
        {
            get { return fecharealfinalizacion; }
            set { fecharealfinalizacion = value; }
        }
        public DateTime Fecharealejecucion
        {
            get { return fecharealejecucion; }
            set { fecharealejecucion = value; }
        }
        public DateTime Fecrollback
        {
            get { return fecrollback; }
            set { fecrollback = value; }
        }
        public int Rollback
        {
            get { return rollback; }
            set { rollback = value; }
        }

        public DateTime Fecprogramadafinalizacion
        {
            get { return fecprogramadafinalizacion; }
            set { fecprogramadafinalizacion = value; }
        }
        public DateTime Fecprogramadaejecucion
        {
            get { return fecprogramadaejecucion; }
            set { fecprogramadaejecucion = value; }
        }
        public string Razonrechazo
        {
            get { return razonrechazo; }
            set { razonrechazo = value; }
        }
     

        public string Autorizarollback
        {
            get { return autorizarollback; }
            set { autorizarollback = value; }
        }


        public int Prueba
        {
            get { return prueba; }
            set { prueba = value; }
        }
    
        public int ConformidadPrueba
        {
            get { return conformidadPrueba; }
            set { conformidadPrueba = value; }
        }
        

        public DateTime Fecrevisionfinal
        {
            get { return fecrevisionfinal; }
            set { fecrevisionfinal = value; }
        }

        public string Revisador
        {
            get { return revisador; }
            set { revisador = value; }
        }


        public int Cambiosatifactorio
        {
            get { return cambiosatifactorio; }
            set { cambiosatifactorio = value; }
        }

        public string Detalrevision
        {
            get { return detalrevision; }
            set { detalrevision = value; }
        }

        public int Volvioprocedimiento
        {
            get { return volvioprocedimiento; }
            set { volvioprocedimiento = value; }
        }
        
        public string Rutaplan
        {
            get { return rutaplan; }
            set { rutaplan = value; }
        }

        public int PlanTrabajo
        {
            get { return planTrabajo; }
            set { planTrabajo = value; }
        }

        public int PlanPruebas
        {
            get { return planPruebas; }
            set { planPruebas = value; }
        }
        
        public int PlanContigencia
        {
            get { return planContigencia; }
            set { planContigencia = value; }
        }
      
        public DateTime Feccierre
        {
            get { return feccierre; }
            set { feccierre = value; }
        }


        public DateTime Feccomite
        {
            get { return feccomite; }
            set { feccomite = value; }
        }

        public int? Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }
        public string Nomaceptador
        {
            get { return nomaceptador; }
            set { nomaceptador = value; }
        }
        public DateTime Fecaceptacion
        {
            get { return fecaceptacion; }
            set { fecaceptacion = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Ejecutorequipo
        {
            get { return ejecutorequipo; }
            set { ejecutorequipo = value; }
        }
        public string Ejecutornombre
        {
            get { return ejecutornombre; }
            set { ejecutornombre = value; }
        }

        public string Tipocambio
        {
            get { return tipocambio; }
            set { tipocambio = value; }
        }
        public string Tipocambio_normal
        {
            get { return tipocambio_normal; }
            set { tipocambio_normal = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string Coordinador
        {
            get { return coordinador; }
            set { coordinador = value; }
        }
        public string Coordinadorequipo
        {
            get { return coordinadorequipo; }
            set { coordinadorequipo = value; }
        }
        public DateTime Fecrechazo
        {
            get { return fecrechazo; }
            set { fecrechazo = value; }
        }

        public string Aprobador
        {
            get { return aprobador; }
            set { aprobador = value; }
        }
        public DateTime Fecaprobacion
        {
            get { return fecaprobacion; }
            set { fecaprobacion = value; }
        }
        public string Personasacomunicar
        {
            get { return personasacomunicar; }
            set { personasacomunicar = value; }
        }

        public string Depencambioidentificado
        {
            get { return depencambioidentificado; }
            set { depencambioidentificado = value; }
        }

        public int Indisponibilidad
        {
            get { return indisponibilidad; }
            set { indisponibilidad = value; }
        }

        public string Codatenciontercero
        {
            get { return codatenciontercero; }
            set { codatenciontercero = value; }
        }

        public string Cod_bau
        {
            get { return cod_bau; }
            set { cod_bau = value; }
        }
    }
}
