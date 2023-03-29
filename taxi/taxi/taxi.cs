using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace taxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassenger { get; set; }


        public void TaxiInfo()
        {
            Console.WriteLine("Driver : {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : Yes", OnDuty);
            }
            else
            {
                Console.WriteLine("On Duty : No", OnDuty);
            }

            Console.WriteLine("NumPassangee : {0}", NumPassenger);

        }

        public void PickUpPassanger()
        {
            Console.WriteLine("{0} sedang mengantar penumpang", DriverName);

        }

        public void DropOffPassanger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}

