using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoDesign
{
    class Sedan : Car
    {
        private int SerialNumber
        {
            get
            {
                return 1_5_4_6_7_8;
            }
        }

        private Sedan(string regLetters, int regNumbers)
        {
            regLetters = "KBC";
            regNumbers = 758;
        }

        private string Color
        {
            get
            {
                return "Metallic silver";
            }
        }
    }
}
