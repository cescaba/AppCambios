using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DAOLibrary.DTO;
using System.Collections;

namespace DAOLibrary.DAO
{
   public class DAOCoordinador
    {
        public DataSet select(DTOCoordinador dto)
        {
            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select * From coordinador");
                if (dto == null)
                {
                    throw new NullReferenceException("DAOCoordinador.select(dto)");

                }
                if (dto.Nombre != null)
                {
                    Campos.Append("LOWER(nombre) = LOWER('" + dto.Nombre + "') AND ");
                    //Parametros.Add(new MySqlParameter("@nombre", (object)dto.Nombre));
                }
                if (dto.Area != null && dto.Area != "Mantenimiento" && dto.Area != "Salida en Vivo")
                {
                    Campos.Append("(LOWER(area) = LOWER('" + dto.Area + "') OR area = 'Todos') AND ");
                   // Parametros.Add(new MySqlParameter("@area", (object)dto.Area));
                }



                if (Campos.Length > 0)
                {
                    SQLString.Append(" WHERE ");
                    SQLString.Append(Campos.ToString().Substring(0, Campos.ToString().Length - 4));
                }
                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                MySqlDataAdapter da = new MySqlDataAdapter(orden);
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int Insert(DTOCoordinador nuevo)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Insert into Coordinador(nombre,area) values(@nombre,@area);");

                Parametros.Add(new MySqlParameter("@nombre", (object)nuevo.Nombre));
                Parametros.Add(new MySqlParameter("@area", (object)nuevo.Area));


                MySqlCommand orden = ObtenerOrdenSqlInsert(SQLString.ToString(), Parametros);
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
        private MySqlCommand ObtenerOrdenSqlInsert(string sentenciaSQL, ArrayList Parametros)
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
                return orden;
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
