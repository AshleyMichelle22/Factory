using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExerciseDessert
{
    
    
        internal interface IDessert
        {

            //properties         //read or write
            public bool CakeBase { get; set; }
            public string Frosting { get; set; }
            public string topping { get; set; }
            public string flavor { get; set; }

            //method what will they all do
            public void DessertKinds();// stubbed out method no implementation bc you implement method in classes:each own method in cake& cupcake
        }
    

}












