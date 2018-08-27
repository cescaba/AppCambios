using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DAOLibrary.DTO;

namespace DAOLibrary.DAO
{
    public class DAOLogreprogramacion
    {

        public int Insert(DTOLogreprogramacion log)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Insert into logreprogramacion(codigo,fecIniAntLogReprogramacion,fecFinAntLogReprogramacion,fecIniPosLogReprogramacion,fecFinPosLogReprogramacion,motivoLogReprogramacion) values(@codigo,@fecIniAntLogReprogramacion,@fecFinAntLogReprogramacion,@fecIniPosLogReprogramacion,@fecFinPosLogReprogramacion,@motivoLogReprogramacion);");

                Parametros.Add(new MySqlParameter("@codigo", (object)log.Codigo));
                Parametros.Add(new MySqlParameter("@fecIniAntLogReprogramacion", (object)log.FecIniAntLogReprogramacion));
                Parametros.Add(new MySqlParameter("@fecFinAntLogReprogramacion", (object)log.FecFinAntLogReprogramacion));
                Parametros.Add(new MySqlParameter("@fecIniPosLogReprogramacion", (object)log.FecIniPosLogReprogramacion));
                Parametros.Add(new MySqlParameter("@fecFinPosLogReprogramacion", (object)log.FecFinPosLogReprogramacion));
                Parametros.Add(new MySqlParameter("@motivoLogReprogramacion", (object)log.MotivoLogReprogramacion));


                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                orden.Connection.Open();
                int x = orden.ExecuteNonQuery();
                orden.Connection.Close();
                return x;

            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        private MySqlCommand ObtenerOrdenSql(string sentenciaSQL, ArrayList Parametros)
        {
            try
            {
                //MySqlConnection conexion = new MySqlConnection("Server=10.11.23.68;Database=bdgestcambio; Uid=gest_admin;Pwd=CAR4v3lla$$;");
                MySqlConnection conexion = new MySqlConnection(VariablesConexion.cadenaConexion);
                MySqlCommand orden = new MySqlCommand(sentenciaSQL, conexion);
                foreach (MySqlParameter p in Parametros)
                {
                    orden.Parameters.Add(p);
                }
                conexion.Close();
                return orden;
            }
            catch (Exception ex)
            {
                throw (ex);
            }



        }


    }
}
