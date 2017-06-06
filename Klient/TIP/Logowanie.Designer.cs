namespace TIP
{
    partial class Logowanie
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
            this.Lb_login = new System.Windows.Forms.Label();
            this.lb_haslo = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_haslo = new System.Windows.Forms.TextBox();
            this.bt_LogIn = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_rejestracja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lb_login
            // 
            this.Lb_login.AutoSize = true;
            this.Lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lb_login.ForeColor = System.Drawing.SystemColors.Control;
            this.Lb_login.Location = new System.Drawing.Point(48, 90);
            this.Lb_login.Name = "Lb_login";
            this.Lb_login.Size = new System.Drawing.Size(47, 24);
            this.Lb_login.TabIndex = 0;
            this.Lb_login.Text = "Nick";
            // 
            // lb_haslo
            // 
            this.lb_haslo.AutoSize = true;
            this.lb_haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_haslo.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_haslo.Location = new System.Drawing.Point(47, 117);
            this.lb_haslo.Name = "lb_haslo";
            this.lb_haslo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_haslo.Size = new System.Drawing.Size(58, 24);
            this.lb_haslo.TabIndex = 1;
            this.lb_haslo.Text = "Haslo";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(111, 94);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(231, 20);
            this.tb_login.TabIndex = 2;
            this.tb_login.Text = "Martsan";
            // 
            // tb_haslo
            // 
            this.tb_haslo.Location = new System.Drawing.Point(111, 117);
            this.tb_haslo.Name = "tb_haslo";
            this.tb_haslo.PasswordChar = '•';
            this.tb_haslo.Size = new System.Drawing.Size(231, 20);
            this.tb_haslo.TabIndex = 3;
            this.tb_haslo.Text = "1234";
            // 
            // bt_LogIn
            // 
            this.bt_LogIn.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_LogIn.Location = new System.Drawing.Point(269, 143);
            this.bt_LogIn.Name = "bt_LogIn";
            this.bt_LogIn.Size = new System.Drawing.Size(73, 33);
            this.bt_LogIn.TabIndex = 4;
            this.bt_LogIn.Text = "Zaloguj";
            this.bt_LogIn.UseVisualStyleBackColor = false;
            this.bt_LogIn.Click += new System.EventHandler(this.bt_LogIn_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.IndianRed;
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Exit.Location = new System.Drawing.Point(111, 143);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(73, 33);
            this.bt_Exit.TabIndex = 5;
            this.bt_Exit.Text = "Wyjście";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_rejestracja
            // 
            this.bt_rejestracja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bt_rejestracja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_rejestracja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_rejestracja.Location = new System.Drawing.Point(190, 143);
            this.bt_rejestracja.Name = "bt_rejestracja";
            this.bt_rejestracja.Size = new System.Drawing.Size(73, 33);
            this.bt_rejestracja.TabIndex = 6;
            this.bt_rejestracja.Text = "Rejestracja";
            this.bt_rejestracja.UseVisualStyleBackColor = false;
            this.bt_rejestracja.Click += new System.EventHandler(this.bt_rejestracja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(63, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Telefonia IP";
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(404, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_rejestracja);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_LogIn);
            this.Controls.Add(this.tb_haslo);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lb_haslo);
            this.Controls.Add(this.Lb_login);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Logowanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_login;
        private System.Windows.Forms.Label lb_haslo;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_haslo;
        private System.Windows.Forms.Button bt_LogIn;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_rejestracja;
        private System.Windows.Forms.Label label1;
    }
}