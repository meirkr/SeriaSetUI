using System;
using System.ComponentModel.DataAnnotations;

namespace SeriaSetUI.Models
{
    public class Card
    {
        public Shape Shape { get; set; }
        public Color Color { get; set; }
        public LineStyle LineStyle { get; set; }
        
        [RangeAttribute(1, 3)]
        public uint NumShapes { get; set; }
    }
}