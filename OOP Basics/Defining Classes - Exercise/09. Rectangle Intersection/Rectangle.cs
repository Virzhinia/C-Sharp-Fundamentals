using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private Point pointTop;



    public Rectangle(string id, double width, double height, Point pointTop)
    {
        this.Id = id;
        this.Width = width;
        this.Height = height;
        this.PointTop = pointTop;
    }

    public bool IsIntersect(Rectangle otherRectangle)
    {
        return otherRectangle.PointTop.X + otherRectangle.Width >= this.PointTop.X &&
               otherRectangle.PointTop.X <= this.PointTop.X + this.Width &&
               otherRectangle.PointTop.Y >= this.PointTop.Y - this.Height &&
               otherRectangle.PointTop.Y - otherRectangle.Height <= this.PointTop.Y;

    }

    public Point PointTop
    {
        get { return pointTop; }
        set { pointTop = value; }
    }
  
    public double Height
    {
        get { return height; }
        set { height = value; }
    }


    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

}

