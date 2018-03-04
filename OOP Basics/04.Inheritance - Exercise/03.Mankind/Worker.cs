using System;
using System.Collections.Generic;
using System.Text;


public class Worker : Human
{
    private const double MIN_WEEK_SALARY = 10;
    private const double MIN_WEEK_HOURS = 1;
    private const double MAX_WEEK_HOURS = 12;

    public Worker(string firstName, string lastName, double weekSalary, double WorkHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = WorkHoursPerDay;
    }

    public double SalaryPerHour => this.WeekSalary / (this.WorkHoursPerDay * 5);

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.FirstName}");
        sb.AppendLine($"Last Name: {this.LastName}");
        sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
        sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");
        sb.AppendLine($"Salary per hour: {SalaryPerHour:f2}");
        return sb.ToString().TrimEnd();
    }

    private double weekSalary;
    private double workHoursPerDay;

    public double WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set
        {
            if (value < MIN_WEEK_HOURS || value > MAX_WEEK_HOURS)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workHoursPerDay = value;
        }
    }

    public double WeekSalary
    {
        get { return this.weekSalary; }
        private set
        {
            if (value < MIN_WEEK_SALARY)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }

}
