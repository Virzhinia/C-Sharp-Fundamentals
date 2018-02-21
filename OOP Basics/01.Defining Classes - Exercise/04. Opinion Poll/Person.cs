﻿using System;
using System.Collections.Generic;


public class Person
{

    string name;
    int age;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public Person()
    {
        this.name = "No name";
        this.age = 1;
    }
    public Person(int age)
    {
        this.name = "No name";
        this.age = age;
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}