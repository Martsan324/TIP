namespace TIP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lb_Log = new System.Windows.Forms.ListBox();
            this.btn_PickUp = new System.Windows.Forms.Button();
            this.btn_HangUp = new System.Windows.Forms.Button();
            this.Dzwon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Log
            // 
            this.lb_Log.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lb_Log.FormattingEnabled = true;
            this.lb_Log.Location = new System.Drawing.Point(11, 368);
            this.lb_Log.Margin = new System.Windows.Forms.Padding(2);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(762, 82);
            this.lb_Log.TabIndex = 0;
            this.lb_Log.SelectedIndexChanged += new System.EventHandler(this.lb_Log_SelectedIndexChanged);
            // 
            // btn_PickUp
            // 
            this.btn_PickUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_PickUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PickUp.BackgroundImage")));
            this.btn_PickUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PickUp.Location = new System.Drawing.Point(497, 283);
            this.btn_PickUp.Name = "btn_PickUp";
            this.btn_PickUp.Size = new System.Drawing.Size(80, 80);
            this.btn_PickUp.TabIndex = 1;
            this.btn_PickUp.UseVisualStyleBackColor = false;
            this.btn_PickUp.Click += new System.EventHandler(this.btn_PickUp_Click);
            // 
            // btn_HangUp
            // 
            this.btn_HangUp.BackColor = System.Drawing.Color.IndianRed;
            this.btn_HangUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HangUp.BackgroundImage")));
            this.btn_HangUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HangUp.Location = new System.Drawing.Point(319, 283);
            this.btn_HangUp.Name = "btn_HangUp";
            this.btn_HangUp.Size = new System.Drawing.Size(80, 80);
            this.btn_HangUp.TabIndex = 2;
            this.btn_HangUp.UseVisualStyleBackColor = false;
            this.btn_HangUp.Click += new System.EventHandler(this.btn_HangUp_Click);
            // 
            // Dzwon
            // 
            this.Dzwon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Dzwon.Location = new System.Drawing.Point(319, 257);
            this.Dzwon.Name = "Dzwon";
            this.Dzwon.Size = new System.Drawing.Size(258, 20);
            this.Dzwon.TabIndex = 3;
            this.Dzwon.Text = "Podaj ID użytkownka do którego chcesz zadzwonić";
            this.Dzwon.TextChanged += new System.EventHandler(this.Dzwon_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Dzwon);
            this.Controls.Add(this.btn_HangUp);
            this.Controls.Add(this.btn_PickUp);
            this.Controls.Add(this.lb_Log);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Log;
        private System.Windows.Forms.Button btn_PickUp;
        private System.Windows.Forms.Button btn_HangUp;
        private System.Windows.Forms.TextBox Dzwon;
    }
}

