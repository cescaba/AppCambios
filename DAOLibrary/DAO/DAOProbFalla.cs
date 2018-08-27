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
    public class DAOProbFalla
    {

        public int Delete(int? codigo)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Delete from prob_falla");
                SQLString.Append(" WHERE codigo=@codigo");

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
        public DataSet select(DTOProbFalla dto)
        {
            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select * From prob_falla");
                if (dto == null)
                {
                    throw new NullReferenceException("DAOProbFalla.select(dto)");

                }
                if (dto.Codigo != null)
                {
                    Campos.Append("codigo = " + dto.Codigo + " AND ");
                    //Parametros.Add(new MySqlParameter("@nombre", (object)dto.Nombre));
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

        public int Insert(DTOProbFalla nuevo)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Insert into prob_falla values(@codigo,@cod_reu_coor,@cod_pre_elabo,@cod_recu_ejecu);");

                Parametros.Add(new MySqlParameter("@codigo", (object)nuevo.Codigo));
                Parametros.Add(new MySqlParameter("@cod_reu_coor", (object)nuevo.Cod_reu_coor));
                Parametros.Add(new MySqlParameter("@cod_pre_elabo", (object)nuevo.Cod_pre_elabo));
                Parametros.Add(new MySqlParameter("@cod_recu_ejecu", (object)nuevo.Cod_recu_ejecu));


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
