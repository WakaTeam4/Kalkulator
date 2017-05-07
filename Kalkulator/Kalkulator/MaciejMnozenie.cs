using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class MaciejMnozenie
    {

        public static double Iloczyn(System.Windows.Forms.TextBox TxtBoxA, System.Windows.Forms.TextBox TxtBoxB) {
            double c;
            try
            {
                c = Convert.ToDouble(TxtBoxA.Text) * Convert.ToDouble(TxtBoxB.Text);
            }
            catch(Exception e) {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                c = 0;
            }
            return c;
        }
    }
}
