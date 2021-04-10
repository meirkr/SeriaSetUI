using System.Threading.Tasks;
using Blazor.Extensions.Canvas.Canvas2D;
using SeriaSetUI.Models;

namespace SeriaSetUI.Draw
{
    public interface IDrawing
    {
        Shape Shape { get; set; }
        Color Color { get; set; }
        LineStyle LineStyle { get; set; }
        Task Draw();
    }
}