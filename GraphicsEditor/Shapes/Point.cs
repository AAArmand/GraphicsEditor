using DrawablesUI;
using System.Drawing;

namespace GraphicsEditor.Shapes
{
    public class Point : IDrawable
    {
        private PointF Coordinates;

        public Point(float x, float y)
        {
            Coordinates = new PointF(x, y);
        }

        public void Draw(IDrawer drawer)
        {
            drawer.SelectPen(Color.Black, 5);
            drawer.DrawPoint(Coordinates);
        }
    }
}
