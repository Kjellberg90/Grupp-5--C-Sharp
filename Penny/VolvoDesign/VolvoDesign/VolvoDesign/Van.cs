using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoDesign
{
    class Van : Car
    {
        private string Color
        {
            get
            {
                return "White";
            }
        }

        private Van(int horsePower)
        {
            horsePower = 120;
        }

        private bool CanConvert()
        {
            return true;
        }


    }
}
