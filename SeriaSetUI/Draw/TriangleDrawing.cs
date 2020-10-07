using System.Threading.Tasks;
using Blazor.Extensions.Canvas.Canvas2D;

namespace SeriaSetUI.Draw
{
    public class TriangleDrawing : DrawingBase
    {
        public TriangleDrawing(Canvas2DContext context)
            : base(context)
        {
        }
        protected override async Task DrawPathBased00Async()
        {
            await Context.MoveToAsync(60, 0);
            await Context.LineToAsync(0, 60);
            await Context.LineToAsync(120, 60);
            await Context.LineToAsync(60, 0);
        }
    }
}