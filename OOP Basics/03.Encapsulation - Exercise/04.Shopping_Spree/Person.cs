using System;
using System.Collections.Generic;
using System.Text;


class Person
{
    private string name;

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (value == null || value == string.Empty || value == " ")
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }

    private decimal money;

    public decimal Money
    {
        get { return this.money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }
    }

    private List<Product> bagOfProducts;

    public List<Product> BagOfProducts
    {
        get { return bagOfProducts; }
        set { bagOfProducts = value; }
    }

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.BagOfProducts = new List<Product>();
    }
}
