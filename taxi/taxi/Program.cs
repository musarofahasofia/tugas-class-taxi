namespace taxi
{
    internal class Program
    {
      
          static void Main(string[] args)
          {
              Taxi taxi = new Taxi();

               taxi.DriverName = "Jono";
               taxi.OnDuty = true;
               taxi.NumPassenger = 10;

               taxi.TaxiInfo();

               Console.WriteLine();

               taxi.PickUpPassanger();
               taxi.DropOffPassanger();

               Console.ReadLine();

          }
    }
    
}

