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
using Microsoft.Office.Interop.Outlook;
using DAOLibrary.DAO;
using DAOLibrary.DTO;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace AppCambios
{
    public partial class cac : Form
    {
        ReqCambios rq;
        public cac(ReqCambios rq)
        {
            InitializeComponent();
            this.rq = rq;
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (txtcorraporemer.Text == "" && txtcorraporexce.Text == "" && txtcorreocomite.Text == "")
            {
                MessageBox.Show("Adjuntar el Correo de Aprobacion");
                return;
            }
            string targetPath ="";

            if (VariablesGlobales.ambienteDestino == "PRD")
            {
                targetPath = @"\\corjsmsrv1.grupocogesa.gromero.net\Publico\PublicoCSC\#TI\Repositorio-RFC\Correos-Aprobacion";
            }
            else
            {
                targetPath = @"D:\AppCambios\Aprobacion";
            }
            


            string destFile = System.IO.Path.Combine(targetPath, "RFC" + rq.getCodigo.Text + ".msg");

            if (groupBoxEmergencia.Visible == true)
            {
                if (comboBoxAprobador.SelectedIndex == -1 || txtincidente.Text == "")
                {
                    MessageBox.Show("Porfavor ingresar todo los datos");
                    return;
                }

                rq.guardar();

                DAORFC dao = new DAORFC();
                DTORfc rfc = new DTORfc();
                rfc.Codigo =(Int32)int.Parse(rq.getCodigo.Text);
                rfc.Estado = "Aprobado";
                //rfc.Aprobador = comboBoxAprobador.ValueMember.ToString();
                rfc.Aprobador = comboBoxAprobador.SelectedItem.ToString();
                rfc.Fecaprobacion = dateTimePickerAprobacion.Value;
                rfc.Motivo = "Incidente";

                System.IO.File.Copy(txtcorraporemer.Text, destFile, true);
                rfc.Correo_aprobacion = destFile;

                if (dao.updateAprobarMenor(rfc) > 0)
                {
                    rq.getEstado.Text = "Aprobado";

                    DAOSolicitud daosolicitud = new DAOSolicitud();
                    DTOSolicitud solicitud = new DTOSolicitud();
                    solicitud.Codigo = rfc.Codigo;
                    solicitud.Origen = 1;
                    solicitud.Razon = 4;
                    solicitud.Codasociado = txtincidente.Text;

                    daosolicitud.updateEmergencia(solicitud);


                    rq.FormatodeUI();
                    cac x = (cac)this;
                    x.Close();
                }



            }
            else
            {
                if (getGrupoMedioMayor.Visible == true)
                {
                    rq.guardar();

                    DAORFC dao = new DAORFC();
                    DTORfc rfc = new DTORfc();
                    rfc.Codigo = (Int32)int.Parse(rq.getCodigo.Text);
                    rfc.Estado = "Aprobado";
                    rfc.Aprobador = "CAC";
                    rfc.Fecaprobacion = dateTimePickerCAC.Value;
                    System.IO.File.Copy(txtcorreocomite.Text, destFile, true);
                    rfc.Correo_aprobacion = destFile;

                    if (dao.updateAprobarMenor(rfc) > 0)
                    {
                        rq.getEstado.Text = "Aprobado";
                        rq.FormatodeUI();
                        cac x = (cac)this;
                        x.Close();
                    }
                }
                else
                {
                    rq.guardar();

                    DAORFC dao = new DAORFC();
                    DTORfc rfc = new DTORfc();
                    rfc.Codigo = (Int32)int.Parse(rq.getCodigo.Text);
                    rfc.Estado = "Aprobado";
                    //rfc.Aprobador = comboBoxAprobadorExc.ValueMember.ToString();
                    rfc.Aprobador = comboBoxAprobadorExc.SelectedItem.ToString();
                    rfc.Fecaprobacion = dateTimePicker1.Value;
                    rfc.Motivo = cboMotivo.SelectedItem.ToString();
                    System.IO.File.Copy(txtcorraporexce.Text, destFile, true);
                    rfc.Correo_aprobacion = destFile;

                    if (dao.updateAprobarMenor(rfc) > 0)
                    {
                        rq.getEstado.Text = "Aprobado";
                        rq.FormatodeUI();
                        cac x = (cac)this;
                        x.Close();
                    }
                }
                
               
   
            }

            string titulo = rq.getCodigo.Text + " - " + rq.gettxtdescripcion.Text;


            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Coordinador: " + rq.getCoordinador.Text);
            sb.AppendLine(" Descripcion: "+rq.gettxtdescripcioncambio.Text);
            if (rq.Txtlink.Text != "")
            {
                sb.AppendLine(" Ruta del Plan: " + rq.Txtlink.Text);
            }

            if (VariablesGlobales.ambienteDestino == "PRD")
            {
                CreateMeetingRequest("ccabanillasd@gromero.com.pe", titulo, sb.ToString(), rq.getIni.Value, rq.getFin.Value);
            }
            

        }
        public GroupBox getGrupoEmergencia
        {
            get
            {
                return groupBoxEmergencia;
            }
        }
        public GroupBox getGrupoMedioMayor
        {
            get
            {
                return groupBoxMedioMayor;
            }
        }
        public GroupBox getGroupBoxExcepcion
        {
            get
            {
                return groupBoxExcepcion;
            }
        }

        public static void CreateMeetingRequest(string toEmail, string subject, string body, DateTime startDate, DateTime endDate)
        {
            Microsoft.Office.Interop.Outlook.Application objOL = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.AppointmentItem objAppt = (Microsoft.Office.Interop.Outlook.AppointmentItem)objOL.CreateItem(OlItemType.olAppointmentItem);

            objAppt.Start = startDate;
            objAppt.End = endDate;
            objAppt.Subject = subject;
            //objAppt.Duration = 60;
            objAppt.Body = body;
            
            //objAppt.SendUsingAccount = objOL.Session.Accounts["gestiondecambiosgr@gromero.com.pe"];

            objAppt.MeetingStatus = Microsoft.Office.Interop.Outlook.OlMeetingStatus.olMeeting;
            objAppt.RequiredAttendees = "gestiondecambiosgr@gromero.com.pe";
            ((Microsoft.Office.Interop.Outlook._AppointmentItem)objAppt).Send();
            objAppt = null;
            objOL = null;
        }

        private void cac_DragDrop(object sender, DragEventArgs e)
        {
            /*
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string File in FileList)
                txtcorraporemer.Text += File + "\n";
             */

            //wrap standard IDataObject in OutlookDataObject
               OutlookDataObject dataObject = new OutlookDataObject(e.Data);
   
               //get the names and data streams of the files dropped
              string[] filenames = (string[])dataObject.GetData("FileGroupDescriptorW");
              MemoryStream[] filestreams = (MemoryStream[])dataObject.GetData("FileContents");

              txtcorreocomite.Text += "Files:\n";
              for (int fileIndex = 0; fileIndex < filenames.Length; fileIndex++)
              {
                   //use the fileindex to get the name and data stream
                   string filename = filenames[fileIndex];
                   MemoryStream filestream = filestreams[fileIndex];
                   this.txtcorreocomite.Text += "    " + filename + "\n";
   
                   //save the file stream using its name to the application path
                   FileStream outputStream = File.Create(filename);
                   filestream.WriteTo(outputStream);
                   outputStream.Close();

                   if (groupBoxEmergencia.Visible == true)
                   {    txtcorraporemer.Text = outputStream.Name;
                   }
                   else
                   {
                       if (getGrupoMedioMayor.Visible == true){
                            txtcorreocomite.Text = outputStream.Name;
                       }else{
                           txtcorraporexce.Text = outputStream.Name;
                       }
                   }
              }
                       
               

           }
 

        private void cac_Load(object sender, EventArgs e)
        {
            // Enable drag and drop for this form
            // (this can also be applied to any controls)
            this.AllowDrop = true;

            // Add event handlers for the drag & drop functionality
            this.DragEnter += new DragEventHandler(cac_DragEnter);
            this.DragDrop += new DragEventHandler(cac_DragDrop);

        }

        private void cac_DragEnter(object sender, DragEventArgs e)
        {
            /*
            // Check if the Dataformat of the data can be accepted
            // (we only accept file drops from Explorer, etc.)
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Okay
            else
                e.Effect = DragDropEffects.None; // Unknown data, ignore it
            */

             //display formats available
               this.label1.Text = "Formats:\n";
               foreach (string format in e.Data.GetFormats())
               {
                   this.label1.Text += "    " + format + "\n";
               }
   
               //ensure FileGroupDescriptor is present before allowing drop
               if (e.Data.GetDataPresent("FileGroupDescriptor"))
               {
                   e.Effect = DragDropEffects.All;
               }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerCAC_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtcorraporexce_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxExcepcion_Enter(object sender, EventArgs e)
        {

        }

        private void txtcorraporemer_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
