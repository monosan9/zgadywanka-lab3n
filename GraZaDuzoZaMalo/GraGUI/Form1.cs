using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;
using static ModelGry.Gra;
using static ModelGry.Gra.Ruch;


namespace GraGUI
{
    public partial class Form1 : Form
    {
        private Gra g;

                public Form1()
        {
            InitializeComponent();
        }

        int i = 0; //start timera

        private void ButtonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosuj.Visible = true;
            buttonNowaGra.Enabled = false;
            buttonZakoncz.Visible = true;
        
            
        }
       

        private void ButtonLosuj_Click(object sender, EventArgs e)
        {
            // wczytaj zakres do losowania
            try
            {
                int a = Int16.Parse(textBoxOd.Text);
                int b = Int16.Parse(textBoxDo.Text);
                g = new Gra(a, b);


                buttonJeszczeRaz.Enabled = false;
                textBoxOd.Enabled = false;
                textBoxDo.Enabled = false;
                buttonLosuj.Enabled = false;
                groupBoxZgaduj.Visible = true;
                timer1.Enabled = true;
                labelTimer.Visible = true;
                timer1.Interval = 1000;


            }

            catch (FormatException)
            {
                MessageBox.Show("Błędny format danych. Wprowadź liczbę", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBoxOd.Text = " ";
                textBoxDo.Text = " ";
            }
            catch (OverflowException)
            {

                MessageBox.Show("Wprowadzona liczba jest za duża.", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBoxOd.Text = " ";
                textBoxDo.Text = " ";
            }

            

        }
      
        //wytypuj liczbę
        private void textBoxTwojaLiczba_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int c = int.Parse(textBoxTwojaLiczba.Text);
            }
            catch(FormatException)
            {
                textBoxTwojaLiczba.Text =" ";
            }

        }

        //sprawdzenie trafienia

        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            try
            {
                int c = Int16.Parse(textBoxTwojaLiczba.Text);

                textBox1Wynik.Visible = true;
                buttonJeszczeRaz.Enabled = true;


                Odpowiedz odp = g.Ocena(c);
                switch (odp)
                {
                    case Odpowiedz.ZaMalo:
                        textBox1Wynik.Text = "Za mało";
                        textBox1Wynik.BackColor = Color.FromArgb(255, 128, 128);
                        break;

                    case Odpowiedz.ZaDuzo:
                        textBox1Wynik.Text = "Za dużo";
                        textBox1Wynik.BackColor = Color.FromArgb(255, 128, 128);

                        break;

                    case Odpowiedz.Trafiono:
                        textBox1Wynik.Text = "Trafiłeś!";
                        textBox1Wynik.BackColor = Color.GreenYellow;
                        buttonNowaGra.Enabled = true;
                        buttonSprawdz.Enabled = false;
                        buttonJeszczeRaz.Visible = true;                                                
                        buttonHistoria.Visible = true;
                        buttonNowaGra.Enabled = false;
                        timer1.Stop();
                        i = 0;
                        
                        
                        break;
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Błędny format danych. Wprowadź liczbę", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            } 

            catch(OverflowException)
            {

                MessageBox.Show("Wprowadzona liczba jest za duża.", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        //historia rundy
        private void buttonHistoria_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"Odpowiedź: {g.Wylosowana}, Liczba ruchów: {g.LicznikRuchow}, Czas: {labelTimer.Text}, Kiedy: {DateTime.Now }");
            

            
        }
        // jeszcze raz
        private void buttonJeszczeRaz_Click(object sender, EventArgs e)
        {
            buttonLosuj.Enabled = true;
            textBoxOd.Enabled = true;
            textBoxOd.Clear();
            textBoxDo.Clear();
            textBoxDo.Enabled = true;
            groupBoxZgaduj.Visible = false;
            textBox1Wynik.Visible = false;
            textBoxTwojaLiczba.Clear();
            buttonSprawdz.Enabled = true;
            labelTimer.Text = " ";
            
                         
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            labelTimer.Text = i.ToString() + " Sek";
        }
        
    }
}
