using System;
using System.Collections.Generic;
using System.Text;


class Cargo
{
    private int cargoWeight;
    private string cargoType;

    public Cargo(int cargoWeight, string cargoType)
    {
        this.CargoType = cargoType;
        this.CargoType = cargoType;
    }

    public string CargoType
    {
        get { return cargoType; }
        set { cargoType = value; }
    }


    public int CargoWeight
    {
        get { return cargoWeight; }
        set { cargoWeight = value; }
    }

}

