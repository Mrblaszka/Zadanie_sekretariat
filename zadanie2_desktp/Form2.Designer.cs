namespace zadanie2_desktp
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Wybor3 = new System.Windows.Forms.TextBox();
            this.Wybor2 = new System.Windows.Forms.ComboBox();
            this.Wybor1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WynikiTextBox = new System.Windows.Forms.TextBox();
            this.SzukajButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Dodaj_button = new System.Windows.Forms.Button();
            this.Klasa_input = new System.Windows.Forms.TextBox();
            this.Nazwisko_input = new System.Windows.Forms.TextBox();
            this.Imie_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Wybor3);
            this.tabPage1.Controls.Add(this.Wybor2);
            this.tabPage1.Controls.Add(this.Wybor1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.WynikiTextBox);
            this.tabPage1.Controls.Add(this.SzukajButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wyszukaj ucznia/uczniow";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Wybor3
            // 
            this.Wybor3.Location = new System.Drawing.Point(469, 87);
            this.Wybor3.Multiline = true;
            this.Wybor3.Name = "Wybor3";
            this.Wybor3.Size = new System.Drawing.Size(131, 21);
            this.Wybor3.TabIndex = 5;
            // 
            // Wybor2
            // 
            this.Wybor2.FormattingEnabled = true;
            this.Wybor2.Items.AddRange(new object[] {
            "rozpoczyna sie od",
            "jest równe",
            "zawiera"});
            this.Wybor2.Location = new System.Drawing.Point(285, 87);
            this.Wybor2.Name = "Wybor2";
            this.Wybor2.Size = new System.Drawing.Size(121, 21);
            this.Wybor2.TabIndex = 4;
            // 
            // Wybor1
            // 
            this.Wybor1.FormattingEnabled = true;
            this.Wybor1.Items.AddRange(new object[] {
            "Imie",
            "Nazwisko",
            "Klasa"});
            this.Wybor1.Location = new System.Drawing.Point(85, 87);
            this.Wybor1.Name = "Wybor1";
            this.Wybor1.Size = new System.Drawing.Size(121, 21);
            this.Wybor1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(80, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Wczytaj kryteria wyszukiwania";
            // 
            // WynikiTextBox
            // 
            this.WynikiTextBox.Location = new System.Drawing.Point(3, 213);
            this.WynikiTextBox.Multiline = true;
            this.WynikiTextBox.Name = "WynikiTextBox";
            this.WynikiTextBox.Size = new System.Drawing.Size(780, 210);
            this.WynikiTextBox.TabIndex = 1;
            // 
            // SzukajButton
            // 
            this.SzukajButton.Location = new System.Drawing.Point(525, 183);
            this.SzukajButton.Name = "SzukajButton";
            this.SzukajButton.Size = new System.Drawing.Size(75, 23);
            this.SzukajButton.TabIndex = 0;
            this.SzukajButton.Text = "Szukaj";
            this.SzukajButton.UseVisualStyleBackColor = true;
            this.SzukajButton.Click += new System.EventHandler(this.SzukajButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Dodaj_button);
            this.tabPage2.Controls.Add(this.Klasa_input);
            this.tabPage2.Controls.Add(this.Nazwisko_input);
            this.tabPage2.Controls.Add(this.Imie_input);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dodaj ucznia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Dodaj_button
            // 
            this.Dodaj_button.Location = new System.Drawing.Point(558, 316);
            this.Dodaj_button.Name = "Dodaj_button";
            this.Dodaj_button.Size = new System.Drawing.Size(120, 23);
            this.Dodaj_button.TabIndex = 6;
            this.Dodaj_button.Text = "Dodaj";
            this.Dodaj_button.UseVisualStyleBackColor = true;
            this.Dodaj_button.Click += new System.EventHandler(this.Dodaj_button_Click);
            // 
            // Klasa_input
            // 
            this.Klasa_input.Location = new System.Drawing.Point(355, 241);
            this.Klasa_input.Multiline = true;
            this.Klasa_input.Name = "Klasa_input";
            this.Klasa_input.Size = new System.Drawing.Size(237, 29);
            this.Klasa_input.TabIndex = 5;
            // 
            // Nazwisko_input
            // 
            this.Nazwisko_input.Location = new System.Drawing.Point(355, 171);
            this.Nazwisko_input.Multiline = true;
            this.Nazwisko_input.Name = "Nazwisko_input";
            this.Nazwisko_input.Size = new System.Drawing.Size(237, 29);
            this.Nazwisko_input.TabIndex = 4;
            // 
            // Imie_input
            // 
            this.Imie_input.Location = new System.Drawing.Point(355, 93);
            this.Imie_input.Multiline = true;
            this.Imie_input.Name = "Imie_input";
            this.Imie_input.Size = new System.Drawing.Size(237, 29);
            this.Imie_input.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(130, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Klasa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(130, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(130, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Sekretariat";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Dodaj_button;
        private System.Windows.Forms.TextBox Klasa_input;
        private System.Windows.Forms.TextBox Nazwisko_input;
        private System.Windows.Forms.TextBox Imie_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WynikiTextBox;
        private System.Windows.Forms.Button SzukajButton;
        private System.Windows.Forms.TextBox Wybor3;
        private System.Windows.Forms.ComboBox Wybor2;
        private System.Windows.Forms.ComboBox Wybor1;
    }
}