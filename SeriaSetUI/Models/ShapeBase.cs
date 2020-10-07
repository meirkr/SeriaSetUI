namespace SeriaSetUI.Models
{
    public abstract class ShapeBase : IShape
    {
        #region Implementation of IShape

        public LineStyle BorderStyle { get; set; }
        public Color Color { get; set; }

        #endregion
    }
}