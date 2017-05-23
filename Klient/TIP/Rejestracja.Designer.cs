namespace TIP
{
    partial class Rejestracja
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
            this.lb_haslo = new System.Windows.Forms.Label();
            this.Lb_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Nick = new System.Windows.Forms.TextBox();
            this.tb_Haslo = new System.Windows.Forms.TextBox();
            this.tb_PHaslo = new System.Windows.Forms.TextBox();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.bt_Zarejestruj = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_rejestracja = new System.Windows.Forms.Button();
            this.Error_Nick = new System.Windows.Forms.Label();
            this.Error_Haslo = new System.Windows.Forms.Label();
            this.Error_mail = new System.Windows.Forms.Label();
            this.Error_BHaslo = new System.Windows.Forms.Label();
            this.Error_NMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_haslo
            // 
            this.lb_haslo.AutoSize = true;
            this.lb_haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_haslo.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_haslo.Location = new System.Drawing.Point(71, 92);
            this.lb_haslo.Name = "lb_haslo";
            this.lb_haslo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_haslo.Size = new System.Drawing.Size(58, 24);
            this.lb_haslo.TabIndex = 3;
            this.lb_haslo.Text = "Haslo";
            // 
            // Lb_login
            // 
            this.Lb_login.AutoSize = true;
            this.Lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lb_login.ForeColor = System.Drawing.SystemColors.Control;
            this.Lb_login.Location = new System.Drawing.Point(71, 68);
            this.Lb_login.Name = "Lb_login";
            this.Lb_login.Size = new System.Drawing.Size(47, 24);
            this.Lb_login.TabIndex = 2;
            this.Lb_login.Text = "Nick";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(71, 116);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Powtórz Haslo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(71, 141);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mail";
            // 
            // tb_Nick
            // 
            this.tb_Nick.Location = new System.Drawing.Point(207, 68);
            this.tb_Nick.Name = "tb_Nick";
            this.tb_Nick.Size = new System.Drawing.Size(243, 20);
            this.tb_Nick.TabIndex = 6;
            // 
            // tb_Haslo
            // 
            this.tb_Haslo.Location = new System.Drawing.Point(207, 94);
            this.tb_Haslo.Name = "tb_Haslo";
            this.tb_Haslo.PasswordChar = '*';
            this.tb_Haslo.Size = new System.Drawing.Size(243, 20);
            this.tb_Haslo.TabIndex = 7;
            this.tb_Haslo.UseSystemPasswordChar = true;
            // 
            // tb_PHaslo
            // 
            this.tb_PHaslo.Location = new System.Drawing.Point(207, 120);
            this.tb_PHaslo.Name = "tb_PHaslo";
            this.tb_PHaslo.PasswordChar = '*';
            this.tb_PHaslo.Size = new System.Drawing.Size(243, 20);
            this.tb_PHaslo.TabIndex = 8;
            this.tb_PHaslo.UseSystemPasswordChar = true;
            // 
            // tb_Mail
            // 
            this.tb_Mail.Location = new System.Drawing.Point(207, 147);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(243, 20);
            this.tb_Mail.TabIndex = 9;
            // 
            // bt_Zarejestruj
            // 
            this.bt_Zarejestruj.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_Zarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Zarejestruj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Zarejestruj.Location = new System.Drawing.Point(373, 186);
            this.bt_Zarejestruj.Name = "bt_Zarejestruj";
            this.bt_Zarejestruj.Size = new System.Drawing.Size(77, 33);
            this.bt_Zarejestruj.TabIndex = 10;
            this.bt_Zarejestruj.Text = "Zarejestruj";
            this.bt_Zarejestruj.UseVisualStyleBackColor = false;
            this.bt_Zarejestruj.Click += new System.EventHandler(this.bt_LogIn_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.IndianRed;
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Exit.Location = new System.Drawing.Point(207, 186);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(77, 33);
            this.bt_Exit.TabIndex = 11;
            this.bt_Exit.Text = "Wyjście";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_rejestracja
            // 
            this.bt_rejestracja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bt_rejestracja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_rejestracja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_rejestracja.Location = new System.Drawing.Point(290, 186);
            this.bt_rejestracja.Name = "bt_rejestracja";
            this.bt_rejestracja.Size = new System.Drawing.Size(77, 33);
            this.bt_rejestracja.TabIndex = 12;
            this.bt_rejestracja.Text = "Anuluj";
            this.bt_rejestracja.UseVisualStyleBackColor = false;
            this.bt_rejestracja.Click += new System.EventHandler(this.bt_rejestracja_Click);
            // 
            // Error_Nick
            // 
            this.Error_Nick.AutoSize = true;
            this.Error_Nick.ForeColor = System.Drawing.Color.Red;
            this.Error_Nick.Location = new System.Drawing.Point(456, 71);
            this.Error_Nick.Name = "Error_Nick";
            this.Error_Nick.Size = new System.Drawing.Size(78, 13);
            this.Error_Nick.TabIndex = 13;
            this.Error_Nick.Text = "Nick jest zajęty";
            // 
            // Error_Haslo
            // 
            this.Error_Haslo.AutoSize = true;
            this.Error_Haslo.ForeColor = System.Drawing.Color.Red;
            this.Error_Haslo.Location = new System.Drawing.Point(456, 123);
            this.Error_Haslo.Name = "Error_Haslo";
            this.Error_Haslo.Size = new System.Drawing.Size(191, 13);
            this.Error_Haslo.TabIndex = 14;
            this.Error_Haslo.Text = "Wprowadzone hasła nie są takie same";
            // 
            // Error_mail
            // 
            this.Error_mail.AutoSize = true;
            this.Error_mail.ForeColor = System.Drawing.Color.Red;
            this.Error_mail.Location = new System.Drawing.Point(456, 154);
            this.Error_mail.Name = "Error_mail";
            this.Error_mail.Size = new System.Drawing.Size(75, 13);
            this.Error_mail.TabIndex = 16;
            this.Error_mail.Text = "Mail jest zajęty";
            // 
            // Error_BHaslo
            // 
            this.Error_BHaslo.AutoSize = true;
            this.Error_BHaslo.ForeColor = System.Drawing.Color.Red;
            this.Error_BHaslo.Location = new System.Drawing.Point(234, 170);
            this.Error_BHaslo.Name = "Error_BHaslo";
            this.Error_BHaslo.Size = new System.Drawing.Size(186, 13);
            this.Error_BHaslo.TabIndex = 17;
            this.Error_BHaslo.Text = "Niektóre pola nie zostały uzupełnione";
            // 
            // Error_NMail
            // 
            this.Error_NMail.AutoSize = true;
            this.Error_NMail.ForeColor = System.Drawing.Color.Red;
            this.Error_NMail.Location = new System.Drawing.Point(456, 154);
            this.Error_NMail.Name = "Error_NMail";
            this.Error_NMail.Size = new System.Drawing.Size(108, 13);
            this.Error_NMail.TabIndex = 18;
            this.Error_NMail.Text = "Mail jest niepoprawny";
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.Error_NMail);
            this.Controls.Add(this.Error_BHaslo);
            this.Controls.Add(this.Error_mail);
            this.Controls.Add(this.Error_Haslo);
            this.Controls.Add(this.Error_Nick);
            this.Controls.Add(this.bt_rejestracja);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Zarejestruj);
            this.Controls.Add(this.tb_Mail);
            this.Controls.Add(this.tb_PHaslo);
            this.Controls.Add(this.tb_Haslo);
            this.Controls.Add(this.tb_Nick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_haslo);
            this.Controls.Add(this.Lb_login);
            this.Name = "Rejestracja";
            this.Text = "Rejestracja";
            this.Load += new System.EventHandler(this.Rejestracja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_haslo;
        private System.Windows.Forms.Label Lb_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Nick;
        private System.Windows.Forms.TextBox tb_Haslo;
        private System.Windows.Forms.TextBox tb_PHaslo;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.Button bt_Zarejestruj;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_rejestracja;
        private System.Windows.Forms.Label Error_Nick;
        private System.Windows.Forms.Label Error_Haslo;
        private System.Windows.Forms.Label Error_mail;
        private System.Windows.Forms.Label Error_BHaslo;
        private System.Windows.Forms.Label Error_NMail;
    }
}