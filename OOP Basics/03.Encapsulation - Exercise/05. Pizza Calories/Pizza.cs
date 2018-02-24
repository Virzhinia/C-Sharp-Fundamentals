using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Pizza
{
    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 1 || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            name = value;
        }
    }

    private int countToppings;

    public int CountToppings
    {
        get { return this.countToppings; }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..10].");
            }
            this.countToppings = value;
        }
    }


    private List<Topping> toppingsList;

    public List<Topping> ToppingsList
    {
        get { return toppingsList; }
        set { toppingsList = value; }
    }

    private Dough dough;

    public Dough Dough
    {
        get { return dough; }
        set { dough = value; }
    }
    public Pizza()
    {
        this.ToppingsList = new List<Topping>();
    }

    public Pizza(string name) : this()
    {
        this.Name = name;
    }

    public decimal CalculatePizzaCalories()
    {
        decimal allCalories = this.Dough.CalculateCalories() + this.ToppingsList.Sum(t => t.CalculateToppingCalories());
        return allCalories;
    }

    public override string ToString()
    {
        return $"{this.name} - {CalculatePizzaCalories():f2} Calories.";
    }
}

