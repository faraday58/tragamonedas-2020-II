using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TragaMonedas
{
    public partial class MostrarCredito : Form
    {
        private int credito;
        public MostrarCredito(int credito)
        {
            InitializeComponent();
            this.credito=credito;

            lbCredito.Text = credito.ToString();
        }
    }
}
