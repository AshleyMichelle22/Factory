using FactoryExerciseDessert;

//Bring in class above

Console.WriteLine("What type of Dessert would you like? Select: \n" +  // \m for new line to continue
    " 1 => Cake \n" +
    "2 => CupCake");
// from var to int "parse" can convert back in forth throu variables
var UserInput =int.Parse(Console.ReadLine());

//factory instansiates methods from Factory tab where we sat up methods that included all
// just call the factory for all

//Call method DessertFactory**
IDessert instance = DessertFactory.GetDessert(UserInput);
//var is storing instacne for later- variables are the container**
// above returning an istance ^    
//static class with static method
// instance is returning IDessert a type =var is IDessert




//IDessert interface= properties is instances ** the method used for both Cake and CupCake** ;)
// call method name of each
instance.DessertKinds();

// wording in Command line didnt come out exactly how Id like it. I will go back and change it around. I guess the General cake and cupcake were to broad.
// Should have done ICakes as the  interface and then did types/ flavors of cakes as the classes. 
// Sure hope actually working lets me make fun interfaces like these!! haha




