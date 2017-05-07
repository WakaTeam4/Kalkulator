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
    }
}
