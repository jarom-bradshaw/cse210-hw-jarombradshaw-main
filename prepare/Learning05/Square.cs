public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        this._side = side;
    }

    public override double GetArea() // overide here
    {
        return _side * _side;
    }
}