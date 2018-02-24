using System;
using System.Collections.Generic;
using System.Linq;

public class Topping
{
    private readonly string[] ToppingTypes = { "meat", "veggies", "cheese", "sauce" };
    private const decimal MeatValue = 1.2m;
    private const decimal VeggiesValue = 0.8m;
    private const decimal CheeseValue = 1.1m;
    private const decimal SauceValue = 0.9m;
    private const decimal MinWeight = 1;
    private const decimal MaxWeight = 50;

    private decimal weight;

    public decimal Weight
    {
        get { return weight; }
        private set
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException($"{this.typeOfTopping} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }

    private string typeOfTopping;

    public string TypeOfTopping
    {
        get { return typeOfTopping; }
        private set
        {
            if (!ToppingTypes.Contains(value.ToLower()) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            typeOfTopping = value;
        }
    }

    public Topping()
    {

    }

    public Topping(string typeOftopping, decimal weight)
    {
        this.TypeOfTopping = typeOftopping;
        this.Weight = weight;
    }

    public decimal CalculateToppingCalories()
    {
        decimal toppingModifier = 0.0m;

        switch (this.typeOfTopping.ToLower())
        {
            case "meat": toppingModifier = MeatValue; break;
            case "veggies": toppingModifier = VeggiesValue; break;
            case "cheese": toppingModifier = CheeseValue; break;
            case "sauce": toppingModifier = SauceValue; break;
        }
        return this.Weight * 2 * toppingModifier;
    }
}
