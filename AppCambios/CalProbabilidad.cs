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
    public partial class CalProbabilidad : Form
    {
        ReqCambios rq;
        public CalProbabilidad(ReqCambios rq)
        {
            InitializeComponent();
            this.rq = rq;
        }

        public ComboBox Cboimp1
        {
            get { return cboimp1; }
            set { cboimp1 = value; }
        }

        public ComboBox Cboimp2
        {
            get { return cboimp2; }
            set { cboimp2 = value; }
        }

        public ComboBox Cboimp6
        {
            get { return cboimp6; }
            set { cboimp6 = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            int probabilidad = -1;
            //Validacion
            //if (cboimp1.SelectedIndex == -1 || cboimp2.SelectedIndex == -1 || cboimp3.SelectedIndex == -1 ||
            //    cboimp4.SelectedIndex == -1 || cboimp5.SelectedIndex == -1)
            //{
            if (cboimp1.SelectedIndex == -1 || cboimp2.SelectedIndex == -1 || cboimp6.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Selecionar todo los Campos.");
            }
            else
            {
               

                if (cboimp1.SelectedIndex == 0)
                {
                    num = num + 5;
                }
                if (cboimp1.SelectedIndex == 1)
                {
                    num = num + 3;
                }
                if (cboimp1.SelectedIndex == 2)
                {
                    num = num + 1;
                }
                //num = num + (cboimp2.SelectedIndex + 1);
                num = num + (4 - cboimp2.SelectedIndex);
                num = num + (4 - cboimp6.SelectedIndex);
                //num = num + (4 - cboimp3.SelectedIndex);
                //num = num + (5 - cboimp4.SelectedIndex);
                //num = num + (5 - cboimp5.SelectedIndex);

                if (num >= 12)
                {
                    probabilidad = 1;
                }
                else if (num >= 9)
                {
                    probabilidad = 2;
                }
                else
                {
                    probabilidad = 3;
                }

                rq.Txtprobfalla.Text = calculoprobabilidad(probabilidad);
                rq.Cboimp1 = cboimp1.SelectedIndex;
                rq.Cboimp2 = cboimp2.SelectedIndex;
                rq.Cboimp6 = cboimp6.SelectedIndex;

                CalProbabilidad x = (CalProbabilidad)this;
                x.Close();

               // DialogResult dialogResult = MessageBox.Show("La Probabilidad es: "+calculoprobabilidad(probabilidad)+" ¿Conforme?", "Confirmación", MessageBoxButtons.YesNo);
               // if(dialogResult == DialogResult.Yes)
               // {
               //    
               // }
               // else if (dialogResult == DialogResult.No)
               // {
               //     //do something else
               // }

            }
            
        }

        public string calculoprobabilidad(int probabilidad)
        {
            if (probabilidad == 3)
            {
                return "Bajo";
            }
            if (probabilidad == 2)
            {
                return "Medio";
            }
            if (probabilidad == 1)
            {
                return "Alto";
            }
            return "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalProbabilidad x = (CalProbabilidad)this;
            x.Close();
        }

        private void cboimp2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
