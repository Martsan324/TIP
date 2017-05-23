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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie));
            this.Lb_login = new System.Windows.Forms.Label();
            this.lb_haslo = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_haslo = new System.Windows.Forms.TextBox();
            this.bt_LogIn = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_rejestracja = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_login
            // 
            this.Lb_login.AutoSize = true;
            this.Lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lb_login.ForeColor = System.Drawing.SystemColors.Control;
            this.Lb_login.Location = new System.Drawing.Point(45, 226);
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
            this.lb_haslo.Location = new System.Drawing.Point(44, 253);
            this.lb_haslo.Name = "lb_haslo";
            this.lb_haslo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_haslo.Size = new System.Drawing.Size(58, 24);
            this.lb_haslo.TabIndex = 1;
            this.lb_haslo.Text = "Haslo";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(108, 230);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(231, 20);
            this.tb_login.TabIndex = 2;
            // 
            // tb_haslo
            // 
            this.tb_haslo.Location = new System.Drawing.Point(108, 253);
            this.tb_haslo.Name = "tb_haslo";
            this.tb_haslo.PasswordChar = '•';
            this.tb_haslo.Size = new System.Drawing.Size(231, 20);
            this.tb_haslo.TabIndex = 3;
            // 
            // bt_LogIn
            // 
            this.bt_LogIn.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_LogIn.Location = new System.Drawing.Point(266, 279);
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
            this.bt_Exit.Location = new System.Drawing.Point(108, 279);
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
            this.bt_rejestracja.Location = new System.Drawing.Point(187, 279);
            this.bt_rejestracja.Name = "bt_rejestracja";
            this.bt_rejestracja.Size = new System.Drawing.Size(73, 33);
            this.bt_rejestracja.TabIndex = 6;
            this.bt_rejestracja.Text = "Rejestracja";
            this.bt_rejestracja.UseVisualStyleBackColor = false;
            this.bt_rejestracja.Click += new System.EventHandler(this.bt_rejestracja_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TIP.Properties.Resources.voip_phone_icon_jpg;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}