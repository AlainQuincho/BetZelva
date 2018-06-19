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
    public partial class txtCBLetra : TextBox
    {
        public txtCBLetra()
        {
            InitializeComponent();

        }

        public txtCBLetra(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtLetra_KeyPress);
        }



        private void txtCBLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetterOrDigit(e.KeyChar) == false) && e.KeyChar != ' ')//CTRL+C, CTRL+V, ETC
            {

                if (e.KeyChar == 3||e.KeyChar == 22||e.KeyChar == 24)                    
                    e.Handled = false;
                else if (e.KeyChar == 8)//retroceso
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            
            else if (e.KeyChar >= 48 && e.KeyChar <= 57)//numeros
                e.Handled = false;
            else if (e.KeyChar >= 65 && e.KeyChar <= 90)//mayusculas
                e.Handled = false;
            else if (e.KeyChar >= 97 && e.KeyChar <= 122)//minusculas
                e.Handled = false;
            else if (e.KeyChar == 32)// espacio
                e.Handled = false;
            else if (e.KeyChar == 209 || e.KeyChar == 241)//ñ o Ñ 
                e.Handled = false;

            else
                e.Handled = true;
        }

                
    }
}
