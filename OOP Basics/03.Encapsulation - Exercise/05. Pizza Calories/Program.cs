using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string inputInfo = string.Empty;
        int countOfToppings = 0;
        var pizza = new Pizza();

        try
        {
            while ((inputInfo = Console.ReadLine()) != "END")
            {
                var splitInfo = inputInfo.Split();
                switch (splitInfo[0])
                {
                    case "Pizza":
                        pizza= new Pizza(splitInfo[1]);
                        break;
                    case "Dough":
                        Dough dough = new Dough(splitInfo[1], splitInfo[2], decimal.Parse(splitInfo[3]));
                        pizza.Dough = dough;
                        break;
                    case "Topping":
                        var topping = new Topping(splitInfo[1], decimal.Parse(splitInfo[2]));
                        pizza.ToppingsList.Add(topping);
                        countOfToppings++;
                        pizza.CountToppings = countOfToppings;
                        break;
                }
            }
            Console.WriteLine(pizza);
        }
        catch (ArgumentException argEx)
        {

            Console.WriteLine(argEx.Message);
        }
    }

}


