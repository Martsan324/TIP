namespace Klient
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Polacz = new System.Windows.Forms.Button();
            this.Konsola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Polacz
            // 
            this.Polacz.Location = new System.Drawing.Point(106, 12);
            this.Polacz.Name = "Polacz";
            this.Polacz.Size = new System.Drawing.Size(138, 36);
            this.Polacz.TabIndex = 0;
            this.Polacz.Text = "Połącz";
            this.Polacz.UseVisualStyleBackColor = true;
            this.Polacz.Click += new System.EventHandler(this.Polacz_Click);
            // 
            // Konsola
            // 
            this.Konsola.Location = new System.Drawing.Point(12, 54);
            this.Konsola.Multiline = true;
            this.Konsola.Name = "Konsola";
            this.Konsola.ReadOnly = true;
            this.Konsola.Size = new System.Drawing.Size(377, 236);
            this.Konsola.TabIndex = 1;
            this.Konsola.TextChanged += new System.EventHandler(this.Konsola_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 302);
            this.Controls.Add(this.Konsola);
            this.Controls.Add(this.Polacz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Polacz;
        private System.Windows.Forms.TextBox Konsola;
    }
}

