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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_login = new System.Windows.Forms.TextBox();
            this.text_haslo = new System.Windows.Forms.TextBox();
            this.label_blad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(160, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zaloguj się";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(88, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(82, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "hasło:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // text_login
            // 
            this.text_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_login.Location = new System.Drawing.Point(134, 195);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(192, 26);
            this.text_login.TabIndex = 3;
            // 
            // text_haslo
            // 
            this.text_haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_haslo.Location = new System.Drawing.Point(134, 239);
            this.text_haslo.Name = "text_haslo";
            this.text_haslo.PasswordChar = '*';
            this.text_haslo.Size = new System.Drawing.Size(192, 26);
            this.text_haslo.TabIndex = 4;
            // 
            // label_blad
            // 
            this.label_blad.AutoSize = true;
            this.label_blad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_blad.ForeColor = System.Drawing.Color.Red;
            this.label_blad.Location = new System.Drawing.Point(144, 158);
            this.label_blad.Name = "label_blad";
            this.label_blad.Size = new System.Drawing.Size(499, 24);
            this.label_blad.TabIndex = 5;
            this.label_blad.Text = "Podałeś nieprawidłowy login lub hasło spróbuj ponownie";
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 329);
            this.Controls.Add(this.label_blad);
            this.Controls.Add(this.text_haslo);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.TextBox text_haslo;
        private System.Windows.Forms.Label label_blad;
    }
}