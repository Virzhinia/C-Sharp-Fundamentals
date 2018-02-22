using System;
using System.Collections.Generic;
using System.Text;


class Product
{
    private string productName;

    public string ProductName
    {
        get { return this.productName; }
        private set
        {
            if (value == null || value == string.Empty || value == " ")
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.productName = value;
        }
    }

    private decimal cost;

    public decimal Cost
    {
        get { return this.cost; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.cost = value;
        }
    }

    public Product(string name, decimal cost)
    {
        this.productName = name;
        this.Cost = cost;
    }

    public override string ToString()
    {
        return this.productName;
    }
}