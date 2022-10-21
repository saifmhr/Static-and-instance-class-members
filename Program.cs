using System;


class circle
{
  static  float _PI;
    int _Radius;


    static circle()
    {
        circle._PI = 3.141F;
    }
    public circle(int Radius)
    {
        _Radius = Radius;
    }

    public float calculateArea()
    {
        return circle._PI * this._Radius * this._Radius;
    }
}
 class Program
    {
        static void Main()
        {
        circle circle = new circle(5);
        float Area= circle.calculateArea();
        Console.WriteLine("Area ={0}", Area);

        circle circle1 = new circle(6);
        float Area1= circle1.calculateArea();
        Console.WriteLine("Area 1 ={0}", Area1);
        }
    }
