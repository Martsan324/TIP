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
            this.lb_Log = new System.Windows.Forms.ListBox();
            this.btn_PickUp = new System.Windows.Forms.Button();
            this.btn_HangUp = new System.Windows.Forms.Button();
            this.tb_Dzwon = new System.Windows.Forms.TextBox();
            this.listBox_kontakty = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_online = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.bt_szukaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Log
            // 
            this.lb_Log.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lb_Log.FormattingEnabled = true;
            this.lb_Log.Location = new System.Drawing.Point(182, 165);
            this.lb_Log.Margin = new System.Windows.Forms.Padding(2);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(591, 199);
            this.lb_Log.TabIndex = 0;
            this.lb_Log.SelectedIndexChanged += new System.EventHandler(this.lb_Log_SelectedIndexChanged);
            // 
            // btn_PickUp
            // 
            this.btn_PickUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_PickUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PickUp.Location = new System.Drawing.Point(440, 98);
            this.btn_PickUp.Name = "btn_PickUp";
            this.btn_PickUp.Size = new System.Drawing.Size(107, 26);
            this.btn_PickUp.TabIndex = 1;
            this.btn_PickUp.Text = "Zadzwoń";
            this.btn_PickUp.UseVisualStyleBackColor = false;
            this.btn_PickUp.Click += new System.EventHandler(this.btn_PickUp_Click);
            // 
            // btn_HangUp
            // 
            this.btn_HangUp.BackColor = System.Drawing.Color.IndianRed;
            this.btn_HangUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HangUp.Location = new System.Drawing.Point(316, 98);
            this.btn_HangUp.Name = "btn_HangUp";
            this.btn_HangUp.Size = new System.Drawing.Size(107, 26);
            this.btn_HangUp.TabIndex = 2;
            this.btn_HangUp.Text = "Odrzuć";
            this.btn_HangUp.UseVisualStyleBackColor = false;
            this.btn_HangUp.Click += new System.EventHandler(this.btn_HangUp_Click);
            // 
            // tb_Dzwon
            // 
            this.tb_Dzwon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_Dzwon.Location = new System.Drawing.Point(316, 72);
            this.tb_Dzwon.Name = "tb_Dzwon";
            this.tb_Dzwon.Size = new System.Drawing.Size(231, 20);
            this.tb_Dzwon.TabIndex = 3;
            this.tb_Dzwon.TextChanged += new System.EventHandler(this.Dzwon_TextChanged);
            // 
            // listBox_kontakty
            // 
            this.listBox_kontakty.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBox_kontakty.FormattingEnabled = true;
            this.listBox_kontakty.Location = new System.Drawing.Point(11, 54);
            this.listBox_kontakty.Name = "listBox_kontakty";
            this.listBox_kontakty.Size = new System.Drawing.Size(157, 277);
            this.listBox_kontakty.TabIndex = 4;
            this.listBox_kontakty.SelectedIndexChanged += new System.EventHandler(this.listBox_kontakty_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(313, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Podaj numer lub wybierz osobę z listy kontaktów";
            // 
            // cb_online
            // 
            this.cb_online.AutoSize = true;
            this.cb_online.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_online.Location = new System.Drawing.Point(79, 31);
            this.cb_online.Name = "cb_online";
            this.cb_online.Size = new System.Drawing.Size(89, 17);
            this.cb_online.TabIndex = 6;
            this.cb_online.Text = "Pokaż Offline";
            this.cb_online.UseVisualStyleBackColor = true;
            this.cb_online.CheckedChanged += new System.EventHandler(this.cb_online_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(688, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Twoje ID:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_ID.Location = new System.Drawing.Point(738, 5);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(35, 13);
            this.lb_ID.TabIndex = 8;
            this.lb_ID.Text = "NULL";
            // 
            // bt_szukaj
            // 
            this.bt_szukaj.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_szukaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_szukaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_szukaj.Location = new System.Drawing.Point(11, 337);
            this.bt_szukaj.Name = "bt_szukaj";
            this.bt_szukaj.Size = new System.Drawing.Size(157, 27);
            this.bt_szukaj.TabIndex = 16;
            this.bt_szukaj.Text = "Szukaj Znajomych";
            this.bt_szukaj.UseVisualStyleBackColor = false;
            this.bt_szukaj.Click += new System.EventHandler(this.bt_szukaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(24, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "LISTA KONTAKTÓW:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(785, 374);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_szukaj);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_online);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_kontakty);
            this.Controls.Add(this.tb_Dzwon);
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
        private System.Windows.Forms.TextBox tb_Dzwon;
        private System.Windows.Forms.ListBox listBox_kontakty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_online;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Button bt_szukaj;
        private System.Windows.Forms.Label label3;
    }
}

