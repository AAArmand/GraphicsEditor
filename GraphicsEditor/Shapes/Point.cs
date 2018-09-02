using DrawablesUI;
using System.Drawing;

namespace GraphicsEditor.Shapes
{
    public class Point : IShape
    {
        public PointF Coordinates { private get; set; }

        public string Description { get {
                return "Точка(" + Coordinates.X + "," + Coordinates.Y +")";
            }
        }

        public Point(PointF point)
        {
            Coordinates = point;
        }

        public void Draw(IDrawer drawer)
        {
            drawer.SelectPen(Color.Black, 5);
            drawer.DrawPoint(Coordinates);
        }
    }
}
