using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle : IDrawable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    public int Height
    {
        get { return height; }
        private set { height = value; }
    }

    public int Width
    {
        get { return width; }
        private set { width = value; }
    }

    private void DrowLine(int width, char end, char mid)
    {
        Console.Write(end);
        for (int i = 1; i < width-1; ++i)
        {
            Console.Write(mid);
        }
        Console.WriteLine(end);
    }

    public void Draw()
    {
        DrowLine(this.Width, '*', '*');
        for (int i = 1; i < this.Height-1; i++)
        {
            DrowLine(this.Width, '*', ' ');
        }
        DrowLine(this.Width, '*', '*');
    }
}

