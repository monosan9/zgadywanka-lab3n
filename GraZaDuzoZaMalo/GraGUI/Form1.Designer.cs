using System;

namespace GraGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.labelDo = new System.Windows.Forms.Label();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.labelOd = new System.Windows.Forms.Label();
            this.labelOdgadnij = new System.Windows.Forms.Label();
            this.labelCzas = new System.Windows.Forms.Label();
            this.textBoxTwojaLiczba = new System.Windows.Forms.TextBox();
            this.groupBoxZgaduj = new System.Windows.Forms.GroupBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.buttonZakoncz = new System.Windows.Forms.Button();
            this.buttonHistoria = new System.Windows.Forms.Button();
            this.buttonJakGrac = new System.Windows.Forms.Button();
            this.textBox1Wynik = new System.Windows.Forms.TextBox();
            this.buttonJeszczeRaz = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxLosuj.SuspendLayout();
            this.groupBoxZgaduj.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(13, 13);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.ButtonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonLosuj);
            this.groupBoxLosuj.Controls.Add(this.textBoxDo);
            this.groupBoxLosuj.Controls.Add(this.labelDo);
            this.groupBoxLosuj.Controls.Add(this.textBoxOd);
            this.groupBoxLosuj.Controls.Add(this.labelOd);
            this.groupBoxLosuj.Location = new System.Drawing.Point(13, 52);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Size = new System.Drawing.Size(302, 100);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(207, 40);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonLosuj.TabIndex = 2;
            this.buttonLosuj.Text = "Wylosuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.ButtonLosuj_Click);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(82, 63);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDo.TabIndex = 3;
            // 
            // labelDo
            // 
            this.labelDo.AutoSize = true;
            this.labelDo.Location = new System.Drawing.Point(17, 66);
            this.labelDo.Name = "labelDo";
            this.labelDo.Size = new System.Drawing.Size(58, 13);
            this.labelDo.TabIndex = 2;
            this.labelDo.Text = "Zakres do:";
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(82, 17);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 1;
            // 
            // labelOd
            // 
            this.labelOd.AutoSize = true;
            this.labelOd.Location = new System.Drawing.Point(18, 20);
            this.labelOd.Name = "labelOd";
            this.labelOd.Size = new System.Drawing.Size(58, 13);
            this.labelOd.TabIndex = 0;
            this.labelOd.Text = "Zakres od:";
            // 
            // labelOdgadnij
            // 
            this.labelOdgadnij.AutoSize = true;
            this.labelOdgadnij.Location = new System.Drawing.Point(6, 16);
            this.labelOdgadnij.Name = "labelOdgadnij";
            this.labelOdgadnij.Size = new System.Drawing.Size(143, 13);
            this.labelOdgadnij.TabIndex = 3;
            this.labelOdgadnij.Text = "Odgadnij wylosowaną liczbę:";
            // 
            // labelCzas
            // 
            this.labelCzas.AutoSize = true;
            this.labelCzas.Location = new System.Drawing.Point(224, 16);
            this.labelCzas.Name = "labelCzas";
            this.labelCzas.Size = new System.Drawing.Size(58, 13);
            this.labelCzas.TabIndex = 4;
            this.labelCzas.Text = "Twój czas:";
            // 
            // textBoxTwojaLiczba
            // 
            this.textBoxTwojaLiczba.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTwojaLiczba.Location = new System.Drawing.Point(9, 42);
            this.textBoxTwojaLiczba.Name = "textBoxTwojaLiczba";
            this.textBoxTwojaLiczba.Size = new System.Drawing.Size(100, 20);
            this.textBoxTwojaLiczba.TabIndex = 5;
            this.textBoxTwojaLiczba.TextChanged += new System.EventHandler(this.textBoxTwojaLiczba_TextChanged);
            // 
            // groupBoxZgaduj
            // 
            this.groupBoxZgaduj.Controls.Add(this.labelTimer);
            this.groupBoxZgaduj.Controls.Add(this.buttonSprawdz);
            this.groupBoxZgaduj.Controls.Add(this.labelOdgadnij);
            this.groupBoxZgaduj.Controls.Add(this.labelCzas);
            this.groupBoxZgaduj.Controls.Add(this.textBoxTwojaLiczba);
            this.groupBoxZgaduj.Location = new System.Drawing.Point(13, 158);
            this.groupBoxZgaduj.Name = "groupBoxZgaduj";
            this.groupBoxZgaduj.Size = new System.Drawing.Size(302, 82);
            this.groupBoxZgaduj.TabIndex = 6;
            this.groupBoxZgaduj.TabStop = false;
            this.groupBoxZgaduj.Visible = false;
            
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(235, 42);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(0, 13);
            this.labelTimer.TabIndex = 7;
            this.labelTimer.Visible = false;
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(126, 40);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.buttonSprawdz.TabIndex = 6;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            // 
            // buttonZakoncz
            // 
            this.buttonZakoncz.Location = new System.Drawing.Point(220, 334);
            this.buttonZakoncz.Name = "buttonZakoncz";
            this.buttonZakoncz.Size = new System.Drawing.Size(75, 23);
            this.buttonZakoncz.TabIndex = 7;
            this.buttonZakoncz.Text = "Zakończ";
            this.buttonZakoncz.UseVisualStyleBackColor = true;
            this.buttonZakoncz.Visible = false;
            this.buttonZakoncz.Click += new System.EventHandler(this.ButtonZakoncz_Click);
            // 
            // buttonHistoria
            // 
            this.buttonHistoria.Location = new System.Drawing.Point(22, 334);
            this.buttonHistoria.Name = "buttonHistoria";
            this.buttonHistoria.Size = new System.Drawing.Size(75, 23);
            this.buttonHistoria.TabIndex = 8;
            this.buttonHistoria.Text = "Historia";
            this.buttonHistoria.UseVisualStyleBackColor = true;
            this.buttonHistoria.Visible = false;
            this.buttonHistoria.Click += new System.EventHandler(this.buttonHistoria_Click);
            // 
            // buttonJakGrac
            // 
            this.buttonJakGrac.Location = new System.Drawing.Point(220, 13);
            this.buttonJakGrac.Name = "buttonJakGrac";
            this.buttonJakGrac.Size = new System.Drawing.Size(75, 23);
            this.buttonJakGrac.TabIndex = 9;
            this.buttonJakGrac.Text = "Jak grać?";
            this.buttonJakGrac.UseVisualStyleBackColor = true;
            this.buttonJakGrac.Click += new System.EventHandler(this.buttonJakGrac_Click);
            // 
            // textBox1Wynik
            // 
            this.textBox1Wynik.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1Wynik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1Wynik.Location = new System.Drawing.Point(22, 246);
            this.textBox1Wynik.Name = "textBox1Wynik";
            this.textBox1Wynik.Size = new System.Drawing.Size(100, 13);
            this.textBox1Wynik.TabIndex = 10;
            this.textBox1Wynik.Text = "Za mało";
            this.textBox1Wynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1Wynik.Visible = false;
            // 
            // buttonJeszczeRaz
            // 
            this.buttonJeszczeRaz.Location = new System.Drawing.Point(139, 12);
            this.buttonJeszczeRaz.Name = "buttonJeszczeRaz";
            this.buttonJeszczeRaz.Size = new System.Drawing.Size(75, 23);
            this.buttonJeszczeRaz.TabIndex = 11;
            this.buttonJeszczeRaz.Text = "Jeszcze raz";
            this.buttonJeszczeRaz.UseVisualStyleBackColor = true;
            this.buttonJeszczeRaz.Visible = false;
            this.buttonJeszczeRaz.Click += new System.EventHandler(this.buttonJeszczeRaz_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 393);
            this.Controls.Add(this.buttonJeszczeRaz);
            this.Controls.Add(this.textBox1Wynik);
            this.Controls.Add(this.buttonJakGrac);
            this.Controls.Add(this.buttonHistoria);
            this.Controls.Add(this.buttonZakoncz);
            this.Controls.Add(this.groupBoxZgaduj);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Gra Za dużo Za Mało";
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.groupBoxZgaduj.ResumeLayout(false);
            this.groupBoxZgaduj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.Label labelDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label labelOd;
        private System.Windows.Forms.Label labelOdgadnij;
        private System.Windows.Forms.Label labelCzas;
        private System.Windows.Forms.TextBox textBoxTwojaLiczba;
        private System.Windows.Forms.GroupBox groupBoxZgaduj;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Button buttonZakoncz;
        private System.Windows.Forms.Button buttonHistoria;
        private System.Windows.Forms.Button buttonJakGrac;
        private System.Windows.Forms.TextBox textBox1Wynik;
        private System.Windows.Forms.Button buttonJeszczeRaz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
    }
}

