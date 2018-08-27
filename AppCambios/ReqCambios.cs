using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Outlook = Microsoft.Office.Interop.Outlook;
using DAOLibrary.DAO;
using DAOLibrary.DTO;
using System.Net.Mail;

namespace AppCambios
{
    public partial class ReqCambios : Form
    {
        int cboimp1;
        int cboimp2;
        int cboimp6;

        public int Cboimp1
        {
            get { return cboimp1; }
            set { cboimp1 = value; }
        }

        public int Cboimp2
        {
            get { return cboimp2; }
            set { cboimp2 = value; }
        }
        public int Cboimp6
        {
            get { return cboimp6; }
            set { cboimp6 = value; }
        }

        public ReqCambios()
        {
            InitializeComponent();


        }
        public ReqCambios(int num)
        {

        }
        public void FormatodeUI()
        {
            if (txtestado.Text == "Registrado")
            {
                toolStripButton1.Enabled = true;
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                toolStripButton5.Enabled = false;

                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);

                groupBox3.Visible = false;
                groupBox19.Visible = false;
            }
            if (txtestado.Text == "Aceptado")
            {
                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
                toolStripButton4.Enabled = false;
                toolStripButton5.Enabled = false;

                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);

                //Aceptación
                groupBox2.Visible = true;
                
                //txtcodbau.ReadOnly = true;
                //btnbusbau.Enabled = false;
                comboBox3.Enabled = false;
                txtcoordinadorO.ReadOnly = true;
                cboCoordinador.Enabled = false;

                //Categorización
                groupBox3.Visible = true;
                comboBox1.Enabled = true;
                btnimpacto.Enabled = true;
                cboTipCambio.Enabled = true;
                btneditarcate.Visible = false;

                //Asignación
                groupBox19.Visible = false;

            }




            if (txtestado.Text == "Pendiente")
            {
                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
                toolStripButton4.Enabled = true;
                toolStripButton5.Enabled = false;

                //tabPage2

                groupBox2.Visible = true;
                cboTipCambio.Enabled = false;
                comboBox3.Enabled = false;
                cboCoordinador.Enabled = false;
                //txtcodbau.Enabled = false;

                groupBox3.Visible = true;
                comboBox1.Enabled = false;
                btneditarcate.Visible = true;
                groupBox19.Visible = true;

                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);
                tabControl1.TabPages.Add(tabPage3);
                if (txtlink.Text != "")
                {
                    button1.Text = "Consultar Plan";
                }
                else
                {
                    button1.Text = "Agregar Plan";
                }

                if (txtprobfalla.Text != "")
                {
                    btnprobabilidad.Text = "Ver Probabilidad Falla";
                }
                else
                {
                    btnprobabilidad.Text = "Cal. Probabilidad Falla";
                }

            }
            if (txtestado.Text == "Aprobado")
            {

                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);
                if (txttipcambios.Text != "Usual de Negocio")
                {
                    tabControl1.TabPages.Add(tabPage3);
                }

                tabControl1.TabPages.Add(tabPage4);

                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                toolStripButton5.Enabled = true;

                //tabPage2
                groupBox2.Visible = true;
                cboTipCambio.Enabled = false;
                //txtcodbau.ReadOnly = true;
                //btnbusbau.Enabled = false;
                comboBox3.Enabled = false;
                txtcoordinadorO.ReadOnly = true;
                btnimpacto.Enabled = false;
                cboCoordinador.Enabled = false;
                btneditarcate.Visible = true;

                if (txttipcambios.Text != "Usual de Negocio")
                {
                    groupBox3.Visible = true;
                    txtejecutor.ReadOnly = true;
                    txtejecutorequi.ReadOnly = true;

                    groupBox19.Visible = true;
                    txtcodatencion.ReadOnly = true;
                }
                else
                {
                    groupBox3.Visible = false;
                    groupBox19.Visible = false;
                }


                //TabPage3
                radioButtonIndSI.Enabled = false;
                radioButtonIndNO.Enabled = false;
                txtcomunicacion.ReadOnly = true;
 
                dateTimePickerIni.Enabled = false;
                dateTimePickerFin.Enabled = false;
                btnreprogramar.Visible = true;
                btnsaverepro.Visible = false;
                dataGridView1.Enabled = false;

                if (txtlink.Text != "")
                {
                    button1.Text = "Consultar Plan";
                }
                else
                {
                    if(txtcatecambio.Text != "Normal"){
                        button1.Text = "Agregar Plan";
                    }
                    else
                    {
                        button1.Visible = false;
                    }
                    
                }
                if (txtprobfalla.Text != "")
                {
                    btnprobabilidad.Text = "Ver Probabilidad Falla";
                }
                else
                {
                    btnprobabilidad.Text = "Cal. Probabilidad Falla";
                }
                dateTimePickerIniReal.Value = dateTimePickerIni.Value;
                dateTimePickerFinReal.Value = dateTimePickerFin.Value;

                btnprobabilidad.Enabled = false;
                //cbopreparacion.Enabled = false;

            }

            if (txtestado.Text == "Cerrado")
            {

                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);
                tabControl1.TabPages.Add(tabPage3);
                tabControl1.TabPages.Add(tabPage4);
                tabControl1.TabPages.Add(tabPage5);

                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = true;
                toolStripButton4.Enabled = false;
                toolStripButton5.Enabled = false;

                //tabPage2
                comboBox1.Enabled = false;
                btnimpacto.Enabled = false;
                btneditarcate.Visible = false;
                //comboBox2.Enabled = false;
                groupBox3.Visible = true;
                txtejecutor.ReadOnly = true;
                txtejecutorequi.ReadOnly = true;
                txtcoordinadorO.ReadOnly = true;
                txtcoordinadorO.ReadOnly = true;


                groupBox19.Visible = true;
                txtcodatencion.ReadOnly = true;

                //TabPage3
                radioButtonIndSI.Enabled = false;
                radioButtonIndNO.Enabled = false;
                txtcomunicacion.ReadOnly = true;
                
                dateTimePickerIni.Enabled = false;
                dateTimePickerFin.Enabled = false;
                btnreprogramar.Visible = false;
                btnsaverepro.Visible = false;
                dataGridView1.Enabled = false;

                if (txtlink.Text != "")
                {
                    button1.Text = "Consultar Plan";
                }
                else
                {
                    button1.Text = "Agregar Plan";
                }
                if (txtprobfalla.Text != "")
                {
                    btnprobabilidad.Text = "Ver Probabilidad Falla";
                }
                else
                {
                    btnprobabilidad.Text = "Cal. Probabilidad Falla";
                }

                //TabPage4
                dateTimePickerIniReal.Enabled = false;
                dateTimePickerFinReal.Enabled = false;
                txtincidenteseje.ReadOnly = true;
                radioButtonrollSI.Enabled = false;
                radioButtonrollNO.Enabled = false;
                dateTimePickerRoll.Enabled = false;
                txtrollautorizador.ReadOnly = true;
                radioButtonPruSI.Enabled = false;
                radioButtonPruNO.Enabled = false;
                radioButtonPrucSI.Enabled = false;
                radioButtonPrucNO.Enabled = false;
                txtincipruebas.ReadOnly = true;
                btnprobabilidad.Enabled = false;
                //cbopreparacion.Enabled = false;

            }
            if (txtestado.Text == "Revisado" || txtestado.Text == "Rechazado")
            {

                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);
                if (txttipcambios.Text != "Usual de Negocio")
                {
                    tabControl1.TabPages.Add(tabPage3);
                }
                tabControl1.TabPages.Add(tabPage4);
                tabControl1.TabPages.Add(tabPage5);

                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                toolStripButton5.Enabled = false;
                toolStripButton6.Enabled = false;

                //tabPage2

                groupBox2.Visible = true;
                cboTipCambio.Enabled = false;
                btnimpacto.Enabled = false;
                //txtcodbau.ReadOnly = true;
                //btnbusbau.Enabled = false;
                comboBox3.Enabled = false;
                btneditarcate.Visible = false;
                txtcoordinadorO.ReadOnly = true;
                cboCoordinador.Enabled = false;

                if (txttipcambios.Text != "Usual de Negocio")
                {
                    groupBox3.Visible = true;
                    txtejecutor.ReadOnly = true;
                    txtejecutorequi.ReadOnly = true;

                    groupBox19.Visible = true;
                    txtcodatencion.ReadOnly = true;
                }
                else
                {
                    groupBox3.Visible = false;
                    groupBox19.Visible = false;
                }



                //TabPage3
                radioButtonIndSI.Enabled = false;
                radioButtonIndNO.Enabled = false;
                txtcomunicacion.ReadOnly = true;
                dateTimePickerIni.Enabled = false;
                dateTimePickerFin.Enabled = false;
                btnreprogramar.Visible = false;
                btnsaverepro.Visible = false;
                dataGridView1.Enabled = false;

                if (txtlink.Text != "")
                {
                    button1.Text = "Consultar Plan";
                }
                else
                {
                    button1.Text = "Agregar Plan";
                }
                if (txtprobfalla.Text != "")
                {
                    btnprobabilidad.Text = "Ver Probabilidad Falla";
                }
                else
                {
                    btnprobabilidad.Text = "Cal. Probabilidad Falla";
                }

                //TabPage4
                dateTimePickerIniReal.Enabled = false;
                dateTimePickerFinReal.Enabled = false;
                txtincidenteseje.ReadOnly = true;
                radioButtonrollSI.Enabled = false;
                radioButtonrollNO.Enabled = false;
                dateTimePickerRoll.Enabled = false;
                txtrollautorizador.ReadOnly = true;
                radioButtonPruSI.Enabled = false;
                radioButtonPruNO.Enabled = false;
                radioButtonPrucSI.Enabled = false;
                radioButtonPrucNO.Enabled = false;
                txtincipruebas.ReadOnly = true;
                btnprobabilidad.Enabled = false;
                //cbopreparacion.Enabled = false;

                //TabPage5
                radioButtonconSI.Enabled = false;
                radioButtonconNO.Enabled = false;
                txtobs.ReadOnly = true;
                radioButtonproSI.Enabled = false;
                radioButtonproNO.Enabled = false;


            }

        }


        private void llenarDatos()
        {
            
            if (txtcodigo.Text != "")
            {
                DTORfc rfc = new DTORfc();
                DTOSolicitud solicitud = new DTOSolicitud();
                DTOProbFalla probfalla = new DTOProbFalla();


                rfc.Codigo = (Int32)Int32.Parse(txtcodigo.Text);
                solicitud.Codigo = rfc.Codigo;
                probfalla.Codigo = (Int32)Int32.Parse(txtcodigo.Text);

                DAOSolicitud daos = new DAOSolicitud();
                DAORFC daor = new DAORFC();
                DAORiesgo daoriesgo = new DAORiesgo();
                DAOProbFalla daoprobfalla = new DAOProbFalla();
                DAOCoordinador daocoordinador = new DAOCoordinador();
                DTOCoordinador coordinador = new DTOCoordinador();

                DataSet dts = new DataSet();
                DataSet dtr = new DataSet();
                DataTable dtriesgo = new DataTable();
                DataSet dtp = new DataSet();

                dts = daos.select(solicitud);
                dtr = daor.select(rfc);
                dtriesgo = daoriesgo.select(rfc.Codigo);
                dtp = daoprobfalla.select(probfalla);

                if (dtp.Tables[0].Rows.Count > 0)
                {
                    cboimp1 = (Int32)Int32.Parse(dtp.Tables[0].Rows[0]["cod_reu_coor"].ToString());
                    cboimp2 = (Int32)Int32.Parse(dtp.Tables[0].Rows[0]["cod_pre_elabo"].ToString());
                    cboimp6 = (Int32)Int32.Parse(dtp.Tables[0].Rows[0]["cod_recu_ejecu"].ToString());
                }

                if (dts != null)
                {
                    //solicitud.Fechsolicitud = DateTime.ParseExact(dts.Tables[0].Rows[0]["Fechsolicitud"].ToString(), "dd/MM/yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
                    solicitud.Fechsolicitud = DateTime.Parse(dts.Tables[0].Rows[0]["Fechsolicitud"].ToString());
                    solicitud.Nomsolicitante = dts.Tables[0].Rows[0]["nomsolicitante"].ToString();
                    solicitud.Areasolicitante = (Int32)Int32.Parse(dts.Tables[0].Rows[0]["areasolicitante"].ToString());
                    solicitud.Origen = (Int32)Int32.Parse(dts.Tables[0].Rows[0]["origen"].ToString());
                    solicitud.Codasociado = dts.Tables[0].Rows[0]["codasociado"].ToString();
                    solicitud.Titulo = dts.Tables[0].Rows[0]["titulo"].ToString();
                    solicitud.Razon = (Int32)Int32.Parse(dts.Tables[0].Rows[0]["razon"].ToString());
                    solicitud.Sociedadafectada = (Int32)Int32.Parse(dts.Tables[0].Rows[0]["sociedadafectada"].ToString());
                    solicitud.Pripropuesta = (Int32)Int32.Parse(dts.Tables[0].Rows[0]["pripropuesta"].ToString());
                    solicitud.Fecpropuesta = DateTime.Parse(dts.Tables[0].Rows[0]["fecpropuesta"].ToString());
                    solicitud.Sisafectado = dts.Tables[0].Rows[0]["sisafectado"].ToString();
                    solicitud.Ambafectado = (Int32)Int32.Parse(dts.Tables[0].Rows[0]["ambafectado"].ToString());
                    solicitud.Impactoest = (Int32)Int32.Parse(dts.Tables[0].Rows[0]["impactoest"].ToString());
                    solicitud.Indispropuesta = (Int32)Int32.Parse(dts.Tables[0].Rows[0]["indispropuesta"].ToString());
                    solicitud.Areainvolucrada = dts.Tables[0].Rows[0]["areainvolucrada"].ToString();
                    solicitud.Reuprevia = (Int32)Int32.Parse(dts.Tables[0].Rows[0]["reuprevia"].ToString());
                    solicitud.Descambio = dts.Tables[0].Rows[0]["descambio"].ToString();
                    solicitud.Justcambio = dts.Tables[0].Rows[0]["justcambio"].ToString();
                    solicitud.Criteriosaceptacion = dts.Tables[0].Rows[0]["criteriosaceptacion"].ToString();
                    solicitud.Correo = dts.Tables[0].Rows[0]["correo"].ToString();
                }
                if (dtr != null)
                {

                    rfc.Estado = dtr.Tables[0].Rows[0]["estado"].ToString();
                    if (dtr.Tables[0].Rows[0]["fecaceptacion"].ToString() != "")
                    {
                        rfc.Fecaceptacion = DateTime.Parse(dtr.Tables[0].Rows[0]["fecaceptacion"].ToString());
                    }
                    
                    rfc.Nomaceptador = dtr.Tables[0].Rows[0]["nomaceptador"].ToString();
                    rfc.Prioridad = dtr.Tables[0].Rows[0]["prioridad"].ToString();
                    //rfc.Categoria = dtr.Tables[0].Rows[0]["categoria"].ToString();

                    rfc.Tipocambio_normal = dtr.Tables[0].Rows[0]["tipocambio_normal"].ToString();
                    rfc.Ejecutornombre = dtr.Tables[0].Rows[0]["ejecutornombre"].ToString();
                    rfc.Ejecutorequipo = dtr.Tables[0].Rows[0]["ejecutorequipo"].ToString();
                    rfc.Coordinador = dtr.Tables[0].Rows[0]["coordinador"].ToString();
                    rfc.Coordinadorequipo = dtr.Tables[0].Rows[0]["coordinadorequipo"].ToString();
                    rfc.Codatenciontercero = dtr.Tables[0].Rows[0]["codatenciontercero"].ToString();
                    if (dtr.Tables[0].Rows[0]["indisponibilidad"].ToString() != "")
                    {
                        rfc.Indisponibilidad = (Int32)Int32.Parse(dtr.Tables[0].Rows[0]["indisponibilidad"].ToString());
                    }
                    rfc.Depencambioidentificado = dtr.Tables[0].Rows[0]["depencambioidentificado"].ToString();
                    rfc.Personasacomunicar = dtr.Tables[0].Rows[0]["personasacomunicar"].ToString();
                    if (dtr.Tables[0].Rows[0]["fecaprobacion"].ToString() != "")
                    {
                        rfc.Fecaprobacion = DateTime.Parse(dtr.Tables[0].Rows[0]["fecaprobacion"].ToString());
                    }
                    rfc.Aprobador = dtr.Tables[0].Rows[0]["aprobador"].ToString();
                    if (dtr.Tables[0].Rows[0]["fecrechazo"].ToString() != "")
                    {
                        rfc.Fecrechazo = DateTime.Parse(dtr.Tables[0].Rows[0]["fecrechazo"].ToString());
                    }
                    rfc.Razonrechazo = dtr.Tables[0].Rows[0]["razonrechazo"].ToString();

                    if (dtr.Tables[0].Rows[0]["fecprogramadaejecucion"].ToString() != "")
                    {
                        rfc.Fecprogramadaejecucion = DateTime.Parse(dtr.Tables[0].Rows[0]["fecprogramadaejecucion"].ToString());
                    }
                    if (dtr.Tables[0].Rows[0]["fecprogramadafinalizacion"].ToString() != "")
                    {
                        rfc.Fecprogramadafinalizacion = DateTime.Parse(dtr.Tables[0].Rows[0]["fecprogramadafinalizacion"].ToString());
                    }
                    if (dtr.Tables[0].Rows[0]["fecrealejecucion"].ToString() != "")
                    {
                        rfc.Fecharealejecucion = DateTime.Parse(dtr.Tables[0].Rows[0]["fecrealejecucion"].ToString());
                    }
                    if (dtr.Tables[0].Rows[0]["fecrealfinalizacion"].ToString() != "")
                    {
                        rfc.Fecharealfinalizacion = DateTime.Parse(dtr.Tables[0].Rows[0]["fecrealfinalizacion"].ToString());
                    }
                    if (dtr.Tables[0].Rows[0]["rollback"].ToString() != "")
                    {
                        rfc.Rollback = (Int32)Int32.Parse(dtr.Tables[0].Rows[0]["rollback"].ToString());
                    }
                    if (dtr.Tables[0].Rows[0]["fecrollback"].ToString() != "")
                    {
                        rfc.Fecrollback = DateTime.Parse(dtr.Tables[0].Rows[0]["fecrollback"].ToString());
                    }
                    rfc.Autorizarollback = dtr.Tables[0].Rows[0]["autorizarollback"].ToString();

                    if (dtr.Tables[0].Rows[0]["prueba"].ToString() != "")
                    {
                        rfc.Prueba = (Int32)Int32.Parse(dtr.Tables[0].Rows[0]["prueba"].ToString());
                    }
                    if (dtr.Tables[0].Rows[0]["conformidadPrueba"].ToString() != "")
                    {
                        rfc.ConformidadPrueba = (Int32)Int32.Parse(dtr.Tables[0].Rows[0]["conformidadPrueba"].ToString());
                    }
                    if (dtr.Tables[0].Rows[0]["fecrevisionfinal"].ToString() != "")
                    {
                        rfc.Fecrevisionfinal = DateTime.Parse(dtr.Tables[0].Rows[0]["fecrevisionfinal"].ToString());
                    }
                    rfc.Revisador = dtr.Tables[0].Rows[0]["revisador"].ToString();

                    if (dtr.Tables[0].Rows[0]["cambiosatisfactorio"].ToString() != "")
                    {
                        rfc.Cambiosatifactorio = (Int32)Int32.Parse(dtr.Tables[0].Rows[0]["cambiosatisfactorio"].ToString());
                    }

                    rfc.Detalrevision = dtr.Tables[0].Rows[0]["detalrevision"].ToString();

                    if (dtr.Tables[0].Rows[0]["volvioprocedimiento"].ToString() != "")
                    {
                        rfc.Volvioprocedimiento = (Int32)Int32.Parse(dtr.Tables[0].Rows[0]["volvioprocedimiento"].ToString());
                    }

                    rfc.Rutaplan = dtr.Tables[0].Rows[0]["rutaplan"].ToString();

                    if (dtr.Tables[0].Rows[0]["planTrabajo"].ToString() != "")
                    {
                        rfc.PlanTrabajo = (Int32)Int32.Parse(dtr.Tables[0].Rows[0]["planTrabajo"].ToString());
                    }
                    if (dtr.Tables[0].Rows[0]["planPruebas"].ToString() != "")
                    {
                        rfc.PlanPruebas = (Int32)Int32.Parse(dtr.Tables[0].Rows[0]["planPruebas"].ToString());
                    }

                    if (dtr.Tables[0].Rows[0]["planContigencia"].ToString() != "")
                    {
                        rfc.PlanContigencia = (Int32)Int32.Parse(dtr.Tables[0].Rows[0]["planContigencia"].ToString());
                    }
                    if (dtr.Tables[0].Rows[0]["feccierre"].ToString() != "")
                    {
                        rfc.Feccierre = DateTime.Parse(dtr.Tables[0].Rows[0]["feccierre"].ToString());
                    }
                    if (dtr.Tables[0].Rows[0]["feccomite"].ToString() != "")
                    {
                        rfc.Feccomite = DateTime.Parse(dtr.Tables[0].Rows[0]["feccomite"].ToString());
                    }
                    rfc.Incidenteseje = dtr.Tables[0].Rows[0]["incidenteseje"].ToString();
                    rfc.Incidenteprue = dtr.Tables[0].Rows[0]["incidenteprue"].ToString();
                    rfc.Cateinfra = dtr.Tables[0].Rows[0]["cateinfra"].ToString();
                    rfc.Cod_bau = dtr.Tables[0].Rows[0]["cod_bau"].ToString();
                    rfc.Tipocambio = dtr.Tables[0].Rows[0]["tipocambio"].ToString();

                    if (dtr.Tables[0].Rows[0]["probfalla"].ToString() != "") {
                    rfc.Probfalla = (Int32)Int32.Parse(dtr.Tables[0].Rows[0]["probfalla"].ToString());

                    }
                }

                //Cabecera

                txttipcambios.Text = rfc.Tipocambio_normal;
                txtcatecambio.Text = rfc.Tipocambio;
                /*
                if (rfc.Tipocambio == "Normal")
                {
                    txttipcambios.Text = rfc.Tipocambio_normal;
                }
                else
                {
                    txttipcambios.Text = rfc.Tipocambio;
                }
                */
                txtfecsolicitud.Text = solicitud.Fechsolicitud.ToString("dd/MM/yyyy");
                txtestado.Text = rfc.Estado;
                txtdescripcion.Text = solicitud.Titulo;
                txtsolicitante.Text = solicitud.Nomsolicitante;
                txtcoordinador.Text = rfc.Coordinador;

                //Tab Solicitud
                txtsolicitante2.Text = solicitud.Nomsolicitante;
                txtrazon.Text = daos.select_solicitud_razon(solicitud.Razon);
                txtempafectada.Text = daos.select_sociedad_afectada(solicitud.Sociedadafectada);
                txtsisafectado.Text = solicitud.Sisafectado;
                txtfecpropuesta.Text = solicitud.Fecpropuesta.ToString("dd/MM/yyyy hh:mm:ss");
                txtorigen.Text = daos.select_origen_cambio(solicitud.Origen);
                txtcorreo.Text = solicitud.Correo;

                txtareasolicitante.Text = daos.select_area_solicitante(solicitud.Areasolicitante);
                txtpripropuesta.Text = daos.select_prioridad_propuesta(solicitud.Pripropuesta);

                txtambafectado.Text = daos.select_ambiente_afectado(solicitud.Ambafectado);
                txtimpestimado.Text = daos.select_impacto_cambio(solicitud.Impactoest);
                txtcodasociado.Text = solicitud.Codasociado;
                if (solicitud.Indispropuesta == 0)
                {
                    txtindisponipro.Text = "NO";
                }
                if (solicitud.Indispropuesta == 1)
                {
                    txtindisponipro.Text = "SI";
                }
                txtareainvolucrada.Text = solicitud.Areainvolucrada;
  


                txtdescripcioncambio.Text = solicitud.Descambio;
                txtjustificacion.Text = solicitud.Justcambio;
                txtcriterios.Text = solicitud.Criteriosaceptacion;

                if (solicitud.Reuprevia == 1)
                {
                    radioButtonreuSI.Checked = true;
                }
                if (solicitud.Reuprevia == 0)
                {
                    radioButtonreuNO.Checked = true;
                }

                //Tab Asignación
                cboTipCambio.SelectedItem = (object)rfc.Tipocambio;

                if (rfc.Coordinador != "")
                {
                coordinador.Nombre = rfc.Coordinador;
                
                DataTable dtcoordinador = daocoordinador.select(coordinador).Tables[0];
                coordinador.IdCoordinador = (int)Int32.Parse(dtcoordinador.Rows[0]["cod"].ToString());
                coordinador.Area = dtcoordinador.Rows[0]["area"].ToString();

                comboBox3.SelectedItem = (object)coordinador.Area;
                cboCoordinador.SelectedItem = (object)rfc.Coordinador;
                }
                

                //comboBox3.SelectedIndex = ValorCategoriaInfra(rfc.Cateinfra);
                //cboCoordinador.SelectedItem = (object)rfc.Coordinador;
                //txtcodbau.Text = rfc.Cod_bau;


                //Tab Categoria
                comboBox1.SelectedIndex = ValorPrioridad(rfc.Prioridad);
                txtimpacto.Text = rfc.Tipocambio_normal;

                //Tab Asignación                        
                txtejecutor.Text = rfc.Ejecutornombre;
                txtejecutorequi.Text = rfc.Ejecutorequipo;

                cboCoordinador.SelectedItem = (object)rfc.Coordinador;

                txtcoordinadorO.Text = rfc.Coordinador;


                //Tab Terceros
                txtcodatencion.Text = rfc.Codatenciontercero;

                //Tab Planeacion
                if (rfc.Indisponibilidad == 1)
                {
                    radioButtonIndSI.Checked = true;
                }
                if (rfc.Indisponibilidad == 0)
                {
                    radioButtonIndNO.Checked = true;
                }
                txtcomunicacion.Text = rfc.Personasacomunicar;
                txtlink.Text = rfc.Rutaplan;
                if (rfc.Fecprogramadaejecucion != new DateTime(1900,01,01,00,00,00))
                {
                    dateTimePickerIni.Value = rfc.Fecprogramadaejecucion;
                }
                if (rfc.Fecprogramadafinalizacion != new DateTime(1900, 01, 01, 00, 00, 00))
                {
                    dateTimePickerFin.Value = rfc.Fecprogramadafinalizacion;
                }


              

                if (rfc.Probfalla > 0) {

                    if (rfc.Probfalla == 1)
                    {
                        txtprobfalla.Text = "Alto";
                    }
                    if (rfc.Probfalla == 2)
                    {
                        txtprobfalla.Text = "Medio";
                    }
                    if (rfc.Probfalla == 3)
                    {
                        txtprobfalla.Text = "Bajo";
                    }

                
                }


                


                foreach (DataRow dr in dtriesgo.Rows)
                {

                    dataGridView1.Rows.Add(dr[2].ToString(), ValorRiesgoInverso(Int32.Parse(dr[3].ToString())));
                    actualizarriesgo();
                }

                //Tab Registro Cierre
                if (rfc.Fecharealejecucion != new DateTime(1900, 01, 01, 00, 00, 00))
                {
                    dateTimePickerIniReal.Value = rfc.Fecharealejecucion;
                }
                if (rfc.Fecharealfinalizacion != new DateTime(1900, 01, 01, 00, 00, 00))
                {
                    dateTimePickerFinReal.Value = rfc.Fecharealfinalizacion;
                }
                txtincidenteseje.Text = rfc.Incidenteseje;
                if (rfc.Rollback == 1)
                {
                    radioButtonrollSI.Checked = true;
                }
                if (rfc.Rollback == 0)
                {
                    radioButtonrollNO.Checked = true;
                }
                if (rfc.Fecrollback != new DateTime(1900, 01, 01, 00, 00, 00))
                {
                    dateTimePickerRoll.Value = rfc.Fecrollback;
                }
                txtrollautorizador.Text = rfc.Autorizarollback;

                if (rfc.Prueba == 1)
                {
                    radioButtonPruSI.Checked = true;
                }
                if (rfc.Prueba == 0)
                {
                    radioButtonPruNO.Checked = true;
                }
                if (rfc.ConformidadPrueba == 1)
                {
                    radioButtonPrucSI.Checked = true;
                }
                if (rfc.ConformidadPrueba == 0)
                {
                    radioButtonPrucNO.Checked = true;
                }
                txtincipruebas.Text = rfc.Incidenteprue;

                if (rfc.Cambiosatifactorio == 1)
                {
                    radioButtonconSI.Checked = true;
                }
                if (rfc.Cambiosatifactorio == 0)
                {
                    radioButtonconNO.Checked = true;
                }
                txtobs.Text = rfc.Detalrevision;
                if (rfc.Volvioprocedimiento == 1)
                {
                    radioButtonproSI.Checked = true;
                }
                if (rfc.Volvioprocedimiento == 0)
                {
                    radioButtonproNO.Checked = true;
                }
            }
        }
        private int ValorPrioridad(string estado)
        {
            int dato = -1;

            switch (estado)
            {
                case "Baja":
                    dato = 0;
                    break;

                case "Media":
                    dato = 1;
                    break;
                case "Alta":
                    dato = 2;
                    break;
                case "Emergencia":
                    dato = 3;
                    break;

            }

            return dato;
        }
        private int ValorCategoria(string estado)
        {
            int dato = -1;

            switch (estado)
            {
                case "Menor":
                    dato = 0;
                    break;

                case "Medio":
                    dato = 1;
                    break;
                case "Mayor":
                    dato = 2;
                    break;


            }

            return dato;
        }
        private int ValorCategoriaInfra(string estado)
        {
            int dato = -1;

            switch (estado)
            {
                case "Aplicaciones":
                    dato = 0;
                    break;

                case "Comunicaciones":
                    dato = 1;
                    break;
                case "Infraestructura":
                    dato = 2;
                    break;
                case "Seguridad":
                    dato = 3;
                    break;
                case "Mantenimiento":
                    dato = 4;
                    break;
                case "Salida en Vivo":
                    dato = 5;
                    break;

            }

            return dato;
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtcodigo_Click(object sender, EventArgs e)
        {

        }
        public TextBox Txtimpacto
        {
            get
            {
                return txtimpacto;
            }
        }
        public Button Btnproponer
        {
            get
            {
                return btnproponer;
            }
        }
        public TextBox Txtlink
        {
            get
            {
                return txtlink;
            }
        }
        public Label getCodigo
        {
            get
            {
                return txtcodigo;
            }
        }
        public Label getEstado
        {
            get
            {
                return txtestado;
            }
        }
        public DateTimePicker getIni
        {
            get
            {
                return dateTimePickerIni;
            }
        }
        public DateTimePicker getFin
        {
            get
            {
                return dateTimePickerFin;
            }
        }
        public Label gettxtdescripcion
        {
            get
            {
                return txtdescripcion;
            }
        }
        public Label getCoordinador
        {
            get
            {
                return txtcoordinador;
            }
        }
        public TextBox gettxtdescripcioncambio
        {
            get
            {
                return txtdescripcioncambio;
            }

        }
        public TextBox Txtprobfalla
        {
            get
            {
                return txtprobfalla;
            }

        }
        private void ReqCambios_Shown(object sender, EventArgs e)
        {
            llenarDatos();
            FormatodeUI();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Validaciones
            //if (cboTipCambio.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || cboCoordinador.SelectedIndex == -1)
            if (comboBox3.SelectedIndex == -1 || cboCoordinador.SelectedIndex == -1)
            {
                MessageBox.Show("Debe llenar todo los Campos de la seccion 'Asignacion'");
                return;
            }
            if (cboCoordinador.SelectedItem.ToString() == "Otros" && txtcoordinadorO.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del Coordinador");
                return;
            }

            /* (cboTipCambio.SelectedItem.ToString() == "Usual de Negocio" && txtcodbau.Text == "")
            {
                MessageBox.Show("Debe ingresar el codigo del Cambio Usual de Negocio");
                return;
            }*/

            //UPDATE Creacion de la variable RFC para update

            DTORfc rfc = new DTORfc();
            DAORFC dao = new DAORFC();

            rfc.Codigo = (Int32)Int32.Parse(txtcodigo.Text);
            rfc.Fecaceptacion = DateTime.Now;
            rfc.Nomaceptador = Environment.UserName;

            //rfc.Tipocambio = cboTipCambio.Text.ToString();
            //rfc.Cod_bau = txtcodbau.Text;
            rfc.Cateinfra = comboBox3.SelectedItem.ToString();
            rfc.Estado = "Aceptado";
            if (txtcoordinadorO.Text == "")
            {
                rfc.Coordinador = cboCoordinador.SelectedItem.ToString();
            }
            else
            {
                rfc.Coordinador = txtcoordinadorO.Text;
                //Agregar Coordinador
                DTOCoordinador coordinador = new DTOCoordinador();
                DAOCoordinador daocoor = new DAOCoordinador();
                coordinador.Nombre = rfc.Coordinador;
                coordinador.Area = rfc.Cateinfra;
                int l = daocoor.Insert(coordinador);
            }


            int x = dao.updateAceptar(rfc);

            if (x != 1)
            {
                MessageBox.Show("Error al Actualizar el RFC");
                return;
            }

            //Si el Cambio es BAU se Aprueba inmediatamente.
            /*if (rfc.Tipocambio == "Usual de Negocio")
            {
                rfc.Estado = "Aprobado";
                rfc.Aprobador = "BAU";
                rfc.Fecaprobacion = DateTime.Now;

                x = dao.updateAprobarBAU(rfc);
                if (x != 1)
                {
                    MessageBox.Show("Error al Aprobar el RFC");
                    return;
                }

            }

            if (rfc.Tipocambio == "Emergencia")
            {
                rfc.Estado = "Pendiente";
                rfc.Prioridad = "Inmediata";
                rfc.Tipocambio_normal = "";
                x = dao.updateGuardarAceptado(rfc);
                if (x != 1)
                {
                    MessageBox.Show("Error al Aprobar el RFC");
                    return;
                }

            }
            if (rfc.Tipocambio == "Excepcion")
            {
                rfc.Estado = "Pendiente";
                rfc.Prioridad = "Alto";
                rfc.Tipocambio_normal = "";
                x = dao.updateGuardarAceptado(rfc);
                if (x != 1)
                {
                    MessageBox.Show("Error al Aprobar el RFC");
                    return;
                }

            }*/

            //Enviar Correo de Categorización/Aceptación
            if (rfc.Tipocambio == "Usual de Negocio")
            {
                //sendemail(rfc.Coordinador + "@gromero.com.pe", "CAMBIO BAU Asignado COD: " + rfc.Codigo, "Estimado, <BR> Se le ha asignado como Coordinador para el cambio Usual de Negocio: "+rfc.Codigo+" .<BR> Porfavor notificar la finalización del cambio para el cierre del ticket.");
                //sendemail("ccabanillasd@gromero.com.pe", "CAMBIO BAU Asignado COD: " + rfc.Codigo, "Estimado, <BR> Se le ha asignado como Coordinador para el cambio Usual de Negocio con número: " + rfc.Codigo + " Descripción: " + txtdescripcion.Text + ".<BR> Porfavor notificar la finalización del cambio para el cierre del ticket.");
            }
            else
            {
                if (VariablesGlobales.ambienteDestino == "PRD")
                {
                    sendemail(rfc.Coordinador + "@gromero.com.pe", "CAMBIO Asignado COD: " + rfc.Codigo, "Estimado, <BR> Se le ha asignado como Coordinador para el cambio: " + rfc.Codigo + " . Solicitado por: " + txtsolicitante2.Text + "<BR> Nombre del cambio: " + txtdescripcion.Text + ".<BR> Descripción del Cambio: " + txtdescripcioncambio.Text);
                }
                
            }
                if (VariablesGlobales.ambienteDestino == "PRD")
                {
                    sendemail(txtcorreo.Text, "CAMBIO Aceptado RFC: " + rfc.Codigo, "Estimado, <BR> El cambio número: " + rfc.Codigo + " con descripcion: " + txtdescripcion.Text + " ha sido aceptado por el Gestor de Cambio.<BR> Se ha asignado como coordinador del cambio a: " + rfc.Coordinador + ".");
                }
            
            

            //Actualiza Estado


            txtestado.Text = rfc.Estado;
            //txttipcambios.Text = rfc.Tipocambio;
            txtcoordinador.Text = rfc.Coordinador;
            FormatodeUI();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        /* private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (comboBox1.SelectedIndex == 3)
             {
                 txttipocambio1.Text = "Emergencia";
             }
             else
             {
                 txtti
                 switch (comboBox2.SelectedIndex)
                 {
                     case 0:
                         txttipocambio1.Text = "Menor";
                         break;
                     case 1:
                         txttipocambio1.Text = "Medio";
                         break;
                     case 2:
                         txttipocambio1.Text = "Mayor";
                         break;
                 }
             }
         }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        public void guardar()
        {
            DTORfc rfc = new DTORfc();
            DAORFC dao = new DAORFC();

            rfc.Codigo = (Int32)int.Parse(txtcodigo.Text);
            rfc.Estado = txtestado.Text;

            //Pendiente
            #region

            if (rfc.Estado == "Pendiente")
            {
                rfc.Ejecutornombre = txtejecutor.Text;
                rfc.Ejecutorequipo = txtejecutorequi.Text;
                rfc.Codatenciontercero = txtcodatencion.Text;

                if (!File.Exists(@"\\corjsmsrv1.grupocogesa.gromero.net\Publico\PublicoCSC\#TI\Repositorio-RFC\Planes-GestionCambios\RFC" + rfc.Codigo + ".xlsx") && !File.Exists(@"\\corjsmsrv1.grupocogesa.gromero.net\Publico\PublicoCSC\#TI\Repositorio-RFC\Planes-GestionCambios\RFC" + rfc.Codigo + ".xls"))
                {
                    if (txtlink.Text != "")
                    {
                        if (txtlink.Text.Substring(txtlink.Text.Length - 1, 1).Equals("x"))
                        {
                            File.Copy(txtlink.Text, @"\\corjsmsrv1.grupocogesa.gromero.net\Publico\PublicoCSC\#TI\Repositorio-RFC\Planes-GestionCambios\RFC" + rfc.Codigo + ".xlsx");
                            txtlink.Text = @"\\corjsmsrv1.grupocogesa.gromero.net\Publico\PublicoCSC\#TI\Repositorio-RFC\Planes-GestionCambios\RFC" + rfc.Codigo + ".xlsx";
                        }
                        else
                        {
                            File.Copy(txtlink.Text, @"\\corjsmsrv1.grupocogesa.gromero.net\Publico\PublicoCSC\#TI\Repositorio-RFC\Planes-GestionCambios\RFC" + rfc.Codigo + ".xls");
                            txtlink.Text = @"\\corjsmsrv1.grupocogesa.gromero.net\Publico\PublicoCSC\#TI\Repositorio-RFC\Planes-GestionCambios\RFC" + rfc.Codigo + ".xls";
                        }

                       
                    
                    }


                }

                if (comboBox1.SelectedIndex > -1 && txtimpacto.Text != "" && cboTipCambio.SelectedIndex > -1)
                {
                    rfc.Tipocambio_normal = txtimpacto.Text;
                    rfc.Tipocambio = cboTipCambio.SelectedItem.ToString();
                    rfc.Prioridad = comboBox1.SelectedItem.ToString();
                    txttipcambios.Text = rfc.Tipocambio_normal;
                    txtcatecambio.Text = rfc.Tipocambio;
                    btnimpacto.Enabled = false;
                    cboTipCambio.Enabled = false;
                    comboBox1.Enabled = false;
                }


                if (radioButtonIndSI.Checked)
                {
                    rfc.Indisponibilidad = 1;
                }
                else
                {
                    rfc.Indisponibilidad = 0;
                }
                rfc.PlanTrabajo = 0;
                rfc.PlanContigencia = 0;
                rfc.PlanPruebas = 0;

                

                rfc.Personasacomunicar = txtcomunicacion.Text;
                rfc.Rutaplan = txtlink.Text;
                rfc.Fecprogramadaejecucion = dateTimePickerIni.Value;
                rfc.Fecprogramadafinalizacion = dateTimePickerFin.Value;
                if (txtprobfalla.Text != "")
                {
                   // rfc.Probfalla = (Int32)Int32.Parse(txtprobfalla.Text);

                    if (txtprobfalla.Text == "Alto")
                    {
                        rfc.Probfalla = 1;
                    }
                    if (txtprobfalla.Text == "Medio")
                    {
                        rfc.Probfalla = 2;
                    }

                    if (txtprobfalla.Text == "Bajo")
                    {
                        rfc.Probfalla = 3;
                    }




                    //rfc.Probfalla = 3 - cbopreparacion.SelectedIndex;

                    DTOProbFalla probfalla = new DTOProbFalla();
                    DAOProbFalla daoprob = new DAOProbFalla();

                    probfalla.Codigo = rfc.Codigo;
                    probfalla.Cod_pre_elabo = cboimp2;
                    probfalla.Cod_reu_coor = cboimp1;
                    probfalla.Cod_recu_ejecu = cboimp6;

                    daoprob.Delete(rfc.Codigo);
                    daoprob.Insert(probfalla);
                }


                //if (v_ini == 0 || v_ini == -1)
                //{                

                    if (dateTimePickerIni.Text != dateTimePickerFin.Text)
                    {
                        int ini = DateTime.Compare(rfc.Fecprogramadaejecucion, rfc.Fecprogramadafinalizacion);
                        if (ini != -1)
                        {
                            MessageBox.Show("Fecha Fin Programado debe ser mayor a la Fecha Inicio.");
                            return;
                        }
                        else
                        {
                           // int now = DateTime.Compare(DateTime.Now, rfc.Fecprogramadaejecucion);
                           // if (now != -1)
                           // {
                           //     MessageBox.Show("Fecha Inicio Programado debe ser mayor a la Fecha Actual.");
                           //     return;
                           // }
                        }
                    }


                    dao.updateGuardarPendiente(rfc);

                    int x = 1;

                    DAORiesgo daor = new DAORiesgo();
                    daor.Delete(rfc.Codigo);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            DTORiesgo riesgo = new DTORiesgo();
                            riesgo.Rfc = (Int32)int.Parse(txtcodigo.Text);
                            riesgo.Codigo = x;
                            riesgo.Titulo = row.Cells[0].Value.ToString();
                            riesgo.Impacto = ValorRiesgo(row.Cells[1].Value.ToString());
                            daor.Insert(riesgo);
                            x++;
                        }


                    }


                //}
                /*else
                {
                    MessageBox.Show("Fecha Inicio Programado debe ser mayor a la Fecha Actual.");
                }*/



            }
            #endregion

            //Aceptado
            #region
            if (rfc.Estado == "Aceptado")
            {

                if (comboBox1.SelectedIndex > -1)
                {
                    rfc.Prioridad = comboBox1.SelectedItem.ToString();
                }

                if (txtimpacto.Text == "Usual del Negocio")
                {
                    if (MessageBox.Show("¿Estás seguro de no proponer el Cambio como Usual de Negocio?. Durante este Proceso el cambio sera tratado como menor.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        txtimpacto.Text = "Menor";
                    }
                }

                if (cboTipCambio.SelectedIndex > -1)
                {
                    rfc.Tipocambio = cboTipCambio.SelectedItem.ToString();
                }

                if (comboBox1.SelectedIndex > -1 && txtimpacto.Text != "" && cboTipCambio.SelectedIndex > -1)
                {
                    rfc.Estado = "Pendiente";
                    rfc.Tipocambio_normal = txtimpacto.Text;

                    txttipcambios.Text = rfc.Tipocambio_normal;
                    txtcatecambio.Text = rfc.Tipocambio;
                    txtestado.Text = "Pendiente";
                    btnimpacto.Enabled = false;

                    dao.updateGuardarAceptado(rfc);
                }
              
                if (txtestado.Text == "Pendiente")
                {
                    FormatodeUI();
                }


            }
            #endregion

            //Cerrar
            #region
            if (rfc.Estado == "Cerrado")
            {
                rfc.Estado = "Revisado";
                if (radioButtonconSI.Checked)
                {
                    rfc.Cambiosatifactorio = 1;
                }
                else
                {
                    rfc.Cambiosatifactorio = 0;
                }
                rfc.Detalrevision = txtobs.Text;
                if (radioButtonproSI.Checked)
                {
                    rfc.Volvioprocedimiento = 1;
                }
                else
                {
                    rfc.Volvioprocedimiento = 0;
                }
                rfc.Fecrevisionfinal = DateTime.Now;
                rfc.Revisador = Environment.UserName;
                dao.updateGuardarCierre(rfc);
                txtestado.Text = "Revisado";
                FormatodeUI();
            }
            #endregion

            //Aprobado_Solocuandoeditas
            #region
            if (rfc.Estado == "Aprobado")
            {
                String tipoCambioactual = txtcatecambio.Text;
                String CategoriaCambioactual = txttipcambios.Text;
                String tipoCambionuevo = cboTipCambio.SelectedItem.ToString();
                String CategoriaCambionuevo = txtimpacto.Text;
                Boolean modifica = false;

                if (tipoCambioactual.Equals(tipoCambionuevo))
                {
                    if (CategoriaCambioactual.Equals(CategoriaCambionuevo))
                    {
                        modifica = false;
                    }
                    else
                    {
                        if (CategoriaCambionuevo.Equals("Menor") && !CategoriaCambioactual.Equals("Menor"))
                        {
                            modifica = true;
                        }

                        if (!CategoriaCambionuevo.Equals("Menor") && CategoriaCambioactual.Equals("Menor"))
                        {
                            modifica = true;
                        }
                    }
                }
                else
                {
                    modifica = true;
                }


                Boolean ok = true;

                if (modifica)
                {
                    DialogResult dr = MessageBox.Show("El cambio se va desapruebar ¿Quieres continuar?",
                    "Confirmación", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            ok = true;
                            break;
                        case DialogResult.No:
                            ok = false;
                            break;
                    }
                }

                if (ok)
                {
                    rfc.Tipocambio_normal = CategoriaCambionuevo;
                    rfc.Prioridad = comboBox1.SelectedItem.ToString();
                    rfc.Tipocambio = tipoCambionuevo;

                    if (modifica)
                    {
                        dao.updateRetrocederAprobacion(rfc);
                       txtestado.Text = "Pendiente";
                    }

                    dao.updateGuardarAceptado(rfc);

                    comboBox1.Enabled = false;
                    btnimpacto.Enabled = false;
                    cboTipCambio.Enabled = false;
                    toolStripButton3.Enabled = false;
                    btneditarcate.Visible = true;

                    txtcatecambio.Text = rfc.Tipocambio;
                    txttipcambios.Text = rfc.Tipocambio_normal;

                }

             
                
                //rfc.Estado = "Cerrado";

                //rfc.Fecharealejecucion = dateTimePickerIniReal.Value;
                //rfc.Fecharealfinalizacion = dateTimePickerFinReal.Value;

                //if (cboResultado.SelectedIndex < 0)
                //{
                //    MessageBox.Show("Seleccione una opcion de resultado del cambio.");
                //    return;
                //}
                //rfc.Tipo_finalizacion = cboResultado.SelectedItem.ToString();



                //rfc.Incidenteseje = txtincidenteseje.Text;
                //if (radioButtonrollSI.Checked)
                //{
                //    rfc.Rollback = 1;
                //    rfc.Fecrollback = dateTimePickerRoll.Value;
                //    rfc.Autorizarollback = txtrollautorizador.Text;
                //}
                //else
                //{
                //    rfc.Rollback = 1;
                //    rfc.Fecrollback = new DateTime(1900, 01, 01, 00, 00, 00);
                //    rfc.Autorizarollback = "";
                //}


                //if (radioButtonPruSI.Checked)
                //{
                //    rfc.Prueba = 1;
                //}
                //else
                //{
                //    rfc.Prueba = 0;
                //}
                //if (radioButtonPrucSI.Checked)
                //{
                //    rfc.ConformidadPrueba = 1;
                //}
                //else
                //{
                //    rfc.ConformidadPrueba = 0;
                //}

                //rfc.Incidenteprue = txtincipruebas.Text;
                //rfc.Feccierre = DateTime.Now;

                //dao.updateGuardarAprobado(rfc);
                //txtestado.Text = "Cerrado";

                //if (txttipcambios.Text == "Usual de Negocio")
                //{
                //    rfc.Estado = "Revisado";
                //    rfc.Cambiosatifactorio = 1;
                //    rfc.Detalrevision = "";
                //    rfc.Volvioprocedimiento = 0;
                //    rfc.Fecrevisionfinal = DateTime.Now;
                //    rfc.Revisador = Environment.UserName;
                //    dao.updateGuardarCierre(rfc);
                //    txtestado.Text = "Revisado";
                //}

                //FormatodeUI();
            }
            #endregion
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Agregar Plan")
            {

                string Chosen_File = "";
                openFileDialog1.Title = "Ingresa la Solicitud";
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "Archivos Excel *.xls|*.xls*";
                openFileDialog1.ShowDialog();

                Chosen_File = openFileDialog1.FileName;

                if (Chosen_File == "")
                {
                    MessageBox.Show("No ha Seleccionado ningun Archivo");
                }
                else
                {
                    Excel.Application xlApp;
                    Excel.Workbook xlWorkBook;
                    //Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Open(Chosen_File, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                    //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);

                    if (Chosen_File.Substring(Chosen_File.Length - 1, 1).Equals("x"))
                    {
                        if (VariablesGlobales.ambienteDestino == "DEV")
                        {
                            xlWorkBook.SaveCopyAs(@"D:\AppCambios\Planes\RFC" + txtcodigo.Text + ".xlsx");
                            txtlink.Text = @"D:\AppCambios\Planes\RFC" + txtcodigo.Text + ".xlsx";
                        }
                        else
                        {
                            xlWorkBook.SaveCopyAs(@"\\corjsmsrv1.grupocogesa.gromero.net\Publico\PublicoCSC\#TI\Repositorio-RFC\Planes-GestionCambios\RFC" + txtcodigo.Text + ".xlsx");
                            txtlink.Text = @"\\corjsmsrv1.grupocogesa.gromero.net\Publico\PublicoCSC\#TI\Repositorio-RFC\Planes-GestionCambios\RFC" + txtcodigo.Text + ".xlsx";
                        }                               
                    }
                    else
                    {
                        if (VariablesGlobales.ambienteDestino == "DEV")
                        {
                            xlWorkBook.SaveCopyAs(@"D:\AppCambios\Planes\RFC" + txtcodigo.Text + ".xls");
                            txtlink.Text = @"D:\AppCambios\Planes\RFC" + txtcodigo.Text + ".xls";
                        }
                        else
                        {
                            xlWorkBook.SaveCopyAs(@"\\corjsmsrv1.grupocogesa.gromero.net\Publico\PublicoCSC\#TI\Repositorio-RFC\Planes-GestionCambios\RFC" + txtcodigo.Text + ".xls");
                            txtlink.Text = @"\\corjsmsrv1.grupocogesa.gromero.net\Publico\PublicoCSC\#TI\Repositorio-RFC\Planes-GestionCambios\RFC" + txtcodigo.Text + ".xls";
                        }
                        
                       

                    }

                    //txtlink.Text = Chosen_File;
                    button1.Text = "Consultar Plan";
                    xlWorkBook.Close(false, misValue, misValue);
                    xlApp.Quit();

                    //releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);

                }

               
            }
            else
            {
                // Excel.Application xlApp;
                // Excel.Workbook xlWorkBook;
                //Excel.Worksheet xlWorkSheet;
                //object misValue = System.Reflection.Missing.Value;

                //xlApp = new Excel.Application();
                //xlWorkBook = xlApp.Workbooks.Open(txtlink.Text, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

                FileInfo fi = new FileInfo(txtlink.Text);
                if (fi.Exists)
                {
                    System.Diagnostics.Process.Start(txtlink.Text);
                }
                else
                {
                    //file doesn't exist
                }
            }


        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int ValorRiesgo(string valor)
        {
            int v = -1;

            if (valor == "Bajo")
            {
                v = 3;
            }
            if (valor == "Medio")
            {
                v = 2;
            }
            if (valor == "Alto")
            {
                v = 1;
            }
            return v;
        }
        private int ValorRiesgoFinal(string valor)
        {
            int v = -1;

            if (valor == "Alto")
            {
                v = 1;
            }
            if (valor == "Medio Alto")
            {
                v = 2;
            }
            if (valor == "Medio Bajo")
            {
                v = 3;
            }
            if (valor == "Bajo")
            {
                v = 4;
            }
            return v;
        }
        private string ValorRiesgoInverso(int valor)
        {
            string v = "";

            if (valor == 1)
            {
                v = "Alto";
            }
            if (valor == 2)
            {
                v = "Medio";
            }

            if (valor == 3)
            {
                
                v = "Bajo";
            }
            return v;
        }
        private string ValorRiesgoFinalInverso(int valor)
        {
            string v = "";

            if (valor == 1)
            {
                v = "Alto";
            }
            if (valor == 2)
            {
                v = "Medio Alto";
            }
            if (valor == 3)
            {
                v = "Medio Bajo";
            }
            if (valor == 4)
            {
                v = "Bajo";
            }
            return v;
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           /* int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if (rowIndex != -1 && colIndex != 0)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                if (row.Cells[1].Value != null)
                {
                    actualizarriesgo();
                }

            }*/
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DTORfc rfc = new DTORfc();
            DAORFC dao = new DAORFC();
            rfc.Codigo = (Int32)int.Parse(txtcodigo.Text);
            rfc.Tipocambio_normal = txttipcambios.Text;
            rfc.Tipocambio = txtcatecambio.Text;

            /*int ini = DateTime.Compare(DateTime.Now, rfc.Fecprogramadaejecucion);

            if (ini == -1)
            {
                if (dateTimePickerIni.Text == dateTimePickerFin.Text)
                {

                    MessageBox.Show("Fecha Inicio y Fin Programado no pueden ser las mismas.");
                    return;
                }
                else
                {
                    int valor = DateTime.Compare(rfc.Fecprogramadaejecucion, rfc.Fecprogramadafinalizacion);
                    if (valor != -1) 
                    {
                        MessageBox.Show("Fecha Fin Programado debe ser mayor a la Fecha Inicio.");
                        return;
                    }


                }
            }
            else
            {
                MessageBox.Show("Fecha Inicio debe ser mayor a la Fecha Actual.");
                return;
            }*/

            if (dateTimePickerIni.Text != dateTimePickerFin.Text)
            {
                int ab = DateTime.Compare(dateTimePickerIni.Value, dateTimePickerFin.Value);
                if (ab != -1)
                {
                    MessageBox.Show("Fecha Fin Programado debe ser mayor a la Fecha Inicio.");
                    return;
                }
                /*else
                {
                    int bc = DateTime.Compare(DateTime.Now, dateTimePickerIni.Value);
                    if (bc != -1)
                    {
                        MessageBox.Show("Fecha Inicio Programado debe ser mayor a la Fecha Actual.");
                        return;
                    }
                }*/
            }
            else
            {
                MessageBox.Show("Fecha Inicio y Fin Programado no deben ser iguales.");
                return;
            }

            if (txtcomunicacion.Text == "")
            {
                MessageBox.Show("Se debe contar con un plan de Comunicación");
                return;
            }
            if (rfc.Tipocambio == "Usual de Negocio")
            {
                guardar();
                rfc.Estado = "Aprobado";
                rfc.Aprobador = Environment.UserName;
                rfc.Fecaprobacion = DateTime.Now;

                if (dao.updateAprobarMenor(rfc) > 0)
                {
                    txtestado.Text = "Aprobado";
                    FormatodeUI();

                    string titulo = txtcodigo.Text + " - " + txtdescripcion.Text;


                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Coordinador: " + txtcoordinador.Text);
                    sb.AppendLine(" Descripcion: " + txtdescripcioncambio.Text);
                    if (txtlink.Text != "")
                    {
                        sb.AppendLine(" Ruta del Plan: " + txtlink.Text);
                    }

                    if (VariablesGlobales.ambienteDestino == "PRD")
                    {
                        CreateMeetingRequest("ccabanillasd@gromero.com.pe", titulo, sb.ToString(), dateTimePickerIni.Value, dateTimePickerFin.Value);
                    }

                }

            }
            if (rfc.Tipocambio == "Normal")
            {
                if (rfc.Tipocambio_normal == "Menor")
                {
                        guardar();
                        rfc.Estado = "Aprobado";
                        rfc.Aprobador = Environment.UserName;
                        rfc.Fecaprobacion = DateTime.Now;

                        if (dao.updateAprobarMenor(rfc) > 0)
                        {
                            txtestado.Text = "Aprobado";
                            FormatodeUI();

                            string titulo = txtcodigo.Text + " - " + txtdescripcion.Text;


                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("Coordinador: " + txtcoordinador.Text);
                            sb.AppendLine(" Descripcion: " + txtdescripcioncambio.Text);
                            if (txtlink.Text != "")
                            {
                                sb.AppendLine(" Ruta del Plan: " + txtlink.Text);
                            }

                            if (VariablesGlobales.ambienteDestino == "PRD")
                            {
                                CreateMeetingRequest("ccabanillasd@gromero.com.pe", titulo, sb.ToString(), dateTimePickerIni.Value, dateTimePickerFin.Value);
                            }
                            
                        }

                }
                else
                {
                    if (txtlink.Text == "")
                    {
                        MessageBox.Show("Para Cambios Medios y Mayores se debe contar con los 3 planes.");
                        return;
                    }

                    if (txtriesgo.Text == "")
                    {
                        MessageBox.Show("Se debe Tener un analisis de Riesgo para Cambios Medios/Mayores");
                        return;
                    }
                       
                    cac formaprobacion = new cac(this);
                    formaprobacion.Text = "Aprobado Por:";
                    formaprobacion.getGrupoMedioMayor.Visible = true;
                    formaprobacion.getGrupoEmergencia.Visible = false;
                    formaprobacion.getGrupoMedioMayor.Location = new Point(12, 12);
                    formaprobacion.getGrupoEmergencia.Location = new Point(12, 155);
                    formaprobacion.Show();

                }
            }

            if (rfc.Tipocambio == "Emergencia")
            {
                    cac formaprobacion = new cac(this);
                    formaprobacion.Text = "Aprobado Por:";
                    formaprobacion.getGrupoEmergencia.Visible = true;
                    formaprobacion.getGrupoMedioMayor.Visible = false;
                    formaprobacion.getGrupoEmergencia.Location = new Point(12, 12);
                    formaprobacion.getGrupoMedioMayor.Location = new Point(12, 155);
                    formaprobacion.Show();
                
            }

            if (rfc.Tipocambio == "Excepcion")
            {
                //if (txtlink.Text == "")
                //{
                //    MessageBox.Show("Para Cambios de Excepción se debe contar con el Plan de Trabajo y Pruebas.");
                //}
                //else
                //{
                    if (txtcomunicacion.Text == "")
                    {
                        MessageBox.Show("Se debe contar con un plan de Comunicación");
                        return;
                    }
                   
                        if (txtriesgo.Text == "")
                        {
                            MessageBox.Show("Se debe Tener un analisis de Riesgo para Cambios de Excepción");
                        }
                        else
                        {
                            cac formaprobacion = new cac(this);
                            formaprobacion.Text = "Aprobado Por:";
                            formaprobacion.getGrupoEmergencia.Visible = false;
                            formaprobacion.getGrupoMedioMayor.Visible = false;
                            formaprobacion.getGroupBoxExcepcion.Visible = true;
                            formaprobacion.getGroupBoxExcepcion.Location = new Point(12, 12);
                            formaprobacion.getGrupoMedioMayor.Location = new Point(12, 155);
                            formaprobacion.Show();
                        }
                    
                //}

                
            }
            /*
            if (rfc.Tipocambio == "Medio" || rfc.Tipocambio == "Mayor" || rfc.Tipocambio == "Crítico")
            {
                //if (checkedListBox1.CheckedItems.Count != 3 || txtlink.Text == "")
                if(txtlink.Text == "")
                {
                    MessageBox.Show("Para Cambios Medios y Mayores se debe contar con los 3 planes.");
                }
                else
                {
                    if (txtcomunicacion.Text == "")
                    {
                        MessageBox.Show("Se debe contar con un plan de Comunicación");
                    }
                    else
                    {
                        if (txtriesgo.Text == "")
                        {
                            MessageBox.Show("Se debe Tener un analisis de Riesgo para Cambios Medios/Mayores");
                        }
                        else
                        {
                            cac formaprobacion = new cac(this);
                            formaprobacion.Text = "Aprobado Por:";
                            formaprobacion.getGrupoMedioMayor.Visible = true;
                            formaprobacion.getGrupoEmergencia.Visible = false;
                            formaprobacion.getGrupoMedioMayor.Location = new Point(12, 12);
                            formaprobacion.getGrupoEmergencia.Location = new Point(12, 155);
                            formaprobacion.Show();
                        }
                    }
                }
            }*/
           
        }
        public static void CreateMeetingRequest(string toEmail, string subject, string body, DateTime startDate, DateTime endDate)
        {
            Microsoft.Office.Interop.Outlook.Application objOL = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.AppointmentItem objAppt = (Microsoft.Office.Interop.Outlook.AppointmentItem)objOL.CreateItem(Outlook.OlItemType.olAppointmentItem);

            objAppt.Start = startDate;
            objAppt.End = endDate;
            objAppt.Subject = subject;
            //objAppt.Duration = 60;
            objAppt.Body = body;
            // objAppt.Categories = "Aplicaciones";

            //objAppt.SendUsingAccount = objOL.Session.Accounts["gestiondecambiosgr@gromero.com.pe"];

            objAppt.MeetingStatus = Microsoft.Office.Interop.Outlook.OlMeetingStatus.olMeeting;
            objAppt.RequiredAttendees = "gestiondecambiosgr@gromero.com.pe";
            ((Microsoft.Office.Interop.Outlook._AppointmentItem)objAppt).Send();
            objAppt = null;
            objOL = null;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //guardar();
            //txtestado.Text = "Cerrado";
            //FormatodeUI();

            DTORfc rfc = new DTORfc();
            DAORFC dao = new DAORFC();

            rfc.Codigo = (Int32)int.Parse(txtcodigo.Text);
            rfc.Estado = txtestado.Text;


            rfc.Estado = "Cerrado";

            rfc.Fecharealejecucion = dateTimePickerIniReal.Value;
            rfc.Fecharealfinalizacion = dateTimePickerFinReal.Value;

            if (cboResultado.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una opcion de resultado del cambio.");
                return;
            }
            rfc.Tipo_finalizacion = cboResultado.SelectedItem.ToString();



            rfc.Incidenteseje = txtincidenteseje.Text;
            if (radioButtonrollSI.Checked)
            {
                rfc.Rollback = 1;
                rfc.Fecrollback = dateTimePickerRoll.Value;
                rfc.Autorizarollback = txtrollautorizador.Text;
            }
            else
            {
                rfc.Rollback = 1;
                rfc.Fecrollback = new DateTime(1900, 01, 01, 00, 00, 00);
                rfc.Autorizarollback = "";
            }


            if (radioButtonPruSI.Checked)
            {
                rfc.Prueba = 1;
            }
            else
            {
                rfc.Prueba = 0;
            }
            if (radioButtonPrucSI.Checked)
            {
                rfc.ConformidadPrueba = 1;
            }
            else
            {
                rfc.ConformidadPrueba = 0;
            }

            rfc.Incidenteprue = txtincipruebas.Text;
            rfc.Feccierre = DateTime.Now;

            dao.updateGuardarAprobado(rfc);
            txtestado.Text = "Cerrado";

            if (txttipcambios.Text == "Usual de Negocio")
            {
                rfc.Estado = "Revisado";
                rfc.Cambiosatifactorio = 1;
                rfc.Detalrevision = "";
                rfc.Volvioprocedimiento = 0;
                rfc.Fecrevisionfinal = DateTime.Now;
                rfc.Revisador = Environment.UserName;
                dao.updateGuardarCierre(rfc);
                txtestado.Text = "Revisado";
            }

            FormatodeUI();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormRechazo formaprobacion = new FormRechazo(this);
            formaprobacion.Show();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de eliminar la solicitud?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTORfc rfc = new DTORfc();
                DTOSolicitud solicitud = new DTOSolicitud();

                DAORFC dao = new DAORFC();
                DAOSolicitud daos = new DAOSolicitud();

                rfc.Codigo = (Int32)int.Parse(txtcodigo.Text);
                if (dao.delete(rfc) > 0)
                {
                    solicitud.Codigo = rfc.Codigo;
                    daos.delete(solicitud);
                    MessageBox.Show("Eliminado con Exito");
                }


            }
        }

        private void btnimpacto_Click(object sender, EventArgs e)
        {
            CalImpacto c = new CalImpacto(this);
            c.Show();
        }

        private void txtimpacto_TextChanged(object sender, EventArgs e)
        {
            if (txtimpacto.Text == "Usual del Negocio")
            {
                btnproponer.Visible = true;
            }
            else
            {
                btnproponer.Visible = false;

            }
        }

        private void txtcodasociado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtestado_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txttipocambio1_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void cboCoordinador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCoordinador.SelectedItem.ToString() == "Otros")
            {
                txtcoordinadorO.Visible = true;
                label47.Visible = true;
            }
            else
            {
                txtcoordinadorO.Visible = false;
                txtcoordinadorO.Text = "";
                label47.Visible = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCoordinador.Items.Clear();
            cboCoordinador.SelectedText = "";
            DTOCoordinador dtoc = new DTOCoordinador();
            DAOCoordinador daoc = new DAOCoordinador();
            dtoc.Area = comboBox3.SelectedItem.ToString();
            DataSet ds;
            ds = daoc.select(dtoc);
            if (ds != null && ds.Tables[0].Rows.Count != 0)
            {
                DataTable dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    cboCoordinador.Items.Add(Convert.ToString(row[1]));
                }
            }
            cboCoordinador.Items.Add("Otros");

        }

        private void txtcodatencion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void txtproveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTipCambio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipCambio.SelectedItem.ToString() == "Usual de Negocio")
            {
                //txtcodbau.Visible = true;
                //label48.Visible = true;
                //btnbusbau.Visible = true;
            }
            else
            {
                //txtcodbau.Visible = false;
                //txtcodbau.Text = "";
                //label48.Visible = false;
                //btnbusbau.Visible = false;
            }
        }


        private void sendemail(string tomail, string subject, string body)
        {
            MailMessage mail = new MailMessage("gestiondecambiosgr@gromero.com.pe", tomail);
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("gestiondecambiosgr@gromero.com.pe", "PeruRusia2018");
            client.Host = "smtp.office365.com";
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Cambio ha sido propuesto para que en el Futuro sea un Cambio Usual de Negocio. Por ahora sera tratado como un Cambio Menor.");
            sendemail("ccabanillasd@gromero.com.pe", "Cambio Nr: " + txtcodigo.Text + " Ha sido propuesto como BAU.", "Estimado, <br> El coordinador: " + cboCoordinador.SelectedItem.ToString() + " ha propuesto el cambio Nro: " + txtcodigo.Text + " como un cambio usual de negocio");
            txtimpacto.Text = "Menor";
        }

        private void btnprobabilidad_Click(object sender, EventArgs e)
        {
            CalProbabilidad formprobabilidad = new CalProbabilidad(this);

            if (txtprobfalla.Text != "")
            {
                formprobabilidad.Cboimp1.SelectedIndex = cboimp1;
                formprobabilidad.Cboimp2.SelectedIndex = cboimp2;
                formprobabilidad.Cboimp6.SelectedIndex = cboimp6;  
            }


            formprobabilidad.Show();

        }

        private void actualizarriesgo()
        {
           // int rowsactivated = 0;
            //Int32 valor = 0;
            int resultado = 0;
            //string texto = "";

            if (txtprobfalla.Text == "Alto")
            {
                resultado = resultado + 1;
            }
            if (txtprobfalla.Text == "Medio")
            {
                resultado = resultado + 2;
            }
            if (txtprobfalla.Text == "Bajo")
            {
                resultado = resultado + 3;
            }

            if (txttipcambios.Text == "Crítico" || txttipcambios.Text == "Mayor")
            {
                resultado = resultado + 1;
            }
            if (txttipcambios.Text == "Medio")
            {
                resultado = resultado + 2;
            }
            if (txttipcambios.Text == "Menor" || txttipcambios.Text == "Usual del Negocio")
            {
                resultado = resultado + 3;
            }

            resultado = resultado- 1;
            txtriesgo.Text = resultado.ToString();

            /*
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells[1].Value != null)
                {
                    texto = row.Cells[1].Value.ToString();
                }
                else
                {
                    texto = "";
                }

                if (texto == "Bajo")
                {
                    valor = valor + 3;
                    rowsactivated++;
                }
                else if (texto == "Medio")
                {
                    valor = valor + 2;
                    rowsactivated++;
                }
                else if (texto == "Alto")
                {
                    valor = valor + 1;
                    rowsactivated++;
                }
            }
            
            if (txtprobfalla.Text == "")
            {
                rowsactivated = 0;
            }

            if (rowsactivated > 0)
            {
                valor = valor / rowsactivated;

                resultado = valor + (Int32)Int32.Parse(txtprobfalla.Text) - 1;
                //resultado = valor + (3-cbopreparacion.SelectedIndex)- 1;
                txtriesgo.Text = resultado.ToString();

            }
            */
        }

        private void txtprobfalla_TextChanged(object sender, EventArgs e)
        {
            actualizarriesgo();
        }

        private void ReqCambios_Deactivate(object sender, EventArgs e)
        {

        }

        private void txtriesgo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarriesgo();
        }

        private void ReqCambios_Load(object sender, EventArgs e)
        {

        }

        private void txtsolicitante2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbusbau_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnreprogramar_Click(object sender, EventArgs e)
        {
            dateTimePickerIni.Enabled = true;
            dateTimePickerFin.Enabled = true;
            btnreprogramar.Visible = false;
            btnsaverepro.Visible = true;
            cboMotivoReprogramacion.Visible = true;
            lblmotivo.Visible = true;

        }

        private void btnsaverepro_Click(object sender, EventArgs e)
        {

            DTORfc rfc = new DTORfc();
            DAORFC dao = new DAORFC();
            DataTable dt = new DataTable();
            DTOLogreprogramacion log = new DTOLogreprogramacion();
            DAOLogreprogramacion daolog = new DAOLogreprogramacion();

            rfc.Codigo = (Int32)Int32.Parse(txtcodigo.Text);
            dt = dao.select(rfc).Tables[0];

            if (dt.Rows[0]["fecprogramadaejecucion"].ToString() != "")
            {
                rfc.Fecprogramadaejecucion = DateTime.Parse(dt.Rows[0]["fecprogramadaejecucion"].ToString());
            }
            if (dt.Rows[0]["fecprogramadafinalizacion"].ToString() != "")
            {
                rfc.Fecprogramadafinalizacion = DateTime.Parse(dt.Rows[0]["fecprogramadafinalizacion"].ToString());
            }


            if (rfc.Fecprogramadaejecucion == dateTimePickerIni.Value && rfc.Fecprogramadafinalizacion == dateTimePickerFin.Value)
            {
                MessageBox.Show("No estas variando las fechas");
                return;
            }

            if (cboMotivoReprogramacion.SelectedIndex < 0)
            {
                MessageBox.Show("Ingresa un motivo");
                return;
            }

            log.Codigo = rfc.Codigo;
            log.FecIniAntLogReprogramacion = rfc.Fecprogramadaejecucion;
            log.FecFinAntLogReprogramacion = rfc.Fecprogramadafinalizacion;
            log.FecIniPosLogReprogramacion = dateTimePickerIni.Value;
            log.FecFinPosLogReprogramacion = dateTimePickerFin.Value;
            log.MotivoLogReprogramacion = cboMotivoReprogramacion.SelectedItem.ToString();

            rfc.Fecprogramadaejecucion = dateTimePickerIni.Value;
            rfc.Fecprogramadafinalizacion = dateTimePickerFin.Value;

            if (dao.updateReprogramacion(rfc) > 0)
            {
                
                
                daolog.Insert(log);
            }
            else
            {
                MessageBox.Show("Error al Actualizar");
            }


            dateTimePickerIni.Enabled = false;
            dateTimePickerFin.Enabled = false;
            btnreprogramar.Visible = true;
            btnsaverepro.Visible = false;
            lblmotivo.Visible = false;
            cboMotivoReprogramacion.Visible = false;

            MessageBox.Show("No te olvides de actualizar la reunion en el calendario.");

        }

        private void dateTimePickerIni_ValueChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btneditarcate_Click(object sender, EventArgs e)
        {
            if (txtestado.Text.Equals("Pendiente"))
            {
                comboBox1.Enabled = true;
                btnimpacto.Enabled = true;
                cboTipCambio.Enabled = true;
                btneditarcate.Visible = false;
            }

            if (txtestado.Text.Equals("Aprobado"))
            {
                DialogResult dr = MessageBox.Show("Es probable que el cambio se desapruebe ¿Quieres continuar?",
                      "Confirmación", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes: 
                           comboBox1.Enabled = true;
                           btnimpacto.Enabled = true;
                           cboTipCambio.Enabled = true;
                           toolStripButton3.Enabled = true;
                           btneditarcate.Visible = false;
                        break;
                    case DialogResult.No: break;
                }
            }
        }
    }
}
