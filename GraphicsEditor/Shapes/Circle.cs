using DrawablesUI;
using System.Drawing;

namespace GraphicsEditor.Shapes
{
    public class Circle : IDrawable
    {
        public PointF Center { private get; set; }

        public SizeF Size { private get; set; }

        public void Draw(IDrawer drawer)
        {
            drawer.SelectPen(Color.Black, 5);
            drawer.DrawEllipseArc(Center, Size);
        }
    }
}
