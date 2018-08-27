using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCambios
{
    public partial class CalImpacto : Form
    {
        ReqCambios rq;
        public CalImpacto(ReqCambios rq)
        {
            InitializeComponent();
            this.rq = rq;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalImpacto x = (CalImpacto)this;
            x.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            if(cboempafec.SelectedIndex == -1 || cbousuafec.SelectedIndex == -1 || cboimp1.SelectedIndex == -1 ||
                cboimp2.SelectedIndex == -1 || cboimp3.SelectedIndex == -1 || cboimp4.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Selecionar todo los Campos.");
            }
            else
            {
                num = num + (5 - cbousuafec.SelectedIndex);
                num = num + (4 - cboempafec.SelectedIndex);
                num = num + (4 - cboimp1.SelectedIndex);
                num = num + (5 - cboimp2.SelectedIndex);
                num = num + (5 - cboimp3.SelectedIndex);
                num = num + (5 - cboimp4.SelectedIndex);

                for (int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        num = num + 1;
                    }
                }
            }
            string tipocambioresul = "";
            if (num <= 9)
            {
                tipocambioresul = "Usual del Negocio";
            }
            else if (num <= 13)
            {
                tipocambioresul = "Menor";
            }
            else if (num <= 17)
            {
                tipocambioresul = "Medio";
            }
            else if (num <= 21)
            {
                tipocambioresul = "Mayor";
            }
            else
            {
                tipocambioresul = "Crítico";
            }


            rq.Txtimpacto.Text = tipocambioresul;
            if (rq.Txtimpacto.Text == "Usual del Negocio")
            {
                rq.Btnproponer.Visible = true;
            }
            else
            {
                rq.Btnproponer.Visible = false;

            }
            CalImpacto x = (CalImpacto)this;
            x.Close();
        }

        private void CalImpacto_Load(object sender, EventArgs e)
        {

        }
    }
}
