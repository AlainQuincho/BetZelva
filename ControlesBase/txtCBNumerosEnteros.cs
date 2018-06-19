using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace GEN.ControlesBase
{
    public partial class txtCBNumerosEnteros : TextBox
    {
        public txtCBNumerosEnteros()
        {
            InitializeComponent();
        }

        public txtCBNumerosEnteros(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

           this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtNumRea_KeyPress);
        }

         private void txtNumRea_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            {
                e.Handled = true;
            }
 

        }
    }
}
