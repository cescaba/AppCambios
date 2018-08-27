using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary
{
    public static class VariablesConexion
    {
       //public static string ambiente = "DEV";
       public static string ambiente = "PRD";

        //conexion prd

        public static string cadenaConexion = "Server=10.11.23.68;Database=bdgestcambio_dev; Uid=gest_admin;Pwd=CAR4v3lla$$;Convert Zero Datetime=True";

        //conexion dev


        //public static string cadenaConexion = "Server=10.11.23.68;Database=bdgestcambio_desarrollo; Uid=gest_admin;Pwd=CAR4v3lla$$;Convert Zero Datetime=True";

        //conexion dev
        /*public static string cadenaConexion = "user id=gest_admin;" +
                                     "Pwd=Prueba123;server=corcpu1401.grupocogesa.gromero.net;" +
                                     "Trusted_Connection=yes;" +
                                     "database=Dev_Tickets_CA; " +
                                     "connection timeout=150";

        */
        // conexion PRD
        /*public static string cadenaConexion = "user id=gest_admin;" +
                                         "Pwd=Prueba123;server=corcpu1401.grupocogesa.gromero.net;" +
                                         "Trusted_Connection=yes;" +
                                         "database=Tickets_CA; " +
                                         "connection timeout=150";
 */
        



    }
}
