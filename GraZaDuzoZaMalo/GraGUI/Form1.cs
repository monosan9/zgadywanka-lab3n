using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = true;
            buttonNowaGra.Enabled = false;
            buttonPrzerwij.Visible = true;
            buttonZakoncz.Visible = true;
            
                
            
        }
        private void ButtonPrzerwij_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void ButtonLosuj_Click(object sender, EventArgs e)
        {
            // wczytaj zakres do losowania
            int a = int.Parse( textBoxOd.Text );
            int b = int.Parse( textBoxDo.Text );
            


            // utwórz grę
            g = new Gra(a, b);

            textBoxOd.Enabled = false;
            textBoxDo.Enabled = false;
            buttonLosuj.Enabled = false;
            groupBoxZgaduj.Visible = true;
            
            

            // wyświetl kolejne elementy formularza
           
        }

        private void ButtonZakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
