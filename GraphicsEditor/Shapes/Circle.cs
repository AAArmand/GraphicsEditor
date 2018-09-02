using DrawablesUI;
using System.Drawing;

namespace GraphicsEditor.Shapes
{
    public class Circle : IShape
    {
        public PointF Center { private get; set; }

        public SizeF Size { private get; set; }

        public string Description {
            get {
                return "Круг(Точка(" + Center.X + "," + Center.Y + "), Радиус = " + Size.Width + ")";
            }
        }

        public Circle (PointF center, float radius)
        {
            Center = center;
            float diameter = radius * 2;
            Size = new SizeF(diameter, diameter);
        }

        public void Draw(IDrawer drawer)
        {
            drawer.SelectPen(Color.Black, 5);
            drawer.DrawEllipseArc(Center, Size);
        }
    }
}
