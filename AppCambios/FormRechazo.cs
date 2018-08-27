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
    public partial class FormRechazo : Form
    {
        ReqCambios rq;
        public FormRechazo(ReqCambios rq)
        {
            InitializeComponent();
            this.rq = rq;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rq.guardar();
            DAORFC dao = new DAORFC();
            DTORfc rfc = new DTORfc();

            
            rfc.Codigo = (Int32)int.Parse(rq.getCodigo.Text);
            rfc.Fecrechazo = DateTime.Now;
            rfc.Razonrechazo = txtRechazo.Text;
            int y = dao.updateRechazar(rfc);

            if (y > 0)
            {
                rq.getEstado.Text = "Rechazado";
                rq.FormatodeUI();

                FormRechazo x = (FormRechazo)this;
                x.Close();
            }

           
        }
    }
}
