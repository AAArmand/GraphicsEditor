using DrawablesUI;
using System.Drawing;

namespace GraphicsEditor.Shapes
{
    public class Ellipse : IShape
    {
        const float startAngle = 0;
        const float endAngle   = 360;

        public PointF Center { private get; set; }

        public SizeF Size { private get; set; }
        
        public float Rotate { private get; set; } = 0;

        public string Description {
            get {
                return "Эллипс(Точка(" + Center.X + "," + Center.Y + "), " +
                    "Малая ось = " + Size.Width + ", Большая ось = " + Size.Height + ", " +
                    "Угол поворота = " + Rotate + ")";
            }
        }

        public Ellipse(PointF center, SizeF size, float rotate)
        {
            Center = center;
            Size = size;
            Rotate = rotate;
        }

        public void Draw(IDrawer drawer)
        {
            drawer.SelectPen(Color.Black, 5);
            drawer.DrawEllipseArc(Center, Size, startAngle, endAngle, Rotate);
        }
    }
}
