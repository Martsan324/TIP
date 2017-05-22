namespace TIP
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.but_listapokoi = new System.Windows.Forms.Button();
            this.button_polaczonyserwer = new System.Windows.Forms.Button();
            this.button_ustawienia = new System.Windows.Forms.Button();
            this.button_adminpokoje = new System.Windows.Forms.Button();
            this.button_ustawieniaglobalne = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Witaj, Administrator!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(9, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Wyloguj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // but_listapokoi
            // 
            this.but_listapokoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_listapokoi.Location = new System.Drawing.Point(10, 181);
            this.but_listapokoi.Name = "but_listapokoi";
            this.but_listapokoi.Size = new System.Drawing.Size(120, 52);
            this.but_listapokoi.TabIndex = 4;
            this.but_listapokoi.Text = "Dostępne pokoje";
            this.but_listapokoi.UseVisualStyleBackColor = true;
            // 
            // button_polaczonyserwer
            // 
            this.button_polaczonyserwer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_polaczonyserwer.Location = new System.Drawing.Point(11, 239);
            this.button_polaczonyserwer.Name = "button_polaczonyserwer";
            this.button_polaczonyserwer.Size = new System.Drawing.Size(119, 55);
            this.button_polaczonyserwer.TabIndex = 6;
            this.button_polaczonyserwer.Text = "Połączony pokój";
            this.button_polaczonyserwer.UseVisualStyleBackColor = true;
            // 
            // button_ustawienia
            // 
            this.button_ustawienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ustawienia.Location = new System.Drawing.Point(11, 300);
            this.button_ustawienia.Name = "button_ustawienia";
            this.button_ustawienia.Size = new System.Drawing.Size(119, 49);
            this.button_ustawienia.TabIndex = 7;
            this.button_ustawienia.Text = "Ustawienia klienta";
            this.button_ustawienia.UseVisualStyleBackColor = true;
            // 
            // button_adminpokoje
            // 
            this.button_adminpokoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_adminpokoje.Location = new System.Drawing.Point(10, 355);
            this.button_adminpokoje.Name = "button_adminpokoje";
            this.button_adminpokoje.Size = new System.Drawing.Size(119, 49);
            this.button_adminpokoje.TabIndex = 8;
            this.button_adminpokoje.Text = "Ustawienia pokoi";
            this.button_adminpokoje.UseVisualStyleBackColor = true;
            this.button_adminpokoje.Click += new System.EventHandler(this.button_adminpokoje_Click);
            // 
            // button_ustawieniaglobalne
            // 
            this.button_ustawieniaglobalne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ustawieniaglobalne.Location = new System.Drawing.Point(11, 410);
            this.button_ustawieniaglobalne.Name = "button_ustawieniaglobalne";
            this.button_ustawieniaglobalne.Size = new System.Drawing.Size(119, 50);
            this.button_ustawieniaglobalne.TabIndex = 9;
            this.button_ustawieniaglobalne.Text = "Ustaweinia globalne";
            this.button_ustawieniaglobalne.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button_ustawieniaglobalne);
            this.Controls.Add(this.button_adminpokoje);
            this.Controls.Add(this.button_ustawienia);
            this.Controls.Add(this.button_polaczonyserwer);
            this.Controls.Add(this.but_listapokoi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button but_listapokoi;
        private System.Windows.Forms.Button button_polaczonyserwer;
        private System.Windows.Forms.Button button_ustawienia;
        private System.Windows.Forms.Button button_adminpokoje;
        private System.Windows.Forms.Button button_ustawieniaglobalne;
    }
}