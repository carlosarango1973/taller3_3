using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taller3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(txtnumero1.Text);
            int n2 = Convert.ToInt16(txtnumero2.Text);
            if (n1 > n2)
            { 
                lblmensaje.Text = "el numero 1 es mayor al numero 2";
            }
            else
            {
                if (n2 > n1)
            {
                lblmensaje.Text = "el numero 2 es mayor al numero 1";
            }
            else
            {
                    lblmensaje.Text = "son iguales";
                }
            
            }
        }
    }
}
