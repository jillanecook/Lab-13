using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus13actual  //parking spot object that stores a vehicle 
                            //create parkingGarage that takes a list of spot objects
{
    class Spots
    {
        private List<Vehicle> vehicle;


        public Spots(List<Vehicle> vehicle)
        {
            this.vehicle = vehicle;
        }

        public void PrintbyType(string type)
        {
            bool tryRun = false;

            foreach (Vehicle y in vehicle)
            {
                string countCat = y.getType();
                if (countCat == type)
                {
                    Console.WriteLine("There are " + (y.getQuantity()) + " spots in the garage");
                    tryRun = true;
                }
            }
            if (tryRun == false)
            {
                Console.WriteLine("That category isn't in the database");
            }
        }

        public void getGarage(int quantity)
        {
            bool garage = false;

            foreach (Vehicle z in vehicle)
            {
                string count = z.getType();
               

                if (quantity < 20)
                {

                    Console.WriteLine("There are now " + (z.getQuantity() - 1) + "spots remaining");
                    garage = true;

                }
                if (garage == false)
                {
                    Console.WriteLine("Does not compute");
                }

            }

        }
    }
}

        
      

   
            
            

   
         

         


