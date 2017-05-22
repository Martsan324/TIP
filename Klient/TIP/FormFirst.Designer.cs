namespace TIP
{
    partial class FormFirst
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
            this.lb_Log = new System.Windows.Forms.ListBox();
            this.btn_PickUp = new System.Windows.Forms.Button();
            this.btn_HangUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Log
            // 
            this.lb_Log.FormattingEnabled = true;
            this.lb_Log.Location = new System.Drawing.Point(9, 10);
            this.lb_Log.Margin = new System.Windows.Forms.Padding(2);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(272, 368);
            this.lb_Log.TabIndex = 0;
            this.lb_Log.SelectedIndexChanged += new System.EventHandler(this.lb_Log_SelectedIndexChanged);
            // 
            // btn_PickUp
            // 
            this.btn_PickUp.Location = new System.Drawing.Point(299, 21);
            this.btn_PickUp.Name = "btn_PickUp";
            this.btn_PickUp.Size = new System.Drawing.Size(76, 21);
            this.btn_PickUp.TabIndex = 1;
            this.btn_PickUp.Text = "Pick Up";
            this.btn_PickUp.UseVisualStyleBackColor = true;
            this.btn_PickUp.Click += new System.EventHandler(this.btn_PickUp_Click);
            // 
            // btn_HangUp
            // 
            this.btn_HangUp.Location = new System.Drawing.Point(426, 21);
            this.btn_HangUp.Name = "btn_HangUp";
            this.btn_HangUp.Size = new System.Drawing.Size(76, 21);
            this.btn_HangUp.TabIndex = 2;
            this.btn_HangUp.Text = "Hang Up";
            this.btn_HangUp.UseVisualStyleBackColor = true;
            this.btn_HangUp.Click += new System.EventHandler(this.btn_HangUp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "PRZEJDŹ DO NOWEGO WYGLĄDU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_HangUp);
            this.Controls.Add(this.btn_PickUp);
            this.Controls.Add(this.lb_Log);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Log;
        private System.Windows.Forms.Button btn_PickUp;
        private System.Windows.Forms.Button btn_HangUp;
        private System.Windows.Forms.Button button1;
    }
}

