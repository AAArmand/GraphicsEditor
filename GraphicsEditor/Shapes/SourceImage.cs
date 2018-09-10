using DrawablesUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Shapes
{
    public class SourceImage : IShape
    {
        public PointF Coordinates { private get; set; }

        private Image Image { get; set; }

        public FormatInfo Format { private get; set; }

        public string Description {
            get {
                return "Загруженное изображение";
            }
        }

        public SourceImage(Image image, PointF point, FormatInfo formatInfo)
        {
            Format = formatInfo;
            Image       = image;
            Coordinates = point;
        }

        public void Draw(IDrawer drawer)
        {
            drawer.SelectPen(Format.Color, Format.Width);
            drawer.DrawImage(Image, Coordinates);
        }
    }
}
