namespace zadanie2_desktp
{
    partial class Form1
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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Uzytkownik_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Uzytkownik_textbox = new System.Windows.Forms.TextBox();
            this.Haslo_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.verification_picture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kod_z_obrazka_textbox = new System.Windows.Forms.TextBox();
            this.zaloguj_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.verification_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Uzytkownik_label
            // 
            this.Uzytkownik_label.AutoSize = true;
            this.Uzytkownik_label.BackColor = System.Drawing.SystemColors.Control;
            this.Uzytkownik_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Uzytkownik_label.Location = new System.Drawing.Point(160, 73);
            this.Uzytkownik_label.Name = "Uzytkownik_label";
            this.Uzytkownik_label.Size = new System.Drawing.Size(143, 29);
            this.Uzytkownik_label.TabIndex = 0;
            this.Uzytkownik_label.Text = "Uzytkownik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(220, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasło";
            // 
            // Uzytkownik_textbox
            // 
            this.Uzytkownik_textbox.Location = new System.Drawing.Point(309, 73);
            this.Uzytkownik_textbox.Multiline = true;
            this.Uzytkownik_textbox.Name = "Uzytkownik_textbox";
            this.Uzytkownik_textbox.Size = new System.Drawing.Size(221, 29);
            this.Uzytkownik_textbox.TabIndex = 2;
            // 
            // Haslo_textbox
            // 
            this.Haslo_textbox.Location = new System.Drawing.Point(309, 135);
            this.Haslo_textbox.Multiline = true;
            this.Haslo_textbox.Name = "Haslo_textbox";
            this.Haslo_textbox.Size = new System.Drawing.Size(221, 29);
            this.Haslo_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(160, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Weryfikacja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(222, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wpisz tekst z obrazka";
            // 
            // verification_picture
            // 
            this.verification_picture.Location = new System.Drawing.Point(164, 278);
            this.verification_picture.Name = "verification_picture";
            this.verification_picture.Size = new System.Drawing.Size(118, 52);
            this.verification_picture.TabIndex = 6;
            this.verification_picture.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(307, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "losuj nowy";
            this.label4.Click += new System.EventHandler(this.picture_random_gen_label);
            // 
            // kod_z_obrazka_textbox
            // 
            this.kod_z_obrazka_textbox.Location = new System.Drawing.Point(309, 288);
            this.kod_z_obrazka_textbox.Multiline = true;
            this.kod_z_obrazka_textbox.Name = "kod_z_obrazka_textbox";
            this.kod_z_obrazka_textbox.Size = new System.Drawing.Size(221, 29);
            this.kod_z_obrazka_textbox.TabIndex = 8;
            // 
            // zaloguj_button
            // 
            this.zaloguj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaloguj_button.Location = new System.Drawing.Point(506, 363);
            this.zaloguj_button.Name = "zaloguj_button";
            this.zaloguj_button.Size = new System.Drawing.Size(80, 30);
            this.zaloguj_button.TabIndex = 9;
            this.zaloguj_button.Text = "Zaloguj";
            this.zaloguj_button.UseVisualStyleBackColor = true;
            this.zaloguj_button.Click += new System.EventHandler(this.zaloguj_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zaloguj_button);
            this.Controls.Add(this.kod_z_obrazka_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.verification_picture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Haslo_textbox);
            this.Controls.Add(this.Uzytkownik_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uzytkownik_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "Sekretariat";
            ((System.ComponentModel.ISupportInitialize)(this.verification_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Uzytkownik_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Uzytkownik_textbox;
        private System.Windows.Forms.TextBox Haslo_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox verification_picture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kod_z_obrazka_textbox;
        private System.Windows.Forms.Button zaloguj_button;
    }
}

