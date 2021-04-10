using System;
using System.Threading.Tasks;
using Blazor.Extensions.Canvas.Canvas2D;

namespace SeriaSetUI.Draw
{
    public class ElipseDrawing : DrawingBase
    {
        public ElipseDrawing(Canvas2DContext context)
            : base(context)
        {
        }

        protected override async Task DrawPathBased00Async()
        {
            await DrawEllipse(65, 30, 70, 30, 0, 0, Math.PI * 2, true);
        }

        private async Task DrawEllipse(double x, double y, double radiusX, double radiusY,
            float rotation, double startAngle, double endAngle, bool antiClockwise)
        {
            await Context.SaveAsync();
            await Context.TranslateAsync(x, y);
            await Context.RotateAsync(rotation);
            await Context.ScaleAsync(radiusX, radiusY);
            await Context.ArcAsync(0, 0, 1, startAngle, endAngle, antiClockwise);
            await Context.RestoreAsync();
        }
    }
}