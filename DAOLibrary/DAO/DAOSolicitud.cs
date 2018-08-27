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
    public class DAOSolicitud
    {

        public DataSet select(DTOSolicitud dto)
        {
            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select * From Solicitud");
                if (dto == null)
                {
                    throw new NullReferenceException("DAOSolicitud.select(dto)");

                }
                if (dto.Codigo != null)
                {
                    Campos.Append("codigo = @codigo AND ");
                    Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
                }
                if(Campos.Length>0){
                    SQLString.Append(" WHERE ");
                    SQLString.Append(Campos.ToString().Substring(0,Campos.ToString().Length -4 ));
                }
                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(),Parametros);
                MySqlDataAdapter da = new MySqlDataAdapter(orden);
                da.Fill(ds);

                return ds;
            }catch(Exception ex){
                throw(ex);
            }
        }


        public string select_solicitud_razon(int codigo)
        {
            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select nomrazoncambio From razoncambio");
                if (codigo <= 0)
                {
                    throw new NullReferenceException("DAOSolicitud.select(dto)");

                }

               Campos.Append("idrazoncambio = @codigo AND ");
               Parametros.Add(new MySqlParameter("@codigo", codigo));

                if (Campos.Length > 0)
                {
                    SQLString.Append(" WHERE ");
                    SQLString.Append(Campos.ToString().Substring(0, Campos.ToString().Length - 4));
                }

                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                MySqlDataAdapter da = new MySqlDataAdapter(orden);
                da.Fill(ds);

                return ds.Tables[0].Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public string select_sociedad_afectada(int codigo)
        {
            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select nomSociedad From sociedad");
                if (codigo <= 0)
                {
                    throw new NullReferenceException("DAOSolicitud.select(dto)");

                }

                Campos.Append("idSociedad = @codigo AND ");
                Parametros.Add(new MySqlParameter("@codigo", codigo));

                if (Campos.Length > 0)
                {
                    SQLString.Append(" WHERE ");
                    SQLString.Append(Campos.ToString().Substring(0, Campos.ToString().Length - 4));
                }

                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                MySqlDataAdapter da = new MySqlDataAdapter(orden);
                da.Fill(ds);

                return ds.Tables[0].Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public string select_origen_cambio(int codigo)
        {
            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select nomOrigencambio From origencambio");
                if (codigo <= 0)
                {
                    throw new NullReferenceException("DAOSolicitud.select(dto)");

                }

                Campos.Append("idOrigencambio = @codigo AND ");
                Parametros.Add(new MySqlParameter("@codigo", codigo));

                if (Campos.Length > 0)
                {
                    SQLString.Append(" WHERE ");
                    SQLString.Append(Campos.ToString().Substring(0, Campos.ToString().Length - 4));
                }

                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                MySqlDataAdapter da = new MySqlDataAdapter(orden);
                da.Fill(ds);

                return ds.Tables[0].Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public string select_area_solicitante(int codigo)
        {
            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select nomAreaSolicitante From areasolicitante");
                if (codigo <= 0)
                {
                    throw new NullReferenceException("DAOSolicitud.select(dto)");

                }

                Campos.Append("idAreaSolicitante = @codigo AND ");
                Parametros.Add(new MySqlParameter("@codigo", codigo));

                if (Campos.Length > 0)
                {
                    SQLString.Append(" WHERE ");
                    SQLString.Append(Campos.ToString().Substring(0, Campos.ToString().Length - 4));
                }

                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                MySqlDataAdapter da = new MySqlDataAdapter(orden);
                da.Fill(ds);

                return ds.Tables[0].Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public string select_prioridad_propuesta(int codigo)
        {
            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select nomPrioridadcambio From prioridadcambio");
                if (codigo <= 0)
                {
                    throw new NullReferenceException("DAOSolicitud.select(dto)");

                }

                Campos.Append("idPrioridadcambio = @codigo AND ");
                Parametros.Add(new MySqlParameter("@codigo", codigo));

                if (Campos.Length > 0)
                {
                    SQLString.Append(" WHERE ");
                    SQLString.Append(Campos.ToString().Substring(0, Campos.ToString().Length - 4));
                }

                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                MySqlDataAdapter da = new MySqlDataAdapter(orden);
                da.Fill(ds);

                return ds.Tables[0].Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public string select_ambiente_afectado(int codigo)
        {
            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select nomAmbienteCambio From ambientecambio");
                if (codigo <= 0)
                {
                    throw new NullReferenceException("DAOSolicitud.select(dto)");

                }

                Campos.Append("idAmbienteCambio = @codigo AND ");
                Parametros.Add(new MySqlParameter("@codigo", codigo));

                if (Campos.Length > 0)
                {
                    SQLString.Append(" WHERE ");
                    SQLString.Append(Campos.ToString().Substring(0, Campos.ToString().Length - 4));
                }

                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                MySqlDataAdapter da = new MySqlDataAdapter(orden);
                da.Fill(ds);

                return ds.Tables[0].Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public string select_impacto_cambio(int codigo)
        {
            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select nomImpactoCambio From impactocambio");
                if (codigo <= 0)
                {
                    throw new NullReferenceException("DAOSolicitud.select(dto)");

                }

                Campos.Append("idImpactoCambio = @codigo AND ");
                Parametros.Add(new MySqlParameter("@codigo", codigo));

                if (Campos.Length > 0)
                {
                    SQLString.Append(" WHERE ");
                    SQLString.Append(Campos.ToString().Substring(0, Campos.ToString().Length - 4));
                }

                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                MySqlDataAdapter da = new MySqlDataAdapter(orden);
                da.Fill(ds);

                return ds.Tables[0].Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public int updateEmergencia(DTOSolicitud dto)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();


                SQLString.Append("UPDATE solicitud SET origen=@origen, razon=@razon, codasociado=@codasociado");
                SQLString.Append(" WHERE codigo=@codigo");

                Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
                Parametros.Add(new MySqlParameter("@origen", (object)dto.Origen));
                Parametros.Add(new MySqlParameter("@razon", (object)dto.Razon));
                Parametros.Add(new MySqlParameter("@codasociado", (object)dto.Codasociado));


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

        public int MaxSolicitud()
        {

            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();


                SQLString.Append("SELECT MAX(codigo) + 1 FROM solicitud;");

                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                MySqlDataAdapter vda = new MySqlDataAdapter(orden);

                vda.Fill(ds);
                return Int32.Parse(ds.Tables[0].Rows[0][0].ToString());

                /*SqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                SqlDataAdapter da = new SqlDataAdapter(orden);
                da.Fill(ds);

                cod = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());*/


            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        
        public int insert(DTOSolicitud dto)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                int cod = MaxSolicitud();

                SQLString.Append("INSERT INTO Solicitud(codigo, fechsolicitud,nomsolicitante, areasolicitante, origen, codasociado, titulo, razon, sociedadafectada, pripropuesta, fecpropuesta, sisafectado, ambafectado, impactoest, indispropuesta, areainvolucrada, reuprevia, descambio, justcambio, criteriosaceptacion) VALUES ");
                SQLString.Append("(@codigo, @fechsolicitud, @nomsolicitante, @areasolicitante, @origen, @codasociado, @titulo, @razon, @sociedadafectada, @pripropuesta, @fecpropuesta, @sisafectado, @ambafectado, @impactoest, @indisponibilidad, @areainvolucrada, @reuprevia, @descambio, @justcambio, @criteriosaceptacion); ");

                Parametros.Add(new MySqlParameter("@codigo", (object)cod));
                Parametros.Add(new MySqlParameter("@fechsolicitud", (object)dto.Fechsolicitud));
                Parametros.Add(new MySqlParameter("@nomsolicitante", (object)dto.Nomsolicitante));
                Parametros.Add(new MySqlParameter("@areasolicitante", (object)dto.Areasolicitante));
                Parametros.Add(new MySqlParameter("@origen", (object)dto.Origen));
                Parametros.Add(new MySqlParameter("@codasociado", (object)dto.Codasociado));
                Parametros.Add(new MySqlParameter("@titulo", (object)dto.Titulo));
                Parametros.Add(new MySqlParameter("@razon", (object)dto.Razon));
                Parametros.Add(new MySqlParameter("@sociedadafectada", (object)dto.Sociedadafectada));
                Parametros.Add(new MySqlParameter("@pripropuesta", (object)dto.Pripropuesta));
                Parametros.Add(new MySqlParameter("@fecpropuesta", (object)dto.Fecpropuesta));
                Parametros.Add(new MySqlParameter("@sisafectado", (object)dto.Sisafectado));
                Parametros.Add(new MySqlParameter("@ambafectado", (object)dto.Ambafectado));
                Parametros.Add(new MySqlParameter("@impactoest", (object)dto.Impactoest));
                Parametros.Add(new MySqlParameter("@indisponibilidad", (object)dto.Indispropuesta));
                Parametros.Add(new MySqlParameter("@areainvolucrada", (object)dto.Areainvolucrada));
                Parametros.Add(new MySqlParameter("@reuprevia", (object)dto.Reuprevia));
                Parametros.Add(new MySqlParameter("@descambio", (object)dto.Descambio));
                Parametros.Add(new MySqlParameter("@justcambio", (object)dto.Justcambio));
                Parametros.Add(new MySqlParameter("@criteriosaceptacion", (object)dto.Criteriosaceptacion));

                MySqlCommand orden = ObtenerOrdenSqlInsert(SQLString.ToString(), Parametros);
                orden.Connection.Open();
                int x = orden.ExecuteNonQuery();
                if (x > 0)
                {
                    dto.Codigo = (Int32?)orden.LastInsertedId;
                }
                orden.Connection.Close();
                return cod;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            
        }

        public int delete(DTOSolicitud dto)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();


                SQLString.Append("DELETE FROM solicitud");
                SQLString.Append(" WHERE codigo=@codigo");

                Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));

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
