namespace GraGUI
{
    partial class JakGrac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JakGrac));
            this.richTextBoxJakGrac = new System.Windows.Forms.RichTextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxJakGrac
            // 
            this.richTextBoxJakGrac.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBoxJakGrac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxJakGrac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxJakGrac.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxJakGrac.Name = "richTextBoxJakGrac";
            this.richTextBoxJakGrac.Size = new System.Drawing.Size(582, 313);
            this.richTextBoxJakGrac.TabIndex = 0;
            this.richTextBoxJakGrac.Text = resources.GetString("richTextBoxJakGrac.Text");
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(519, 302);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // JakGrac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 361);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.richTextBoxJakGrac);
            this.Name = "JakGrac";
            this.Text = "JakGrac";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxJakGrac;
        private System.Windows.Forms.Button buttonOk;
    }
}