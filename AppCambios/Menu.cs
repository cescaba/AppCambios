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
using Excel = Microsoft.Office.Interop.Excel;
using DAOLibrary.DAO;
using DAOLibrary.DTO;
/* To work eith EPPlus library */
using OfficeOpenXml;
using OfficeOpenXml.Drawing;

/* For I/O purpose */
using System.IO;

/* For Diagnostics */
using System.Diagnostics;
			

namespace AppCambios
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            DAORFC dao = new DAORFC();

            DataTable dt = new DataTable();

            DTORfc rfc_aux = new DTORfc();

            DAOEmpresa daoEmpresa = new DAOEmpresa();
            DataSet dtEmpresa = new DataSet();

            dtEmpresa = daoEmpresa.selectAll();

            for (int j = 0; j <= dtEmpresa.Tables[0].Rows.Count -1 ; j++)
            {
                cbobusempresa.Items.Add((object)dtEmpresa.Tables[0].Rows[j][1].ToString());
            }


                rfc_aux.Estado = "Total";
            if (VariablesGlobales.TipoRol != "Gestor")
            {
                rfc_aux.Coordinador = VariablesGlobales.nomUsu;
                rfc_aux.Estado = "Pendiente"; //deberia ser Aceptado
                toolStripButton1.Enabled = false;
                txtbuscoordinador.Enabled = false;
            }

            dt = dao.selectCostum(rfc_aux, new DTOSolicitud(), true,true,1);

            if (dt == null)
            {
                MessageBox.Show("No Hay Datos");
            }
            else
            {
                
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.Columns[0].HeaderCell.Value = "Código";
                dataGridView1.Columns[1].HeaderCell.Value = "Estado";
                dataGridView1.Columns[2].HeaderCell.Value = "Tipo de Cambio";
                dataGridView1.Columns[3].HeaderCell.Value = "Indisponibilidad";
                dataGridView1.Columns[4].HeaderCell.Value = "Des. Cambio";
                dataGridView1.Columns[5].HeaderCell.Value = "Fec. Prog. Inicio";
                dataGridView1.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";
                dataGridView1.Columns[6].HeaderCell.Value = "Fec. Prog. Fin";
                dataGridView1.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";
                dataGridView1.Columns[7].HeaderCell.Value = "Sistema Afectado";
                dataGridView1.Columns[8].HeaderCell.Value = "Ambiente Afectado";
                dataGridView1.Columns[9].HeaderCell.Value = "Empresa Afectada";
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                ReqCambios rc = new ReqCambios();
                rc.getCodigo.Text = "" + row.Cells[0].Value;
                rc.Show();
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(Chosen_File, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                if (xlWorkSheet.Name != "Formulario")
                {
                    MessageBox.Show("No es un Archivo Valido");
                }
                else
                {

                    DTOSolicitud nuevo = new DTOSolicitud();
                    /*nuevo.Fechsolicitud = xlWorkSheet.get_Range("C5", "C5").Value; //Fechsolicitud
                    nuevo.Nomsolicitante = xlWorkSheet.get_Range("C10", "C10").Value2.ToString(); //nomsolicitante
                    nuevo.Areasolicitante = Int32.Parse(xlWorkSheet.get_Range("C11", "C11").Value2.ToString()); //areasolicitante
                    nuevo.Origen = ValorOrigen(Int32.Parse(xlWorkSheet.get_Range("F10", "F10").Value2.ToString())); //origen
                    nuevo.Codasociado = xlWorkSheet.get_Range("F11", "F11").Value2.ToString(); //codigoasociado
                    nuevo.Titulo = xlWorkSheet.get_Range("C16", "C16").Value2.ToString(); //Titulo
                    nuevo.Razon = ValorOrigen(Int32.Parse(xlWorkSheet.get_Range("C18", "C18").Value2.ToString()));//razon
                    nuevo.Pripropuesta = xlWorkSheet.get_Range("C20", "C20").Value2.ToString();//pripropuesta
                    //nuevo.Empafectada = xlWorkSheet.get_Range("C19", "C19").Value2.ToString();//empafectada
                    nuevo.Indispropuesta = Int32.Parse(xlWorkSheet.get_Range("C21", "C21").Value2.ToString());//indispopropueta
                    nuevo.Sisafectado = xlWorkSheet.get_Range("F19", "F19").Value2.ToString();//sisafectado
                    nuevo.Ambafectado = Int32.Parse(xlWorkSheet.get_Range("F20", "F20").Value2.ToString());//ambafectado
                    nuevo.Fecpropuesta = xlWorkSheet.get_Range("F18", "F18").Value.ToString();//fecpropuesta
                    nuevo.Impactoest = xlWorkSheet.get_Range("F21", "F21").Value2.ToString();//impactoest
                    nuevo.Areainvolucrada = xlWorkSheet.get_Range("B27", "B27").Value2.ToString();//Areasinvolucradas
                    nuevo.Reuprevia = xlWorkSheet.get_Range("F26", "F26").Value2.ToString();//revisionprevia
                    nuevo.Descambio = limpiar(xlWorkSheet.get_Range("B34", "B34").Value2.ToString());//descambio
                    nuevo.Justcambio = limpiar(xlWorkSheet.get_Range("B42", "B42").Value2.ToString());//justcambio
                    nuevo.Criteriosaceptacion = limpiar(xlWorkSheet.get_Range("B48", "B48").Value2.ToString());//criteriosaceptacion*/

                    
                      
                      
                    nuevo.Fechsolicitud = xlWorkSheet.get_Range("C5", "C5").Value; //Fechsolicitud
                    nuevo.Nomsolicitante = xlWorkSheet.get_Range("C10", "C10").Value2.ToString(); //nomsolicitante
                    nuevo.Areasolicitante = Int32.Parse(xlWorkSheet.get_Range("C11", "C11").Value2.ToString()); //areasolicitante
                    nuevo.Origen = Int32.Parse(xlWorkSheet.get_Range("F10", "F10").Value2.ToString()); //origen
                    if (xlWorkSheet.get_Range("F11", "F11").Value2.ToString() == null)
                    {
                        nuevo.Codasociado = "";
                    }
                    else
                    {
                        nuevo.Codasociado = xlWorkSheet.get_Range("F11", "F11").Value2.ToString(); //codigoasociado
                    }                    
                    nuevo.Titulo = xlWorkSheet.get_Range("C16", "C16").Value2.ToString(); //Titulo
                    nuevo.Razon = Int32.Parse(xlWorkSheet.get_Range("C18", "C18").Value2.ToString());//razon
                    nuevo.Pripropuesta = Int32.Parse(xlWorkSheet.get_Range("C20", "C20").Value2.ToString());//pripropuesta
                    nuevo.Sociedadafectada = Int32.Parse(xlWorkSheet.get_Range("C19", "C19").Value2.ToString());//empafectada
                    nuevo.Indispropuesta = Int32.Parse(xlWorkSheet.get_Range("C21", "C21").Value2.ToString());//indispopropueta
                    nuevo.Sisafectado = xlWorkSheet.get_Range("F19", "F19").Value2.ToString();//sisafectado
                    nuevo.Ambafectado = Int32.Parse(xlWorkSheet.get_Range("F20", "F20").Value2.ToString());//ambafectado
                    nuevo.Fecpropuesta = xlWorkSheet.get_Range("F18", "F18").Value;//fecpropuesta
                    nuevo.Impactoest = Int32.Parse(xlWorkSheet.get_Range("F21", "F21").Value2.ToString());//impactoest
                    nuevo.Areainvolucrada = xlWorkSheet.get_Range("B27", "B27").Value2.ToString();//Areasinvolucradas
                    nuevo.Reuprevia = Int32.Parse(xlWorkSheet.get_Range("F26", "F26").Value2.ToString());//revisionprevia
                    nuevo.Descambio = limpiar(xlWorkSheet.get_Range("B34", "B34").Value2.ToString());//descambio
                    nuevo.Justcambio = limpiar(xlWorkSheet.get_Range("B42", "B42").Value2.ToString());//justcambio
                    nuevo.Criteriosaceptacion = limpiar(xlWorkSheet.get_Range("B48", "B48").Value2.ToString());//criteriosaceptacion 
                     
                    


                    DAOSolicitud dao = new DAOSolicitud();

                    int codigo = dao.insert(nuevo);
                    if (codigo > 0)
                    {
                        //nuevo.Codigo = codigo;
                        MessageBox.Show("registrado!");
                        AbrirSolicitud(nuevo.Codigo);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }


                    xlWorkBook.Close(false, misValue, misValue);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);

                }


              



            }
        }

        private void AbrirSolicitud(int? codigo)
        {
            ReqCambios rc = new ReqCambios();
            rc.getCodigo.Text = "" + codigo;
            rc.Show();
            
            
        }

        private string limpiar(string dato)
        {
            
             return  dato.Replace("'", " ");

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
        private string ValorRazon(int estado){
            string dato ="";

            switch (estado){
                case 1:
                    dato = "Solución de errores conocidos";
                    break;
                 
                case 2:
                    dato = "Desarrollo de nuevos servicios";
                    break;
                case 3:
                     dato = "Mejora de los servicios existentes";
                    break;
                case 4:
                    dato = "Imperativo legal";
                    break;
                case 5:
                    dato = "Imperativo de Seguridad";
                    break;
            }

            return dato;
        }
        private string ValorOrigen(int estado)
        {
            string dato = "";

            switch (estado)
            {
                case 1:
                    dato = "Proceso de Gestion Problemas";
                    break;

                case 2:
                    dato = "Proceso de Gestion de Incidencias";
                    break;
                case 3:
                    dato = "Mejora de los servicios existentes";
                    break;
                case 4:
                    dato = "Responsable del Activo";
                    break;
                case 5:
                    dato = "Proveedor IBM";
                    break;
                case 6:
                    dato = "Proveedor Telefonica";
                    break;
                case 7:
                    dato = "Proveedor Otros";
                    break;
                case 8:
                    dato = "Proyectos";
                    break;
                case 9:
                    dato = "Otros";
                    break;
            }

            return dato;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            limpiarbuscador();
            
            //mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\corjsmsrv1.grupocogesa.gromero.net\Publico\PublicoCSC\#TI\Repositorio-RFC\Base de datos21.accdb");
           // mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Base de datos21.accdb");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            DAORFC dao = new DAORFC();
            DTORfc rfc_aux = new DTORfc();
            DataTable dt = new DataTable();

            rfc_aux.Estado = "Total";
            if (VariablesGlobales.TipoRol != "Gestor")
            {
                rfc_aux.Coordinador = VariablesGlobales.nomUsu;
                rfc_aux.Estado = "Pendiente"; //deberia ser Aceptado
                toolStripButton1.Enabled = false;
                txtbuscoordinador.Enabled = false;
            }

            dt = dao.selectCostum(rfc_aux, new DTOSolicitud(), true,true,1);

            if (dt == null)
            {
                MessageBox.Show("No Hay Datos");
            }
            else
            {

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.Columns[0].HeaderCell.Value = "Código";
                dataGridView1.Columns[1].HeaderCell.Value = "Estado";
                dataGridView1.Columns[2].HeaderCell.Value = "Tipo de Cambio";
                dataGridView1.Columns[3].HeaderCell.Value = "Indisponibilidad";
                dataGridView1.Columns[4].HeaderCell.Value = "Des. Cambio";
                dataGridView1.Columns[5].HeaderCell.Value = "Fec. Prog. Inicio";
                dataGridView1.Columns[6].HeaderCell.Value = "Fec. Prog. Fin";
                dataGridView1.Columns[7].HeaderCell.Value = "Sistema Afectado";
                dataGridView1.Columns[8].HeaderCell.Value = "Ambiente Afectado";
                dataGridView1.Columns[9].HeaderCell.Value = "Empresa Afectada";
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Consultar c = new Consultar();
            c.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            limpiarbuscador();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            DAORFC dao = new DAORFC();
            DTORfc rfc_aux = new DTORfc();
            DataTable dt = new DataTable();


            if (VariablesGlobales.TipoRol != "Gestor")
            {
                rfc_aux.Coordinador = VariablesGlobales.nomUsu;
                toolStripButton1.Enabled = false;
                txtbuscoordinador.Enabled = false;
            }

            dt = dao.selectCostum(rfc_aux, new DTOSolicitud(), true,false,1);



            if (dt == null)
            {
                MessageBox.Show("No Hay Datos");
            }
            else
            {

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.Columns[0].HeaderCell.Value = "Código";
                dataGridView1.Columns[1].HeaderCell.Value = "Estado";
                dataGridView1.Columns[2].HeaderCell.Value = "Tipo de Cambio";
                dataGridView1.Columns[3].HeaderCell.Value = "Indisponibilidad";
                dataGridView1.Columns[4].HeaderCell.Value = "Des. Cambio";
                dataGridView1.Columns[5].HeaderCell.Value = "Fec. Prog. Inicio";
                dataGridView1.Columns[6].HeaderCell.Value = "Fec. Prog. Fin";
                dataGridView1.Columns[7].HeaderCell.Value = "Sistema Afectado";
                dataGridView1.Columns[8].HeaderCell.Value = "Ambiente Afectado";
                dataGridView1.Columns[9].HeaderCell.Value = "Empresa Afectada";
            }
           
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            
            
            // Get file name.
            string name = saveFileDialog1.FileName;

            //DataGrid
            DTORfc rfc = new DTORfc();
            DTOSolicitud solicitud = new DTOSolicitud();
            DAORFC dao = new DAORFC();
            int tipoCambio = 0;

            
            //Estado
            if (cbobusestado.SelectedIndex != 0 && cbobusestado.SelectedIndex != -1)
            {
                rfc.Estado = cbobusestado.SelectedItem.ToString();
            }
            else { rfc.Estado = null; }

            //Indisponibilidad
            if (cbobusindis.SelectedIndex != 0 && cbobusindis.SelectedIndex != -1)
            {
                rfc.Indisponibilidad = (Int32)cbobusindis.SelectedValue;
            }
            else { rfc.Indisponibilidad = -1; }

            //Tipo de cambio
            if (radioButtonall.Checked)
            {
                tipoCambio = 1;
            }

            if (radioButtonMenor.Checked)
            {
                tipoCambio = 2;
            }
            if (radioButtonMed.Checked)
            {
                tipoCambio = 3;
            }
            if (radioButtonUrg.Checked)
            {
                tipoCambio = 4;
            }

            //Area del Cambio - Categoria Activo
            if (cbobusareacambio.SelectedIndex != 0 && cbobusareacambio.SelectedIndex != -1)
            {
                rfc.Cateinfra = cbobusareacambio.SelectedItem.ToString();
            }
            else { rfc.Cateinfra = null; }

            //Solicitante
            if (txtbussolicitante.Text != "")
            {
                solicitud.Nomsolicitante = txtbussolicitante.Text;
            }
            else { solicitud.Nomsolicitante = null; }

            //Coordinador
            if (txtbuscoordinador.Text != "")
            {
                rfc.Coordinador = txtbuscoordinador.Text;
            }
            else { rfc.Coordinador = null; }

            //Empresa Afectada
            if (cbobusempresa.SelectedIndex != 0 && cbobusempresa.SelectedIndex != -1)
            {
                solicitud.Sociedadafectada = (Int32)cbobusempresa.SelectedValue;
            }
            else { solicitud.Sociedadafectada = -1; }

            //Area Solicitante
            if (cbobusareasoli.SelectedIndex != 0 && cbobusareasoli.SelectedIndex != -1)
            {
                solicitud.Areasolicitante = (Int32)cbobusareasoli.SelectedValue;
            }
            else { solicitud.Areasolicitante = -1; }

            if (radioButtonFR.Checked)
            {
                solicitud.Fechsolicitud = dateTimePickerbusIni.Value;
                solicitud.Fecpropuesta = dateTimePickerbusFin.Value;
                rfc.Fecprogramadaejecucion = new DateTime(1900,01,01,00,00,00);
                rfc.Fecprogramadafinalizacion = new DateTime(1900, 01, 01, 00, 00, 00);
                rfc.Fecharealejecucion  = new DateTime(1900,01,01,00,00,00);
                rfc.Fecharealfinalizacion = new DateTime(1900,01,01,00,00,00);
            }
            else
            {
                solicitud.Fechsolicitud = new DateTime(1900,01,01,00,00,00);
                solicitud.Fecpropuesta = new DateTime(1900,01,01,00,00,00);
            }

            if (radioButtonFIP.Checked)
            {
                rfc.Fecprogramadaejecucion = dateTimePickerbusIni.Value;
                rfc.Fecprogramadafinalizacion = dateTimePickerbusFin.Value;
                rfc.Fecharealejecucion = new DateTime(1900, 01, 01, 00, 00, 00);
                rfc.Fecharealfinalizacion = new DateTime(1900, 01, 01, 00, 00, 00);
                solicitud.Fechsolicitud = new DateTime(1900, 01, 01, 00, 00, 00);
                solicitud.Fecpropuesta = new DateTime(1900, 01, 01, 00, 00, 00);
            }
            else
            {
                rfc.Fecprogramadaejecucion = new DateTime(1900, 01, 01, 00, 00, 00);
                rfc.Fecprogramadafinalizacion = new DateTime(1900, 01, 01, 00, 00, 00);
            }

            if (radioButtonFIR.Checked)
            {
                rfc.Fecharealejecucion = dateTimePickerbusIni.Value;
                rfc.Fecharealfinalizacion = dateTimePickerbusFin.Value;
                rfc.Fecprogramadaejecucion = new DateTime(1900, 01, 01, 00, 00, 00);
                rfc.Fecprogramadafinalizacion = new DateTime(1900, 01, 01, 00, 00, 00);
                solicitud.Fechsolicitud = new DateTime(1900, 01, 01, 00, 00, 00);
                solicitud.Fecpropuesta = new DateTime(1900, 01, 01, 00, 00, 00);
            }
            else
            {
                rfc.Fecharealejecucion = new DateTime(1900, 01, 01, 00, 00, 00);
                rfc.Fecharealfinalizacion = new DateTime(1900, 01, 01, 00, 00, 00);
            }
            DataGridView dg = new DataGridView();

            if (VariablesGlobales.TipoRol != "Gestor")
            {
                rfc.Coordinador = VariablesGlobales.nomUsu;
            }
            
            //DataTable dt = dao.selectCostum(rfc, solicitud, false, false);
            


            DataTable dt = dao.selectMiguel(rfc, solicitud,tipoCambio);
            


            if (dt == null)
            {
                MessageBox.Show("No Hay Datos");
            }
            else
            {
                // Write to the file name selected.
                // ... You can write the text from a TextBox instead of a string literal.
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                
                string[] columnNames = dt.Columns.Cast<DataColumn>()
                                             .Select(x => x.ColumnName)
                                             .ToArray();

                for (j = 0; j <= columnNames.Length - 1; j++)
                {
                    xlWorkSheet.Cells[1, j+1] = columnNames[j];
                }


                    for (i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        for (j = 0; j <= dt.Columns.Count - 1; j++)
                        {
                            //DataGridViewCell cell = dt[j, i];
                            xlWorkSheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                        }
                    }

                xlWorkBook.SaveAs(name, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DTORfc rfc = new DTORfc();
            DTOSolicitud solicitud = new DTOSolicitud();
            DAORFC dao = new DAORFC();
            int tipoCambio = 0;

            //Estado
            if (cbobusestado.SelectedIndex != 0 && cbobusestado.SelectedIndex != -1)
            {
                rfc.Estado = cbobusestado.SelectedItem.ToString();
            }
            else { rfc.Estado = null; }

            //Indisponibilidad
            if (cbobusindis.SelectedIndex != 0 && cbobusindis.SelectedIndex != -1)
            {
                rfc.Indisponibilidad = (Int32)cbobusindis.SelectedIndex;
            }
            else { rfc.Indisponibilidad = -1; }

            //Tipo de cambio
            if (radioButtonall.Checked)
            {
                tipoCambio = 1;
            }
            if (radioButtonMenor.Checked)
            {
                tipoCambio = 2;
            }
            if (radioButtonMed.Checked)
            {
                tipoCambio = 3;
            }
            if (radioButtonUrg.Checked)
            {
                tipoCambio = 4;
            }

            //Area del Cambio - Categoria Activo
            if (cbobusareacambio.SelectedIndex != 0 && cbobusareacambio.SelectedIndex != -1)
            {
                rfc.Cateinfra = cbobusareacambio.SelectedItem.ToString();
            }
            else { rfc.Cateinfra = null; }

            //Solicitante
            if (txtbussolicitante.Text != "")
            {
                solicitud.Nomsolicitante = txtbussolicitante.Text;
            }
            else { solicitud.Nomsolicitante = null; }

            //Coordinador
            if (txtbuscoordinador.Text != "")
            {
                rfc.Coordinador = txtbuscoordinador.Text;
            }
            else { rfc.Coordinador = null; }

            //Empresa Afectada
            if (cbobusempresa.SelectedIndex != 0 && cbobusempresa.SelectedIndex != -1)
            {
                solicitud.Empresa = cbobusempresa.SelectedItem.ToString();
            }
            else { solicitud.Sociedadafectada = -1; }

            //Area Solicitante
            if (cbobusareasoli.SelectedIndex != 0 && cbobusareasoli.SelectedIndex != -1)
            {
                solicitud.Areasolicitante = (Int32)cbobusareasoli.SelectedIndex;
            }
            else { solicitud.Areasolicitante = -1; }

            if (radioButtonFR.Checked)
            {
                solicitud.Fechsolicitud = dateTimePickerbusIni.Value;
                solicitud.Fecpropuesta = dateTimePickerbusFin.Value;
                rfc.Fecprogramadaejecucion = new DateTime(1900, 01, 01, 00, 00, 00);
                rfc.Fecprogramadafinalizacion = new DateTime(1900, 01, 01, 00, 00, 00);
                rfc.Fecharealejecucion = new DateTime(1900, 01, 01, 00, 00, 00);
                rfc.Fecharealfinalizacion = new DateTime(1900, 01, 01, 00, 00, 00);
            }
            else
            {
                solicitud.Fechsolicitud = new DateTime(1900, 01, 01, 00, 00, 00);
                solicitud.Fecpropuesta = new DateTime(1900, 01, 01, 00, 00, 00);
            }

            if (radioButtonFIP.Checked)
            {
                rfc.Fecprogramadaejecucion = dateTimePickerbusIni.Value;
                rfc.Fecprogramadafinalizacion = dateTimePickerbusFin.Value;
                rfc.Fecharealejecucion = new DateTime(1900, 01, 01, 00, 00, 00);
                rfc.Fecharealfinalizacion = new DateTime(1900, 01, 01, 00, 00, 00);
                solicitud.Fechsolicitud = new DateTime(1900, 01, 01, 00, 00, 00);
                solicitud.Fecpropuesta = new DateTime(1900, 01, 01, 00, 00, 00);
            }
            else
            {
                rfc.Fecprogramadaejecucion = new DateTime(1900, 01, 01, 00, 00, 00);
                rfc.Fecprogramadafinalizacion = new DateTime(1900, 01, 01, 00, 00, 00);

                if (radioButtonFIR.Checked)
                {
                    rfc.Fecharealejecucion = dateTimePickerbusIni.Value;
                    rfc.Fecharealfinalizacion = dateTimePickerbusFin.Value;
                    rfc.Fecprogramadaejecucion = new DateTime(1900, 01, 01, 00, 00, 00);
                    rfc.Fecprogramadafinalizacion = new DateTime(1900, 01, 01, 00, 00, 00);
                    solicitud.Fechsolicitud = new DateTime(1900, 01, 01, 00, 00, 00);
                    solicitud.Fecpropuesta = new DateTime(1900, 01, 01, 00, 00, 00);
                }
                else
                {
                    rfc.Fecharealejecucion = new DateTime(1900, 01, 01, 00, 00, 00);
                    rfc.Fecharealfinalizacion = new DateTime(1900, 01, 01, 00, 00, 00);
                }

                if (VariablesGlobales.TipoRol != "Gestor")
                {
                    rfc.Coordinador = VariablesGlobales.nomUsu;
                }

            }
            DataTable dt = dao.selectCostum(rfc, solicitud, true, false, tipoCambio);



            if (dt == null)
            {
                MessageBox.Show("No Hay Datos");
            }
            else
            {
                //DataGridView dg = new DataGridView();
                //dg.DataSource = dt;
                dataGridView1.DataSource = dt;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void limpiarbuscador()
        {
            cbobusestado.SelectedIndex = 0;
            cbobusindis.SelectedIndex = 0;
            //cbobustipcambio.SelectedIndex = 0;
            radioButtonall.Checked = true;
            radioButtonMenor.Checked = false;
            radioButtonMed.Checked = false;
            radioButtonUrg.Checked = false;

            cbobusareacambio.SelectedIndex = 0;
            txtbussolicitante.Text = "";
            txtbuscoordinador.Text = "";
            cbobusempresa.SelectedIndex = 0;
            cbobusareasoli.SelectedIndex = 0;
            radioButtonNo.Checked = true;
        }

        private void cbobusindis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
