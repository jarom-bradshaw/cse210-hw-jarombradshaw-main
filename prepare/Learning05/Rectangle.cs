public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(string color, double width, double height) : base(color)
    {
        this._width = width;
        this._height = height;
    }

    public override double GetArea() //override here
    {
        return _width * _height;
    }
}
