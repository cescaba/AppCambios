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

namespace AppCambios
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            txtcodbuscar.Select();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            DTORfc rfc = new DTORfc();
            DAORFC dao = new DAORFC();
            DataSet ds = new DataSet();

            txtcodbuscar.Text = txtcodbuscar.Text.Trim();
            int buscador = comboBox1.SelectedIndex;

            switch (buscador)
            {
                case 0:
                    
                    try
                    {
                        rfc.Codigo = (Int32)Int32.Parse(txtcodbuscar.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Solo ingresa la parte númerica del código.");
                        return;
                    }

                    ds = dao.select(rfc);
                    break;
                case 1:
                    rfc.Codatenciontercero = txtcodbuscar.Text;
                    ds = dao.buscarTicket(rfc, 1);
                    break;
                case 2:
                     rfc.Codatenciontercero = txtcodbuscar.Text;
                    ds = dao.buscarTicket(rfc, 2);
                    break;
            }
            

            if (ds != null && ds.Tables[0].Rows.Count != 0)
            {
               
                ReqCambios rc = new ReqCambios();
                rc.getCodigo.Text = "" + ds.Tables[0].Rows[0]["codigo"];
                rc.Show();

                Consultar k = this;
                k.Close();
            }
            else
            {
                MessageBox.Show("No existe RFC para el código ingresado.");
                return;
            }



            

        }

        private void txtcodbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnbuscar.PerformClick();
            }
        }

        private void Consultar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnbuscar.PerformClick();
            }
        }

        private void Consultar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Consultar_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
