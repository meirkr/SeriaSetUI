namespace SeriaSetUI.Models
{
     //public enum ShapeType
    //{
    //    Rect,
    //    Triangle,
    //    Circle,
    //}
    
    public enum LineStyle
    {
        Regular,
        Dash,
        Dots,
    } 

    public enum Color
    {
        Red,
        Green,
        Blue,
    }
    public interface IShape
    {



        //ShapeType Type { get; set; }
        LineStyle BorderStyle { get; set; }
        Color Color { get; set; }
    }
}