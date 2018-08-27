using System;
using ConsoleUI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            try
            {
                if (parameters.Length != 4)
                {
                    throw new ArgumentException("Команда ожидает четыре параметра");
                }

                float x = float.Parse(parameters[0]);
                float y = float.Parse(parameters[1]);
                Picture.Add(new Point(x, y));
            }
            catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
            }
            catch (OverflowException error)
            {
                Console.WriteLine("Один из параметров слишком большой");
            }
            catch (FormatException error)
            {
                Console.WriteLine("Формат ");
            }
        }
    }
}
