using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoDesign
{
    class Car
    {
        public Car()
        {

        }
        public int Wheels
        {
            get
            {
                return 4;
            }

        }

        protected void StartCar()
        {
            Console.WriteLine("Car is now started");
        }

        protected void DriveCarFast()
        {
            Console.WriteLine("Broom Broom!!");
        }

        public bool DriveToFast()
        {
            return true;
        }

        protected string VinNumber { get; set; }

        protected Car(int yearModel)
        {
            yearModel = 2022;
        }
    }
}
