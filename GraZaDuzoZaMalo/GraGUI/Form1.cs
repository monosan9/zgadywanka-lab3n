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
using static ModelGry.Gra;

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
            buttonZakoncz.Visible = true;
               
            
        }
        private void ButtonPrzerwij_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void ButtonLosuj_Click(object sender, EventArgs e)
        {
            // wczytaj zakres do losowania
            try
            {
                int a = int.Parse(textBoxOd.Text);
                int b = int.Parse(textBoxDo.Text);
                g = new Gra(a, b);
            }

            catch (FormatException)
            {
                MessageBox.Show("Błędny format danych. Wprowadź liczbę", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            
            // utwórz grę
           
            textBoxOd.Enabled = false;
            textBoxDo.Enabled = false;
            buttonLosuj.Enabled = false;
            groupBoxZgaduj.Visible = true;
            
            

            // wyświetl kolejne elementy formularza
           
        }
        //zakoncz gre
        private void ButtonZakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //instrukcja obslugi
        private void buttonJakGrac_Click(object sender, EventArgs e)
        {
            JakGrac jakGrac = new JakGrac();
            jakGrac.Show();
        }

        //wytypuj liczbę
        private void textBoxTwojaLiczba_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int c = int.Parse(textBoxTwojaLiczba.Text);
               
            }

            catch (FormatException)
            {
                MessageBox.Show("Błędny format danych. Wprowadź liczbę", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }

        //sprawdzenie trafienia
        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            Odpowiedz odp = new Odpowiedz();
            textBox1Wynik.Visible = true;
            
        }
    }
}
