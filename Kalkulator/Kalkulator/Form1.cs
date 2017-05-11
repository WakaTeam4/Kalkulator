using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            switch (comboBoxOperacja.SelectedIndex) {

                case 0://dodawanie

                    break;
                case 1://odejmowanie

                    break;
                case 2://mnożenie
                    labelWynik.Text = "= " + MaciejMnozenie.Iloczyn(textBoxLiczbaA, textBoxLiczbaB).ToString();
                    break;
                case 3://dzielenie

                    break;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public double dzielenie()
        {
            if (czyLiczba())
            {
                int a = Convert.ToInt32(textBoxLiczbaA.Text);
                int b = Convert.ToInt32(textBoxLiczbaB.Text);
                if (b != 0)
                {
                    return a / b;
                }
                else
                {
                    MessageBox.Show("Nie dziel przez zero!");
                    return 0;
                }
            }
            else
                return 0;
        }

        private double dodawanie()
        {
            if (czyLiczba())
            {
                int a = Convert.ToInt32(textBoxLiczbaA.Text);
                int b = Convert.ToInt32(textBoxLiczbaB.Text);
                return a + b;
            }
            else
                return 0;
        }

        private double odejmowanie()
        {
            if (czyLiczba())
            {
                int a = Convert.ToInt32(textBoxLiczbaA.Text);
                int b = Convert.ToInt32(textBoxLiczbaB.Text);
                return a - b;
            }
            else
                return 0;
        }

        private bool czyLiczba()
        {
            int sprawdz;
            if ((Int32.TryParse(textBoxLiczbaA.Text, out sprawdz) && (Int32.TryParse(textBoxLiczbaB.Text, out sprawdz))))
                return true;
            else
            {
                MessageBox.Show("Podaj liczbe!");
                return false;
            }

        }
    }
    }

