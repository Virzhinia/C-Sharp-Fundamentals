using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Student : Human
{
    private const int MIN_FACULTY_NUM = 5;
    private const int MAX_FACULTY_NUM = 10;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.FirstName}");
        sb.AppendLine($"Last Name: {this.LastName}");
        sb.AppendLine($"Faculty number: {this.FacultyNumber}");
        return sb.ToString().TrimEnd();
    }

    private string facultyNumber;

    public string FacultyNumber
    {
        get { return facultyNumber; }
         set
        {
            if (value.Length < MIN_FACULTY_NUM || value.Length > MAX_FACULTY_NUM || !value.ToCharArray().All(x => char.IsDigit(x) || char.IsLetter(x)))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            facultyNumber = value;
        }
    }

}

