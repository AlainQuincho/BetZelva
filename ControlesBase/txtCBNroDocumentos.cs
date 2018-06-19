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
    public partial class txtCBNroDocumentos : TextBox
    {
        public String tipdoc;
        public txtCBNroDocumentos()
        {
            InitializeComponent();
        }

        public txtCBNroDocumentos(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtINGRESO_KeyPress);
        }

        public void ValidarTipoDoc (String TipDoc){

            tipdoc = TipDoc;
            if (TipDoc == "1" || TipDoc == "11") //DNI y DNI Menor
                this.MaxLength = 8;
            else if (TipDoc == "3") // Pasaporte
                this.MaxLength = 10;
            else if (TipDoc == "4") //RUC
                this.MaxLength = 11;
            else
                this.MaxLength = 12;
        }

        public void txtINGRESO_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //Solo acepta numeros
            if (tipdoc == "1" || tipdoc == "4" || tipdoc == "11") //DNI, RUC, DNI Menor
            {
                    if (e.KeyChar == 8)
                        e.Handled = false;
                    else if (e.KeyChar >= 48 && e.KeyChar <= 57)
                        e.Handled = false;
                    
                    else
                        e.Handled = true;
                }

            //Acepta numeros y letras

            else    
            {
                 if (e.KeyChar == 8)
                     e.Handled = false;
                 else if (e.KeyChar >= 48 && e.KeyChar <= 57)
                     e.Handled = false;
                 else if (e.KeyChar >= 65 && e.KeyChar <= 90)
                     e.Handled = false;
                 else if (e.KeyChar >= 97 && e.KeyChar <= 122)
                     e.Handled = false;
                 
                 else
                     e.Handled = true;
            }
        
        }
         
    }
}
