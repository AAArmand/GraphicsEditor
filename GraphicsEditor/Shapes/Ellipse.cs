using DrawablesUI;
using System.Drawing;

namespace GraphicsEditor.Shapes
{
    public class Ellipse : IDrawable
    {
        public PointF Center { private get; set; }

        public SizeF Size { private get; set; }

        public float StartAngle { private get; set; } = 0;
        public float EndAngle { private get; set; } = 360;
        public float Rotate { private get; set; } = 0;

        public void Draw(IDrawer drawer)
        {
            drawer.SelectPen(Color.Black, 5);
            drawer.DrawEllipseArc(Center, Size, StartAngle, EndAngle, Rotate);
        }
    }
}
