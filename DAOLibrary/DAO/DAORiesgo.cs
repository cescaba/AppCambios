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
    public class DAORiesgo
    {
        public int Delete(int? codigo)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Delete from Riesgo");
                SQLString.Append(" WHERE RFC=@codigo");

                Parametros.Add(new MySqlParameter("@codigo", (object)codigo));

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
        public int Insert(DTORiesgo nuevo)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Insert into Riesgo values(@rfc,@codigo,@titulo,@impacto);");

                Parametros.Add(new MySqlParameter("@rfc", (object)nuevo.Rfc));
                Parametros.Add(new MySqlParameter("@codigo", (object)nuevo.Codigo));
                Parametros.Add(new MySqlParameter("@titulo", (object)nuevo.Titulo));
                Parametros.Add(new MySqlParameter("@impacto", (object)nuevo.Impacto));

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


        public DataTable select(int? codigo)
        {
            try
            {
                DataTable ds = new DataTable();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select * From Riesgo");

                if (codigo > 0)
                {
                    Campos.Append("RFC = @codigo AND ");
                    Parametros.Add(new MySqlParameter("@codigo", (object)codigo));
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

        private MySqlCommand ObtenerOrdenSql(string sentenciaSQL, ArrayList Parametros)
        {
            try
            {
                //MySqlConnection conexion = new MySqlConnection("Server=10.11.23.68;Database=bdgestcambio; Uid=gest_admin;Pwd=CAR4v3lla$$;");
                //MySqlConnection conexion = new MySqlConnection("Server=10.11.23.68;Database=bdgestcambio; Uid=root;Pwd='';");
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
    }
}
