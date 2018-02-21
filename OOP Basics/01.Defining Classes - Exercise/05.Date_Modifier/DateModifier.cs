using System;
using System.Collections.Generic;
using System.Text;

class DateModifier
{
    private DateTime firstDate;
    private DateTime secondDate;

    public DateTime FirstDate
    {
        get { return this.firstDate; }
        set { this.firstDate = value; }
    }

    public DateTime SecondDate
    {
        get { return this.secondDate; }
        set { this.secondDate = value; }
    }

public DateModifier(string startDay, string EndDay)
{
    this.firstDate = Convert.ToDateTime(startDay);
    this.secondDate = Convert.ToDateTime(EndDay);
    var totalDays = (this.firstDate - this.secondDate).TotalDays;
}

    public int DaysDeffernce (string startDay, string EndDay)
    {
        this.firstDate = Convert.ToDateTime(startDay);
        this.secondDate = Convert.ToDateTime(EndDay);
        return Math.Abs((this.firstDate - this.secondDate).Days);
    }
}
