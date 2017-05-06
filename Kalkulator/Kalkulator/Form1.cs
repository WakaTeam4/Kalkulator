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
        public double dzielenie()
        {
            int sprawdzCzyLiczba;
            if ((Int32.TryParse(textBoxLiczbaA.Text, out sprawdzCzyLiczba)) && (Int32.TryParse(textBoxLiczbaB.Text, out sprawdzCzyLiczba)))
            {
                if (Convert.ToInt16(textBoxLiczbaA) != 0)
                    return Convert.ToInt32(textBoxLiczbaA) / Convert.ToInt32(textBoxLiczbaB);
            }
            else
                MessageBox.Show("W textboxach muszą być tylko liczby!");
            return 0;
        }
    }
}
