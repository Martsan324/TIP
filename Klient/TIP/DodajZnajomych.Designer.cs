namespace TIP
{
    partial class DodajZnajomych
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_szukaj = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_rejestracja = new System.Windows.Forms.Button();
            this.bt_Zarejestruj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj ID lub Nick";
            // 
            // tb_szukaj
            // 
            this.tb_szukaj.Location = new System.Drawing.Point(108, 6);
            this.tb_szukaj.Name = "tb_szukaj";
            this.tb_szukaj.Size = new System.Drawing.Size(317, 20);
            this.tb_szukaj.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(108, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 134);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bt_rejestracja
            // 
            this.bt_rejestracja.BackColor = System.Drawing.Color.IndianRed;
            this.bt_rejestracja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_rejestracja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_rejestracja.Location = new System.Drawing.Point(348, 179);
            this.bt_rejestracja.Name = "bt_rejestracja";
            this.bt_rejestracja.Size = new System.Drawing.Size(77, 33);
            this.bt_rejestracja.TabIndex = 13;
            this.bt_rejestracja.Text = "Anuluj";
            this.bt_rejestracja.UseVisualStyleBackColor = false;
            this.bt_rejestracja.Click += new System.EventHandler(this.bt_rejestracja_Click);
            // 
            // bt_Zarejestruj
            // 
            this.bt_Zarejestruj.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_Zarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Zarejestruj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Zarejestruj.Location = new System.Drawing.Point(431, 179);
            this.bt_Zarejestruj.Name = "bt_Zarejestruj";
            this.bt_Zarejestruj.Size = new System.Drawing.Size(77, 33);
            this.bt_Zarejestruj.TabIndex = 14;
            this.bt_Zarejestruj.Text = "Dodaj";
            this.bt_Zarejestruj.UseVisualStyleBackColor = false;
            this.bt_Zarejestruj.Click += new System.EventHandler(this.bt_Zarejestruj_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(431, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "szukaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajZnajomych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(520, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Zarejestruj);
            this.Controls.Add(this.bt_rejestracja);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tb_szukaj);
            this.Controls.Add(this.label1);
            this.Name = "DodajZnajomych";
            this.Text = "DodajZnajomych";
            this.Load += new System.EventHandler(this.DodajZnajomych_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_szukaj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_rejestracja;
        private System.Windows.Forms.Button bt_Zarejestruj;
        private System.Windows.Forms.Button button1;
    }
}