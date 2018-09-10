using DrawablesUI;
using System.Drawing;

namespace GraphicsEditor.Shapes
{
    public class Point : IShape
    {
        public PointF Coordinates { private get; set; }

        public FormatInfo Format { private get; set; }

        public string Description { get {
                return "Точка(" + Coordinates.X + "," + Coordinates.Y +")";
            }
        }

        public Point(PointF point, FormatInfo formatInfo)
        {
            Format = formatInfo;
            Coordinates = point;
        }

        public void Draw(IDrawer drawer)
        {
            drawer.SelectPen(Format.Color, Format.Width);
            drawer.DrawPoint(Coordinates);
        }
    }
}
