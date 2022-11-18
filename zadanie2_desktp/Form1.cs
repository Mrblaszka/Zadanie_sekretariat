using System;
using System.Drawing;
using System.Windows.Forms;

namespace zadanie2_desktp
{

    public partial class Form1 : Form
    {
        public string kod_z_obrazka = "";
        public Image pic1 = Image.FromFile(@"C:\Users\student\Documents\zadanie2_desktp-master\zadanie2_desktp-master\asd\1.png");
        public Image pic2 = Image.FromFile(@"C:\Users\student\Documents\zadanie2_desktp-master\zadanie2_desktp-master\asd\2.png");
        public Image pic3 = Image.FromFile(@"C:\Users\student\Documents\zadanie2_desktp-master\zadanie2_desktp-master\asd\3.png");
        public Image pic4 = Image.FromFile(@"C:\Users\student\Documents\zadanie2_desktp-master\zadanie2_desktp-master\asd\4.png");
        public Image pic5 = Image.FromFile(@"C:\Users\student\Documents\zadanie2_desktp-master\zadanie2_desktp-master\asd\5.png");
        public Image pic6 = Image.FromFile(@"C:\Users\student\Documents\zadanie2_desktp-master\zadanie2_desktp-master\asd\6.png");
        public Form1()
        {
            InitializeComponent();
        }

        public void Picture_generator()
        {
            Random random_number_gen = new Random();
            int random_number = random_number_gen.Next(1, 7);
            switch (random_number)
            {
                case 1:
                    verification_picture.Image = pic1;
                    kod_z_obrazka = "umxyxw";
                    break;
                case 2:
                    verification_picture.Image = pic2;
                    kod_z_obrazka = "b5nmm";
                    break;
                case 3:
                    verification_picture.Image = pic3;
                    kod_z_obrazka = "74853";
                    break;
                case 4:
                    verification_picture.Image = pic4;
                    kod_z_obrazka = "cg5dd";
                    break;
                case 5:
                    verification_picture.Image = pic5;
                    kod_z_obrazka = "x3deb";
                    break;
                case 6:
                    verification_picture.Image = pic6;
                    kod_z_obrazka = "befbd";
                    break;

            }
        }

        private void picture_random_gen_label(object sender, EventArgs e)
        {
            Picture_generator();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Picture_generator();
            Haslo_textbox.PasswordChar = '*';
        }

        private void zaloguj_button_Click(object sender, EventArgs e)
        {
            string popr_uzytkownik = "admin";
            string popr_haslo = "Qwerty1@34";
            string wprow_uzytkownik = Uzytkownik_textbox.Text;
            string wprow_haslo = Haslo_textbox.Text;
            string wprow_kod_z_obrazka = kod_z_obrazka_textbox.Text;

            if (wprow_uzytkownik == "" || wprow_haslo == "" || wprow_kod_z_obrazka == "")
            {
                MessageBox.Show("Sprawdz czy wypełniłeś wszystkie pola", "Error");
            }
            else if(wprow_uzytkownik != popr_uzytkownik)
            {
                MessageBox.Show("Niepoprawne pole \"Uzytkownik\"", "Error");
            }
            else if(wprow_haslo != popr_haslo)
            {
                MessageBox.Show("Niepoprawne pole \"Haslo\"", "Error");
            }
            else if(wprow_kod_z_obrazka != kod_z_obrazka)
            {
                MessageBox.Show("Niepoprawny kod z obrazka", "Error");
            }
            else
            {
                MessageBox.Show("zalogowales sie");
                Form2 f = new Form2();
                f.ShowDialog();
                this.Hide();
            }
        }
    }
}
