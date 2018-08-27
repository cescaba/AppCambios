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
    public class DAOUsuario
    {

        public DataSet select(DTOUsuario dto)
        {
            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select * From Usuario");
                if (dto == null)
                {
                    throw new NullReferenceException("DAOUsuario.select(dto)");

                }
                if (dto.Nombre != null)
                {
                    Campos.Append("LOWER(nombre) = LOWER(@nombre) AND ");
                    Parametros.Add(new MySqlParameter("@nombre", (object)dto.Nombre));
                }
                if (dto.Password != null)
                {
                    Campos.Append("password = @password AND ");
                    Parametros.Add(new MySqlParameter("@password", (object)dto.Password));
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
