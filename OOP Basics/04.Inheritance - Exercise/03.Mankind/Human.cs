using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Human
{
    private const int MIN_LENGHT_FIRST_NAME = 4;
    private const int MIN_LENGHT_LAST_NAME = 3;

    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    

    public string LastName
    {
        get { return this.lastName; }
        protected set
        {
            var firstChar = value.First();
            if (!char.IsUpper(firstChar))
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            }
            else if(value?.Length<MIN_LENGHT_LAST_NAME)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }
            this.lastName = value;
        }
    }

    public string FirstName
    {
        get { return this.firstName; }
        protected set
        {
            var firstChar = value.First();
            if (!char.IsUpper(firstChar))
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }
            else if(value?.Length<MIN_LENGHT_FIRST_NAME)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            this.firstName = value;
        }
    }

}
