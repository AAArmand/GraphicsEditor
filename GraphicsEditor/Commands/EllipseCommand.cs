using System;
using ConsoleUI;
using GraphicsEditor.Shapes;
using System.Drawing;
using DrawablesUI;

namespace GraphicsEditor.Commands
{
    public class EllipseCommand : ICommand
    {
        private Picture Picture;

        public string Name { get { return "ellipse"; } }

        public string Help { get { return "Нарисовать эллипс"; } }

        public string Description {
            get {
                return "Параметры — координаты точки центра эллипса, размеры осей эллипса, угол поворота эллипса, пять чисел float";
            }
        }

        public string[] Synonyms {
            get { return new string[] { "oval" }; }
        }

        public EllipseCommand(Picture picture)
        {
            Picture = picture;
        }

        public void Execute(params string[] parameters)
        {
            if (parameters.Length != 5)
            {
                throw new ArgumentException("Команда ожидает пять параметров");
            }

            PointF centerPoint = new PointF(float.Parse(parameters[0]), float.Parse(parameters[1]));
            SizeF size = new SizeF(float.Parse(parameters[2]), float.Parse(parameters[3]));
            float angle     = float.Parse(parameters[4]);

            Picture.Add(new Ellipse(centerPoint, size, angle, new FormatInfo(Color.Black, 5)));
        }
    }
}
