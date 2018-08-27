using System;
using ConsoleUI;
using GraphicsEditor.Shapes;

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
            try
            {
                if (parameters.Length != 2)
                {
                    throw new OverflowException("Команда ожидает два параметра");
                }

                float x = float.Parse(parameters[0]);
                float y = float.Parse(parameters[1]);
                Picture.Add(new Point(x, y));
            } catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine(error.StackTrace);
            } 
        }
    }
}
