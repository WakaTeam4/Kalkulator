﻿using System;
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
            //test
          
        }

        private double odejmowanie()
        {
            if (Czy_liczba())
            {
                int a = Convert.ToInt32(textBoxLiczbaA.Text);
                int b = Convert.ToInt32(textBoxLiczbaB.Text);
                return a - b;
            }
            else
                return 0;  
        }
      
        private bool Czy_liczba()
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
