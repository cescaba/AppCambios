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
    public class DAORFC
    {
        public int updateGuardarCierre(DTORfc dto)
        {

            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("UPDATE rfc SET estado=@estado, cambiosatisfactorio=@cambiosatisfactorio, detalrevision=@detalrevision,");
                SQLString.Append("volvioprocedimiento=@volvioprocedimiento, fecrevisionfinal=@fecrevisionfinal, revisador=@revisador");
                SQLString.Append(" WHERE codigo=@codigo");

                Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
                Parametros.Add(new MySqlParameter("@estado", (object)dto.Estado));
                Parametros.Add(new MySqlParameter("@cambiosatisfactorio", (object)dto.Cambiosatifactorio));
                Parametros.Add(new MySqlParameter("@detalrevision", (object)dto.Detalrevision));
                Parametros.Add(new MySqlParameter("@volvioprocedimiento", (object)dto.Volvioprocedimiento));
                Parametros.Add(new MySqlParameter("@fecrevisionfinal", (object)dto.Fecrevisionfinal));
                Parametros.Add(new MySqlParameter("@revisador", (object)dto.Revisador));

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
        public int delete(DTORfc dto)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();


                SQLString.Append("DELETE FROM rfc");
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
        public int  updateAprobarMenor(DTORfc dto)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();


                SQLString.Append("UPDATE rfc SET estado=@estado, aprobador=@aprobador, fecaprobacion=@fecaprobacion, correo_aprobacion=@correo_aprobacion, motivo = @motivo");
                SQLString.Append(" WHERE codigo=@codigo");

                Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
                Parametros.Add(new MySqlParameter("@estado", (object)dto.Estado));
                Parametros.Add(new MySqlParameter("@aprobador", (object)dto.Aprobador));
                Parametros.Add(new MySqlParameter("@fecaprobacion", (object)dto.Fecaprobacion));
                Parametros.Add(new MySqlParameter("@correo_aprobacion", (object)dto.Correo_aprobacion));
                Parametros.Add(new MySqlParameter("@motivo", (object)dto.Motivo));

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
        public int updateAprobarBAU(DTORfc dto)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();


                SQLString.Append("UPDATE rfc SET estado=@estado, aprobador=@aprobador, fecaprobacion=@fecaprobacion");
                SQLString.Append(" WHERE codigo=@codigo");

                Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
                Parametros.Add(new MySqlParameter("@estado", (object)dto.Estado));
                Parametros.Add(new MySqlParameter("@aprobador", (object)dto.Aprobador));
                Parametros.Add(new MySqlParameter("@fecaprobacion", (object)dto.Fecaprobacion));



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

        public int updateRetrocederAprobacion(DTORfc dto)
        {

            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("UPDATE rfc SET estado='Pendiente', aprobador='', fecaprobacion=NULL ");
                SQLString.Append("WHERE codigo=@codigo");

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


        public int updateGuardarAprobado(DTORfc dto)
        {

            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("UPDATE rfc SET estado=@estado, fecrealejecucion=@fecrealejecucion, fecrealfinalizacion=@fecrealfinalizacion,");
                SQLString.Append("incidenteseje=@incidenteseje, rollback=@rollback, fecrollback=@fecrollback,");
                SQLString.Append("autorizarollback=@autorizarollback, prueba=@prueba, ConformidadPrueba=@ConformidadPrueba, incidenteprue=@incidenteprue,");
                SQLString.Append("feccierre=@feccierre, tipo_finalizacion=@tipo_finalizacion WHERE codigo=@codigo");

                Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
                Parametros.Add(new MySqlParameter("@estado", (object)dto.Estado));
                Parametros.Add(new MySqlParameter("@fecrealejecucion", (object)dto.Fecharealejecucion));
                Parametros.Add(new MySqlParameter("@fecrealfinalizacion", (object)dto.Fecharealfinalizacion));
                Parametros.Add(new MySqlParameter("@incidenteseje", (object)dto.Incidenteseje));
                Parametros.Add(new MySqlParameter("@rollback", (object)dto.Rollback));
                Parametros.Add(new MySqlParameter("@fecrollback", (object)dto.Fecrollback));
                Parametros.Add(new MySqlParameter("@autorizarollback", (object)dto.Autorizarollback));
                Parametros.Add(new MySqlParameter("@prueba", (object)dto.Prueba));
                Parametros.Add(new MySqlParameter("@ConformidadPrueba", (object)dto.ConformidadPrueba));
                Parametros.Add(new MySqlParameter("@incidenteprue", (object)dto.Incidenteprue));
                Parametros.Add(new MySqlParameter("@feccierre", (object)dto.Feccierre));
                Parametros.Add(new MySqlParameter("@tipo_finalizacion", (object)dto.Tipo_finalizacion));


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

        public int updateGuardarPendiente(DTORfc dto)
        {
           
            try
            {
            StringBuilder SQLString = new StringBuilder();
            ArrayList Parametros = new ArrayList();

            SQLString.Append("UPDATE rfc SET ejecutornombre=@ejecutornombre, ejecutorequipo=@ejecutorequipo,tipocambio_normal=@tipocambio_normal,");
             SQLString.Append("tipocambio=@tipocambio,prioridad=@prioridad,codatenciontercero=@codatenciontercero,");
             SQLString.Append("indisponibilidad=@indisponibilidad, planTrabajo=@planTrabajo, planPruebas=@planPruebas, planContigencia=@planContigencia,");
             SQLString.Append("personasacomunicar=@comunicadopersonas, rutaplan=@rutaplan, fecprogramadaejecucion=@fecprogramadaejecucion, fecprogramadafinalizacion=@fecprogramadafinalizacion, probfalla=@probfalla");
            SQLString.Append(" WHERE codigo=@codigo");

            Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
            Parametros.Add(new MySqlParameter("@ejecutornombre", (object)dto.Ejecutornombre));
            Parametros.Add(new MySqlParameter("@ejecutorequipo", (object)dto.Ejecutorequipo));
            Parametros.Add(new MySqlParameter("@tipocambio_normal", (object)dto.Tipocambio_normal));
            Parametros.Add(new MySqlParameter("@tipocambio", (object)dto.Tipocambio));
            Parametros.Add(new MySqlParameter("@prioridad", (object)dto.Prioridad));
            Parametros.Add(new MySqlParameter("@codatenciontercero", (object)dto.Codatenciontercero));
            Parametros.Add(new MySqlParameter("@indisponibilidad", (object)dto.Indisponibilidad));
            Parametros.Add(new MySqlParameter("@planTrabajo", (object)dto.PlanTrabajo));
            Parametros.Add(new MySqlParameter("@planPruebas", (object)dto.PlanPruebas));
            Parametros.Add(new MySqlParameter("@planContigencia", (object)dto.PlanContigencia));
            Parametros.Add(new MySqlParameter("@comunicadopersonas", (object)dto.Personasacomunicar));
            Parametros.Add(new MySqlParameter("@rutaplan", (object)dto.Rutaplan));
            Parametros.Add(new MySqlParameter("@fecprogramadaejecucion", (object)dto.Fecprogramadaejecucion));
            Parametros.Add(new MySqlParameter("@fecprogramadafinalizacion", (object)dto.Fecprogramadafinalizacion));
            Parametros.Add(new MySqlParameter("@probfalla", (object)dto.Probfalla));

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

        public int updateGuardarAceptado(DTORfc dto)
        {

            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                if (dto.Estado == "Pendiente")
                {
                    SQLString.Append("UPDATE rfc SET estado=@estado, tipocambio_normal=@tipocambio_normal, prioridad=@prioridad, tipocambio=@tipocambio");
                    SQLString.Append(" WHERE codigo=@codigo");

                    Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
                    Parametros.Add(new MySqlParameter("@estado", (object)dto.Estado));
                    Parametros.Add(new MySqlParameter("@tipocambio_normal", (object)dto.Tipocambio_normal));
                    Parametros.Add(new MySqlParameter("@prioridad", (object)dto.Prioridad));
                    Parametros.Add(new MySqlParameter("@tipocambio", (object)dto.Tipocambio));

                }
                else
                {

                    SQLString.Append("UPDATE rfc SET tipocambio_normal=@tipocambio_normal, prioridad=@prioridad,tipocambio=@tipocambio");
                    SQLString.Append(" WHERE codigo=@codigo");

                    Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
                    Parametros.Add(new MySqlParameter("@tipocambio_normal", (object)dto.Tipocambio_normal));
                    Parametros.Add(new MySqlParameter("@prioridad", (object)dto.Prioridad));
                    Parametros.Add(new MySqlParameter("@tipocambio", (object)dto.Tipocambio));
                }

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

        public int updateRechazar(DTORfc dto)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("UPDATE rfc SET estado='Rechazado', fecrechazo=@fecrechazo, razonrechazo=@razonrechazo WHERE codigo=@codigo;");


                // Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
                Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
                Parametros.Add(new MySqlParameter("@fecrechazo", (object)dto.Fecrechazo));
                Parametros.Add(new MySqlParameter("@razonrechazo", (object)dto.Razonrechazo));
        
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


        public int updateAceptar(DTORfc dto)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();


                //SQLString.Append("UPDATE rfc SET estado='Aceptado', fecaceptacion = @fecaceptacion,nomaceptador = @nomaceptador, tipocambio=@tipocambio, cateinfra = @cateinfra, coordinador = @coordinador, cod_bau = @codbau WHERE codigo=@codigo;");
                SQLString.Append("UPDATE rfc SET estado='Aceptado', fecaceptacion = @fecaceptacion,nomaceptador = @nomaceptador, cateinfra = @cateinfra, coordinador = @coordinador WHERE codigo=@codigo;");
                Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
                Parametros.Add(new MySqlParameter("@fecaceptacion", (object)dto.Fecaceptacion));
                Parametros.Add(new MySqlParameter("@nomaceptador", (object)dto.Nomaceptador));
                //Parametros.Add(new MySqlParameter("@tipocambio", (object)dto.Tipocambio));
                Parametros.Add(new MySqlParameter("@cateinfra", (object)dto.Cateinfra));
                Parametros.Add(new MySqlParameter("@coordinador", (object)dto.Coordinador));
                //Parametros.Add(new MySqlParameter("@codbau", (object)dto.Cod_bau));

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
        public DataSet select(DTORfc dto)
        {
            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select * From rfc");
                if (dto == null)
                {
                    throw new NullReferenceException("DAOSolicitud.select(dto)");

                }
                if (dto.Codigo != null)
                {
                    Campos.Append("codigo = @codigo AND ");
                    Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
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
        public DataSet buscarTicket(DTORfc dto, int tipo)
        {
            try
            {
                DataSet ds = new DataSet();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                if (tipo == 1)
                {
                    SQLString.Append("Select * from rfc r, solicitud s where r.codigo = s.codigo and s.codasociado = '" + dto.Codatenciontercero + "';");
                }
                else
                {
                    SQLString.Append("Select * from rfc where codatenciontercero = '" + dto.Codatenciontercero + "';");
                }


                if (dto == null)
                {
                    throw new NullReferenceException("DAOSolicitud.select(dto)");

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

        public DataTable selectToShow(Boolean all, DTORfc rfc)
        {
            try
            {
                DataTable dt = new DataTable();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                SQLString.Append("Select r.codigo, r.estado, r.tipocambio, r.indisponibilidad, s.titulo, r.fecprogramadaejecucion, r.fecprogramadafinalizacion, s.sisafectado, s.ambafectado, s.empafectada  From Solicitud s, RFC r ");


                Campos.Append("r.codigo = s.codigo AND ");
                if (!all)
                {
                    Campos.Append("(r.estado= 'Registrado' or r.estado='Pendiente' or r.estado='Aprobado' or r.estado='En Ejecucion') AND ");
                }
                if (rfc != null)
                {
                    Campos.Append(" r.coordinador = '" + rfc.Coordinador + "' AND ");
                }


                if (Campos.Length > 0)
                {
                    SQLString.Append(" WHERE ");
                    SQLString.Append(Campos.ToString().Substring(0, Campos.ToString().Length - 4));
                }
                SQLString.Append(" order by r.codigo desc ");
                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                MySqlDataAdapter da = new MySqlDataAdapter(orden);
                //da.Fill(ds);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public DataTable selectCostum(DTORfc rfc, DTOSolicitud solicitud, Boolean vista, Boolean estado, int tipoCambio)
        {
            try
            {
                DataTable dt = new DataTable();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();

                if (vista)
                {
                    SQLString.Append("Select r.codigo, r.estado, IF(r.tipocambio = 'Normal', r.tipocambio_normal, r.tipocambio) as tipocambio, if(r.indisponibilidad = 1 , 'SI', 'NO') as indisponibilidad, s.titulo, r.fecprogramadaejecucion, r.fecprogramadafinalizacion, s.sisafectado, (select nomAmbienteCambio from ambientecambio where idAmbienteCambio = s.ambafectado) as ambiente, (select nomSociedad from sociedad where idSociedad = s.sociedadafectada) as sociedad From Solicitud s, RFC r ");
                }
                else
                {
                    SQLString.Append("Select s.codigo, s.Fechsolicitud,s.titulo, s.nomsolicitante, s.areasolicitante, s.origen, s.razon, (select nomSociedad from sociedad where idSociedad = s.sociedadafectada), s.sisafectado, s.ambafectado, r.* From Solicitud s, RFC r ");
                }
               

                Campos.Append("r.codigo = s.codigo AND ");

                if (rfc.Estado != null)
                {
                    if (estado)
                    {
                        Campos.Append("r.estado in ('Pendiente','Aceptado','Registrado','Aprobado') AND ");
                    }
                    else
                    {
                        Campos.Append("r.estado ='" + rfc.Estado + "' AND ");
                    }
                    


                }
                if (rfc.Indisponibilidad > -1)
                {
                    Campos.Append("r.indisponibilidad='" + rfc.Indisponibilidad + "' AND ");
                }

                if (tipoCambio == 2)
                {
                    Campos.Append("r.tipocambio_normal='Menor' AND ");
                }
                if (tipoCambio == 3)
                {
                    Campos.Append("r.tipocambio_normal in ('Medio','Mayor','Crítico') AND ");
                }
                if (tipoCambio == 4)
                {
                    Campos.Append("r.tipocambio in ('Emergencia','Excepcion') AND ");
                }


                if (rfc.Cateinfra != null)
                {
                    Campos.Append("r.cateinfra='" + rfc.Cateinfra + "' AND ");
                }
                if (rfc.Coordinador != null)
                {
                    Campos.Append("r.coordinador like '%" + rfc.Coordinador + "%' AND ");
                }
             
                if (solicitud.Nomsolicitante != null)
                {
                    Campos.Append("s.nomsolicitante like '%" + solicitud.Nomsolicitante + "%' AND ");
                }

                if (solicitud.Areasolicitante > 0)
                {
                    Campos.Append("s.areasolicitante = '" + solicitud.Areasolicitante + "' AND ");
                }
                if (solicitud.Empresa != null)
                {
                     DataSet dsx = new DataSet();
                        StringBuilder SQLStringx = new StringBuilder();
                        StringBuilder Camposx = new StringBuilder();
                        ArrayList Parametrosx = new ArrayList();
                    try
                    {
                        SQLStringx.Append("Select * From sociedad where idEmpresa = (select idEmpresa from empresa where nomEmpresa = '" + solicitud.Empresa+ "');");

                        MySqlCommand ordenx = ObtenerOrdenSql(SQLStringx.ToString(), Parametrosx);
                        MySqlDataAdapter dax = new MySqlDataAdapter(ordenx);
                        dax.Fill(dsx);
                    }
                    catch (Exception ex)
                    {
                        throw (ex);
                    }

                    string auxiliarSociedades = null;

                    foreach (DataRow row in dsx.Tables[0].Rows)
                    {
                        auxiliarSociedades = auxiliarSociedades + "" + row[0].ToString()+ ", ";

                    }

                    auxiliarSociedades = auxiliarSociedades.Substring(0, auxiliarSociedades.Length - 2);

                    Campos.Append("s.sociedadafectada in (" + auxiliarSociedades + ") AND ");
                }
                if (solicitud.Fechsolicitud !=  new DateTime(1900,01,01,00,00,00) && solicitud.Fecpropuesta != new DateTime(1900,01,01,00,00,00))
                {
                    Campos.Append("(s.fechsolicitud >= '" + solicitud.Fechsolicitud.ToString("yyyy-MM-dd hh:mm:ss") + "' AND s.fechsolicitud <= '" + solicitud.Fecpropuesta.ToString("yyyy-MM-dd hh:mm:ss") + "') AND ");

                }
                if (rfc.Fecprogramadaejecucion != new DateTime(1900, 01, 01, 00, 00, 00) && rfc.Fecprogramadafinalizacion != new DateTime(1900, 01, 01, 00, 00, 00))
                {
                    Campos.Append("(r.fecprogramadaejecucion >= '" + rfc.Fecprogramadaejecucion.ToString("yyyy-MM-dd hh:mm:ss") + "' AND r.fecprogramadaejecucion <= '" + rfc.Fecprogramadafinalizacion.ToString("yyyy-MM-dd hh:mm:ss") + "' ) AND ");
                }
                if (rfc.Fecharealejecucion != new DateTime(1900, 01, 01, 00, 00, 00) && rfc.Fecharealfinalizacion != new DateTime(1900, 01, 01, 00, 00, 00))
                {
                    Campos.Append("(r.fecrealejecucion >= '" + rfc.Fecharealejecucion.ToString("yyyy-MM-dd hh:mm:ss") + "' AND r.fecrealejecucion < '" + rfc.Fecharealfinalizacion.ToString("yyyy-MM-dd hh:mm:ss") + "' ) AND ");
                }


                if (Campos.Length > 0)
                {
                    SQLString.Append(" WHERE ");
                    SQLString.Append(Campos.ToString().Substring(0, Campos.ToString().Length - 4));
                }
                SQLString.Append(" order by r.codigo desc ");
                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                MySqlDataAdapter da = new MySqlDataAdapter(orden);
                //da.Fill(ds);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public DataTable selectMiguel(DTORfc rfc, DTOSolicitud solicitud, int tipoReporte)
        {
            try
            {
                DataTable dt = new DataTable();
                StringBuilder SQLString = new StringBuilder();
                StringBuilder Campos = new StringBuilder();
                ArrayList Parametros = new ArrayList();


                SQLString.Append("Select r.codigo, s.fechsolicitud,s.nomsolicitante,s.titulo,s.descambio,r.fecprogramadaejecucion,r.fecprogramadafinalizacion,s.sisafectado,(select y.nomEmpresa from sociedad x, empresa y where x.idSociedad = s.sociedadafectada and x.idEmpresa = y.idEmpresa) Empresa,(select nomAmbienteCambio from ambientecambio where idAmbienteCambio = s.ambafectado) Ambiente, if(r.fecprogramadaejecucion = null, 0,SEC_TO_TIME(TIMESTAMPDIFF(SECOND,r.fecprogramadaejecucion,r.fecprogramadafinalizacion))) Duracion ,if(r.indisponibilidad = 1 , 'SI', 'NO') as indisponibilidad,r.coordinador,r.rutaplan,IF(r.tipocambio = 'Normal', r.tipocambio_normal, r.tipocambio) as tipocambio, r.estado,r.motivo, r.aprobador From Solicitud s, RFC r ");


                Campos.Append("r.codigo = s.codigo AND ");
                //Campos.Append("r.estado = 'Pendiente' AND ");
                //Campos.Append("(WEEK(DATE_ADD(CURDATE(), INTERVAL 1 WEEK)) = WEEK(r.fecprogramadaejecucion) or r.fecprogramadaejecucion is null) AND");

                if (tipoReporte == 2)
                {
                    Campos.Append("r.tipocambio_normal='Menor' AND ");
                }
                if (tipoReporte == 3)
                {
                    Campos.Append("r.tipocambio_normal in ('Medio','Mayor','Crítico') AND ");
                }
                if (tipoReporte == 4)
                {
                    Campos.Append("r.tipocambio in ('Emergencia','Excepcion') AND ");
                }
                if (rfc.Estado != null)
                {
                    Campos.Append("r.estado ='" + rfc.Estado + "' AND ");
                }

                if (rfc.Indisponibilidad > -1)
                {
                    Campos.Append("r.indisponibilidad='" + rfc.Indisponibilidad + "' AND ");
                }

                if (rfc.Cateinfra != null)
                {
                    Campos.Append("r.cateinfra='" + rfc.Cateinfra + "' AND ");
                }
                if (rfc.Coordinador != null)
                {
                    Campos.Append("r.coordinador like '%" + rfc.Coordinador + "%' AND ");
                }

                if (solicitud.Nomsolicitante != null)
                {
                    Campos.Append("s.nomsolicitante like '%" + solicitud.Nomsolicitante + "%' AND ");
                }

                if (solicitud.Areasolicitante > 0)
                {
                    Campos.Append("s.areasolicitante = '" + solicitud.Areasolicitante + "' AND ");
                }
                if (solicitud.Sociedadafectada > 0)
                {
                    Campos.Append("s.sociedadafectada = '" + solicitud.Sociedadafectada + "' AND ");
                }
                if (solicitud.Fechsolicitud != new DateTime(1900, 01, 01, 00, 00, 00) && solicitud.Fecpropuesta != new DateTime(1900, 01, 01, 00, 00, 00))
                {
                    Campos.Append("(s.fechsolicitud >= '" + solicitud.Fechsolicitud.ToString("yyyy-MM-dd hh:mm:ss") + "' AND s.fechsolicitud <= '" + solicitud.Fecpropuesta.ToString("yyyy-MM-dd hh:mm:ss") + "') AND ");

                }
                if (rfc.Fecprogramadaejecucion != new DateTime(1900, 01, 01, 00, 00, 00) && rfc.Fecprogramadafinalizacion != new DateTime(1900, 01, 01, 00, 00, 00))
                {
                    Campos.Append("(r.fecprogramadaejecucion >= '" + rfc.Fecprogramadaejecucion.ToString("yyyy-MM-dd hh:mm:ss") + "' AND r.fecprogramadaejecucion <= '" + rfc.Fecprogramadafinalizacion.ToString("yyyy-MM-dd hh:mm:ss") + "' ) AND ");
                }
                if (rfc.Fecharealejecucion != new DateTime(1900, 01, 01, 00, 00, 00) && rfc.Fecharealfinalizacion != new DateTime(1900, 01, 01, 00, 00, 00))
                {
                    Campos.Append("(r.fecrealejecucion >= '" + rfc.Fecharealejecucion.ToString("yyyy-MM-dd hh:mm:ss") + "' AND r.fecrealejecucion < '" + rfc.Fecharealfinalizacion.ToString("yyyy-MM-dd hh:mm:ss") + "' ) AND ");
                }

                if (Campos.Length > 0)
                {
                    SQLString.Append(" WHERE ");
                    SQLString.Append(Campos.ToString().Substring(0, Campos.ToString().Length - 4));
                }
                SQLString.Append(" order by r.codigo desc ");
                MySqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
                MySqlDataAdapter da = new MySqlDataAdapter(orden);
                //da.Fill(ds);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        public int updateReprogramacion(DTORfc dto)
        {
            try
            {
                StringBuilder SQLString = new StringBuilder();
                ArrayList Parametros = new ArrayList();


                SQLString.Append("UPDATE rfc SET fecprogramadaejecucion = @fecprogramadaejecucion ,fecprogramadafinalizacion =@fecprogramadafinalizacion WHERE codigo=@codigo;");
                Parametros.Add(new MySqlParameter("@codigo", (object)dto.Codigo));
                Parametros.Add(new MySqlParameter("@fecprogramadaejecucion", (object)dto.Fecprogramadaejecucion));
                Parametros.Add(new MySqlParameter("@fecprogramadafinalizacion", (object)dto.Fecprogramadafinalizacion));


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
