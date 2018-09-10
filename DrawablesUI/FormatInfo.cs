using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawablesUI
{
    public class FormatInfo
    {
        public Color Color { get; set; }
        public uint Width { get; set; }

        public FormatInfo(Color color, uint width)
        {
            Color = color;
            Width = width;
        }
    }
}
