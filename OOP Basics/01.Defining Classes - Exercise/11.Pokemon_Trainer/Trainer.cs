using System;
using System.Collections.Generic;
using System.Text;

class Trainer
{
    private string name;
    private double badges;
    private List<Pokemon> pokemons;

    public Trainer(string name)
    {
        this.Name = name;
        this.Badges = 0;
        this.Pokemons = new List<Pokemon>();
    }

    public List<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }

    public double Badges
    {
        get { return badges; }
        set { badges = value; }
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}

