using System;
using System.Drawing;
using ConsoleUI;
using GraphicsEditor.Shapes;
using DrawablesUI;

namespace GraphicsEditor.Commands
{
    public class PointCommand : ICommand
    {
        private Picture Picture;

        public string Name { get { return "point"; } }

        public string Help { get { return "Нарисовать точку"; } }

        public string Description {
            get {
                return "Параметры — координаты точки, два числа float";
            }
        }

        public string[] Synonyms {
            get { return new string[] { "dot" }; }
        }

        public PointCommand(Picture picture)
        {
            Picture = picture;
        }

        public void Execute(params string[] parameters)
        {

            if (parameters.Length != 2)
            {
                throw new FormatException("Команда ожидает два параметра");
            }

            PointF point = new PointF(float.Parse(parameters[0]), float.Parse(parameters[1]));
            Picture.Add(new Shapes.Point(point, new FormatInfo(Color.Black, 5)));
            
        }
    }
}
