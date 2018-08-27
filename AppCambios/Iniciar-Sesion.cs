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
using DAOLibrary.DAO;
using DAOLibrary.DTO;

namespace AppCambios
{
    public partial class Form1 : Form
    {
        private OleDbConnection mycon;
        public Form1()
        {
            mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\corjsmsrv1.grupocogesa.gromero.net\Publico\PublicoCSC\#TI\Repositorio-RFC\Base de datos21.accdb");
            //mycon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Base de datos21.accdb");
            InitializeComponent();
            
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {

            DTOUsuario dto = new DTOUsuario();
            DAOUsuario dao = new DAOUsuario();

            DataSet ds;

            dto.Nombre = txtusuario.Text;
            dto.Password = txtcontraseña.Text;

            ds = dao.select(dto);

            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Existe Usuario y/o Contraseña Equivocada");
            }
            else
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    VariablesGlobales.TipoRol = ds.Tables[0].Rows[0][4].ToString();
                    VariablesGlobales.nomUsu = txtusuario.Text;
                    Menu x = new Menu();
                    x.Show();
                    this.Visible = false;
                }
            }
            
           /*
            OleDbDataAdapter dataadapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            try
            {
                mycon.Open();
                dataadapter.SelectCommand = new OleDbCommand("Select * from Usuarios where Nombre= '"+txtusuario.Text+"' and password='"+txtcontraseña.Text+"'", mycon);
                dataadapter.Fill(ds);
                dataadapter.Dispose();

                mycon.Close();

                if(ds.Tables[0].Rows.Count > 0){
                    Menu x = new Menu();
                    x.Show();
                    this.Visible = false;
                }
                else { MessageBox.Show("No Existe Usuario y/o Contraseña Equivocada"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        */

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnentrar.PerformClick();
                
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnentrar.PerformClick();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtusuario.Text = Environment.UserName;
           
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }
  
        private void txtcontraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnentrar.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 x = (Form1)this;
            x.Close();
        }
    }
}
