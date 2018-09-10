using System;
using ConsoleUI;
using GraphicsEditor.Shapes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DrawablesUI;

namespace GraphicsEditor.Commands
{
    public class LineCommand : ICommand
    {
        private Picture Picture;

        public string Name { get { return "line"; } }

        public string Help { get { return "Нарисовать линию"; } }

        public string Description {
            get {
                return "Параметры — координаты точек начала и конца отрезка, четыре числа float";
            }
        }

        public string[] Synonyms {
            get { return new string[] { "segment" }; }
        }

        public LineCommand(Picture picture)
        {
            Picture = picture;
        }

        public void Execute(params string[] parameters)
        {
            if (parameters.Length != 4)
            {
                throw new ArgumentException("Команда ожидает четыре параметра");
            }

            PointF startPoint = new PointF(float.Parse(parameters[0]), float.Parse(parameters[1]));
            PointF endPoint = new PointF(float.Parse(parameters[2]), float.Parse(parameters[3]));
            Picture.Add(new Line(startPoint, endPoint, new FormatInfo(Color.Black, 5)));
        }
    }
}
