using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus13actual
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
                if (countCat ==type )
                {
                    Console.WriteLine("There are "+ (y.getQuantity()) + " spots are left");
                    tryRun = true;
                }
            }
            if (tryRun == false)
            {
                Console.WriteLine("That category isn't in the database");
            }
            
            }
                        // (2) large spots (10 compact spots)
                      // (20) single compact spots 
                    //   (7) motorcycle spots 
        }
    }


