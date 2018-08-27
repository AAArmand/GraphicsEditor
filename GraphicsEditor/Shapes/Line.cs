using DrawablesUI;
using System.Drawing;

namespace GraphicsEditor.Shapes
{
    public class Line : IDrawable
    {
        public PointF Start { private get; set; }

        public PointF End { private get; set; }

        public void Draw(IDrawer drawer)
        {
            drawer.SelectPen(Color.Black, 5);
            drawer.DrawLine(Start, End);
        }
    }
}
