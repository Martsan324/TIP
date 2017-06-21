namespace TIP
{
    partial class DodajAwatar
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
            this.bt_SprawdzAvatar = new System.Windows.Forms.Button();
            this.bt_Zarejestruj = new System.Windows.Forms.Button();
            this.bt_rejestracja = new System.Windows.Forms.Button();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_dodawanyAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dodawanyAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_SprawdzAvatar
            // 
            this.bt_SprawdzAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bt_SprawdzAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SprawdzAvatar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_SprawdzAvatar.Location = new System.Drawing.Point(431, 12);
            this.bt_SprawdzAvatar.Name = "bt_SprawdzAvatar";
            this.bt_SprawdzAvatar.Size = new System.Drawing.Size(77, 23);
            this.bt_SprawdzAvatar.TabIndex = 18;
            this.bt_SprawdzAvatar.Text = "Sprawdź";
            this.bt_SprawdzAvatar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_SprawdzAvatar.UseVisualStyleBackColor = false;
            this.bt_SprawdzAvatar.Click += new System.EventHandler(this.bt_SprawdzAvatar_Click);
            // 
            // bt_Zarejestruj
            // 
            this.bt_Zarejestruj.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_Zarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Zarejestruj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Zarejestruj.Location = new System.Drawing.Point(431, 185);
            this.bt_Zarejestruj.Name = "bt_Zarejestruj";
            this.bt_Zarejestruj.Size = new System.Drawing.Size(77, 33);
            this.bt_Zarejestruj.TabIndex = 17;
            this.bt_Zarejestruj.Text = "Dodaj";
            this.bt_Zarejestruj.UseVisualStyleBackColor = false;
            this.bt_Zarejestruj.Click += new System.EventHandler(this.bt_Zarejestruj_Click);
            // 
            // bt_rejestracja
            // 
            this.bt_rejestracja.BackColor = System.Drawing.Color.IndianRed;
            this.bt_rejestracja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_rejestracja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_rejestracja.Location = new System.Drawing.Point(348, 185);
            this.bt_rejestracja.Name = "bt_rejestracja";
            this.bt_rejestracja.Size = new System.Drawing.Size(77, 33);
            this.bt_rejestracja.TabIndex = 16;
            this.bt_rejestracja.Text = "Anuluj";
            this.bt_rejestracja.UseVisualStyleBackColor = false;
            this.bt_rejestracja.Click += new System.EventHandler(this.bt_rejestracja_Click);
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(130, 12);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(295, 20);
            this.tb_url.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Podaj URL do obrazu:";
            // 
            // pb_dodawanyAvatar
            // 
            this.pb_dodawanyAvatar.Location = new System.Drawing.Point(227, 49);
            this.pb_dodawanyAvatar.Name = "pb_dodawanyAvatar";
            this.pb_dodawanyAvatar.Size = new System.Drawing.Size(100, 100);
            this.pb_dodawanyAvatar.TabIndex = 21;
            this.pb_dodawanyAvatar.TabStop = false;
            // 
            // DodajAwatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(520, 224);
            this.Controls.Add(this.pb_dodawanyAvatar);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_SprawdzAvatar);
            this.Controls.Add(this.bt_Zarejestruj);
            this.Controls.Add(this.bt_rejestracja);
            this.Name = "DodajAwatar";
            this.Text = "DodajAwatar";
            ((System.ComponentModel.ISupportInitialize)(this.pb_dodawanyAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_SprawdzAvatar;
        private System.Windows.Forms.Button bt_Zarejestruj;
        private System.Windows.Forms.Button bt_rejestracja;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_dodawanyAvatar;
    }
}