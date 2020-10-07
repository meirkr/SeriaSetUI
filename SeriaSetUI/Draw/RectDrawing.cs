using System.Threading.Tasks;
using Blazor.Extensions.Canvas.Canvas2D;

namespace SeriaSetUI.Draw
{
    public class RectDrawing : DrawingBase
    {
        public RectDrawing(Canvas2DContext context)
        : base(context)
        {
        }
        protected override async Task DrawPathBased00Async()
        {
            await Context.MoveToAsync(0, 0);
            await Context.LineToAsync(0, 60);
            await Context.LineToAsync(130, 60);
            await Context.LineToAsync(130, 0);
            await Context.LineToAsync(0, 0);
        }
    }
}