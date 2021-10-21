using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoDesign
{
    enum Petrol
    {
        Low,
        Medium,
        Full
    }
    class Suv: Car
    {
        private void OffRoadMode()
        {
            Console.WriteLine("Car is now in OffRoad-mode");
                                
        }

        private void EcoMode()
        {
            Console.WriteLine("Car is now in ECO-mode");
        }

        private int PetrolLevel
        {
            get
            {
                return PetrolLevel;
            }

            set
            {
                Console.WriteLine(Petrol.Full);
            }
        }
    }
}
