using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExerciseDessert
{
    internal class Cake : IDessert
    {
        public bool CakeBase { get ; set ; } = true;
        public string Frosting { get; set; } = "Buttercream";
        public string topping { get; set; } = "Sprinkles";
        public string flavor { get; set; } = "Chocolate";

        public void DessertKinds()
        {  //string interpulation  cake now has implementation details from 1st IDessert/ "method" of each class ;)**
            Console.WriteLine($"Cake is usually made with {Frosting} sometimes {topping} many different {flavor} can be made to your liking!");
        }
    }
}
