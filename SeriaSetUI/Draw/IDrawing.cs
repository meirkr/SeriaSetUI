using System.Threading.Tasks;
using Blazor.Extensions.Canvas.Canvas2D;
using SeriaSetUI.Models;

namespace SeriaSetUI.Draw
{
    public interface IDrawing
    {
        IShape Shape { get; set; }
        Task Draw();
    }
}