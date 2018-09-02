using System;
using ConsoleUI;
using GraphicsEditor.Shapes;
using System.Drawing;

namespace GraphicsEditor.Commands
{
    public class CircleCommand : ICommand
    {
        private Picture Picture;

        public string Name { get { return "circle"; } }

        public string Help { get { return "Нарисовать круг"; } }

        public string Description {
            get {
                return "Параметры — координаты центра круга и радиус, три числа float";
            }
        }

        public string[] Synonyms {
            get { return new string[] { "range", "round", "lap" }; }
        }

        public CircleCommand(Picture picture)
        {
            Picture = picture;
        }

        public void Execute(params string[] parameters)
        {
            if (parameters.Length != 3)
            {
                throw new ArgumentException("Команда ожидает три параметра");
            }

            PointF centerPoint = new PointF(float.Parse(parameters[0]), float.Parse(parameters[1]));
            float radius       = float.Parse(parameters[2]);

            Picture.Add(new Circle(centerPoint, radius));
        }
    }
}
