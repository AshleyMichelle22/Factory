using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExerciseDessert
{
    internal static class DessertFactory // dont need to implement this 
    {

        // add static methods from classes
        //                                  pass in
        public static IDessert GetDessert(int numberOption)
        {
            //for cake class
            if (numberOption == 1)
            {   // instanciate(represent) something key word new
                //creating a new item
                return new Cake();  // cake conforms to IDessert

            }
            else // they dont pick cake will return cupcake
            {
                return new CupCake();

            }
            //factory is ready 

        }




    }
}
