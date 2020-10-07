using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Blazor.Extensions.Canvas.Canvas2D;
using SeriaSetUI.Models;

namespace SeriaSetUI.Draw
{

    public abstract class DrawingBase : IDrawing
    {
        public IShape Shape { get; set; }
        protected Canvas2DContext Context { get; }

        protected DrawingBase(Canvas2DContext context)
        {
            Context = context;
        }

        protected abstract Task DrawPathBased00Async();

        public async Task Draw()
        {
            await Context.ScaleAsync(0.5, 0.5);
            
            await Context.SetLineWidthAsync(7);
            await Context.SetLineCapAsync(LineCap.Round);
            //await Context.SetLineJoinAsync(LineJoin.Round);

            await ConfigureColor();
            await ConfigureStyle();

            await Context.BeginPathAsync();
            await Context.TranslateAsync(10, 10);

            // call to derived classes to draw their path
            await DrawPathBased00Async();
            
            // stroke the line according to the path:
            await Context.StrokeAsync();

            // then fill the shape according to the path of derived
            await Context.FillAsync();
        }

        private async Task ConfigureColor()
        {
            string colorStr;
            switch (Shape.Color)
            {
                case Color.Red:
                    colorStr = "Black";
                    break;
                case Color.Green:
                    colorStr = "green";
                    break;
                case Color.Blue:
                    colorStr = "blue";
                    break;
                default:
                    throw new NotSupportedException($"Color: {Shape.Color} is not supported");
            }

            //await this.Context.SetStrokeStyleAsync("black");
            //await this.Context.SetFillStyleAsync(colorStr);
            await this.Context.SetFillStyleAsync("white");
            await this.Context.SetStrokeStyleAsync(colorStr);
        }
        private async Task ConfigureStyle()
        {
            float[] dashes;
            switch (Shape.BorderStyle)
            {
                case LineStyle.Regular:
                    dashes = Array.Empty<float>();
                    break;
                case LineStyle.Dash:
                    dashes = new float[]{ 30, 10 };
                    break;
                case LineStyle.Dots:
                    dashes = new float[]{ 1, 15 };
                    break;
                default:
                    throw new NotSupportedException($"BorderStyle: {Shape.BorderStyle} is not supported");
            }

            await this.Context.SetLineDashAsync(dashes);
        }
    }

    
}