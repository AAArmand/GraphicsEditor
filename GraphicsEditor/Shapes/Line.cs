using DrawablesUI;
using System.Drawing;

namespace GraphicsEditor.Shapes
{
    public class Line : IShape
    {
        public PointF Start { private get; set; }

        public PointF End { private get; set; }

        public string Description {
            get {
                return "Линия(Точка(" + Start.X + "," + Start.Y + "), Точка(" + End.X + "," + End.Y + "))";
            }
        }

        public Line (PointF startPoint, PointF endPoint)
        {
            Start = startPoint;
            End = endPoint;
        }

        public void Draw(IDrawer drawer)
        {
            drawer.SelectPen(Color.Black, 5);
            drawer.DrawLine(Start, End);
        }
    }
}
