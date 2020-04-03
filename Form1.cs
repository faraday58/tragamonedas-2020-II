using System;
using System.Drawing;
using System.Windows.Forms;

namespace TragaMonedas
{
    public partial class Form1 : Form
    {
        private int tiempo;
        private int credito;
        MostrarCredito FmostrarCredito;
        public Form1()
        {
            InitializeComponent();
            credito = 6;
            FmostrarCredito = new MostrarCredito(credito);
        }

        private void JugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timeCronometro.Interval = 300;
            timeCronometro.Start();
        }

        private void TimeCronometro_Tick(object sender, EventArgs e)
        {
            lbTiempo.Text = tiempo + " [s]";
            tiempo++;

            Random ObjAleatorio = new Random();
            int numAleatorio = ObjAleatorio.Next(0, 3);
            int numAleatorio2 = ObjAleatorio.Next(0, 3);
            int numAleatorio3 = ObjAleatorio.Next(0, 3);


            switch (numAleatorio)
            {
                case 0:
                    this.ptbIzq.Image = global::TragaMonedas.Properties.Resources.uvas;
                    break;
                case 1:
                    this.ptbIzq.Image = global::TragaMonedas.Properties.Resources.CEREZAS;
                    break;
                case 2:
                    this.ptbIzq.Image = global::TragaMonedas.Properties.Resources.mangos_big_750570;
                    break;
            }

            switch (numAleatorio2)
            {
                case 0:
                    this.ptbCtro.Image = global::TragaMonedas.Properties.Resources.uvas;
                    break;
                case 1:
                    this.ptbCtro.Image = global::TragaMonedas.Properties.Resources.CEREZAS;
                    break;
                case 2:
                    this.ptbCtro.Image = global::TragaMonedas.Properties.Resources.mangos_big_750570;
                    break;
            }
            switch (numAleatorio3)
            {
                case 0:
                    this.ptbDer.Image = global::TragaMonedas.Properties.Resources.uvas;
                    break;
                case 1:
                    this.ptbDer.Image = global::TragaMonedas.Properties.Resources.CEREZAS;
                    break;
                case 2:
                    this.ptbDer.Image = global::TragaMonedas.Properties.Resources.mangos_big_750570;
                    break;
            }

            if (tiempo == 11)
            {
                timeCronometro.Stop();
                tiempo = 0;
                credito -= 3;
                if (numAleatorio == numAleatorio2 && numAleatorio == numAleatorio3)
                {                    
                    credito += 5;
                    FmostrarCredito.Show();

                }
                else
                {                    
                    if(credito <=0 )
                    {
                        jugarToolStripMenuItem.Enabled = false;
                    }
                }
            }
        }

        private void InicialToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            

            FmostrarCredito.Show();
        }
    }
}
