public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        this._color = color;

    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        this._color = color;
    }

    public abstract double GetArea();
    // {
        // return 0; // This is an abstract function. Is is empty. I 
    // } Changed this after looking at the professors code.
}