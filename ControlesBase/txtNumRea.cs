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
    public partial class txtNumRea : TextBox
    {
        private int _nNumDecimales = 4;
        public int nNumDecimales
        {

            get { return _nNumDecimales; }

            set { _nNumDecimales = value; }

        } 
        public txtNumRea()
        {
            InitializeComponent();
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtNumRea_KeyPress);
            this.LostFocus += txtNumRea_LostFocus;
            this.TextChanged += txtNumRea_TextChanged;
        }

        private double _nvalor;

        public double nvalor
        {
            get { return Convert.ToDouble(this.Text == "" ? "0" : this.Text); }
            set { _nvalor = value; }
        }

        private decimal _nDecValor;

        public decimal nDecValor
        {
            get { return Convert.ToDecimal(this.Text == "" ? "0" : this.Text); }
            set { _nDecValor = value; }
        }

        private bool _formatoDec=false;

        public bool FormatoDecimal
        {
            get { return _formatoDec; }
            set { _formatoDec = value; }
        }
        

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public txtNumRea(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtNumRea_KeyPress);
            this.LostFocus += txtNumRea_LostFocus;
            this.TextChanged += txtNumRea_TextChanged;
        }

        void txtNumRea_TextChanged(object sender, EventArgs e)
        {
            if (FormatoDecimal && (this.Enabled == false || this.ReadOnly == true))
            {
                if (string.IsNullOrEmpty(this.Text))
                {
                    this.Text = "0.00";
                }
                else
                {
                    string cFormato = "}";
                    string cFormatonew = "{0:0,0." + cFormato.PadLeft(nNumDecimales + 1, '0');

                    this.Text = string.Format(cFormatonew, Convert.ToDecimal(this.Text));
                }
            }
            if (this.Text==".")
            {
                this.Text="";
            }
            if ( this.Text.IndexOf(".") == 0 && this.Text.Length>1)
            {
                this.Text = "0" + this.Text;
            }
           
        }

        void txtNumRea_LostFocus(object sender, EventArgs e)
        {
            if (FormatoDecimal)
            {
                if (string.IsNullOrEmpty(this.Text))
                {
                    this.Text = "0.00";                    
                }
                else
                {
                    if (this.Text.Trim() == ".")
                    {
                        this.Text = "0.00";
                    }

                    string cFormato = "}";
                    string cFormatonew = "{0:0,0." + cFormato.PadLeft(nNumDecimales + 1, '0');
                    this.Text = string.Format(cFormatonew, Convert.ToDecimal(this.Text));
                }
            }
            else
            {
                if (this.Text=="0." || this.Text==".")
                {
                    this.Text = "0";
                }
            }
        }       
        
        void txtNumRea_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
       {
           if (this.SelectionLength > 0)
           {
               e.Handled = false;
               valNum2(e);
               return;
           }
 
           if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
           
           valNum(e);          

        }

        private void valNum(KeyPressEventArgs e)
       {
           if (e.KeyChar >= 48 && e.KeyChar <= 57)
           {
               if (this.Text.Length == 1 && this.Text == "0")
               {
                   e.Handled = true;
               }
               else
               {
                   if (this.Text.IndexOf('.') > -1 && this.Text.Substring(this.Text.IndexOf(".")).Length > nNumDecimales)
                       e.Handled = true;
                   else
                       e.Handled = false;
               }
           }

           else
           {
               if (this.Text.Length == 0 && e.KeyChar == 46)
               {
                   e.Handled = true;
                   this.Text = "0.";
                   this.Select(2, 1);
               }
               else
               {
                   var fff = (from L in this.Text

                              where L.ToString() == "."
                              select L).Count();
                   if (fff <= 0 && e.KeyChar.ToString() == "." && nNumDecimales > 0)
                       e.Handled = false;
                   else
                       e.Handled = true;
               }
               
           }
       }

        private void valNum2(KeyPressEventArgs e)
       {
           if (e.KeyChar == 8)
           {
               e.Handled = false;
               return;
           }
           if (e.KeyChar >= 48 && e.KeyChar <= 57)
           {
               //if (this.Text.Length == 1 && e.KeyChar == 48)
               //{
               //    e.Handled = true;
               //}
               //else
               //{
                   e.Handled = false;
               //}
           }

           else
           {
               if (this.Text.Length == 0 && e.KeyChar == 46)
               {
                   e.Handled = true;
                   this.Text = "0.";
                   this.Select(2, 1);
               }
               else
               {
                   var fff = (from L in this.Text

                              where L.ToString() == "."
                              select L).Count();
                   if (fff <= 0 && e.KeyChar.ToString() == ".")

                       e.Handled = false;
                   else

                       e.Handled = true;
               }
           }
       }
    }
}
