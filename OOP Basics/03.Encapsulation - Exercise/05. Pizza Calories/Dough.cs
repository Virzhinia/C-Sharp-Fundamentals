using System;
using System.Collections.Generic;
using System.Text;


public class Dough
{
    private const int MinWeight = 1;
    private const int MaxWeight = 200;
    private const decimal WhiteValue = 1.5m;
    private const decimal WholegrainValue = 1m;
    private const decimal CrispyValue = 0.9m;
    private const decimal ChewyValue = 1.1m;
    private const decimal HomemadeValue = 1m;

    private string flourType;

    public string FlourType
    {
        get { return flourType; }
        private set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value;
        }
    }
    private string technique;

    public string Technique
    {
        get { return technique; }
        private set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            technique = value;
        }
    }

    private decimal weight;

    public decimal Weight
    {
        get { return weight; }
        private set
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            weight = value;
        }
    }
    public Dough()
    {

    }
    public Dough(string flourType, string technique, decimal weight)
    {
        this.FlourType = flourType;
        this.Technique = technique;
        this.Weight = weight;
    }

    public decimal CalculateCalories()
    {
        decimal flourModifier = 0.0m;
        decimal techniqueModifier = 0.0m;

        switch (this.flourType.ToLower())
        {
            case "white": flourModifier = WhiteValue; break;
            case "wholegrain": flourModifier = WholegrainValue; break;
            default:
                throw new ArgumentException("Invalid type of dough.");
        }

        switch (this.technique.ToLower())
        {
            case "crispy": techniqueModifier = CrispyValue; break;
            case "chewy": techniqueModifier = ChewyValue; break;
            case "homemade": techniqueModifier = HomemadeValue; break;
            default:
                throw new ArgumentException("Invalid type of dough.");
        }

        return (2 * this.Weight) * flourModifier * techniqueModifier;
    }
}

