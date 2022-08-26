using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExerciseDessert
{
    internal class CupCake : IDessert
    {
        public bool CakeBase { get; set; } = true;
        public string Frosting { get; set; } = "CreamCheese";
        public string topping { get; set; } = "Chocolate Shaving";
        public string flavor { get; set; } = "Devils food";

        public void DessertKinds()
        {  //string interpulation  cake now has implementation details from 1st IDessert/ "method" of each class ;)**
            Console.WriteLine($" CupCake is usually made with {Frosting} sometimes {topping} many different {flavor} can be made to your liking! ");
        }
    }
}
