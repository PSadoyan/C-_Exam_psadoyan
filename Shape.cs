using System;

/*
Problem #3 Creates a class "Shapes" and several subclass shapes (as per instructions) with their respective areas coded in. I added in dummy values for "Length" and "Width" in the Shape master-class, which prevented some comiling issues (thank you replit AI co-pilot).

Used Links:
https://www.w3schools.com/cs/cs_inheritance.php
(Not technically a link, but the Replit Co-Pilot was very helpful in solving inheritence issues).
*/

class Shape
{
  int Length = 1;
  int Width = 1;
  public virtual double Area()
  {
    return (Length * Width);
  }

  
  
}

class Rectangle(int Length, int Width) : Shape
{
  public override double Area()
  {
    return (Length * Width);
  }
}

class Triangle(int Height, int Width) : Shape
{
  public override double Area()
  {
    return (Height/2 * Width);
  }
}

class Circle(int radius) : Shape
{
  public override double Area()
  {
    return ((radius * radius) * 3.14);
  }
}