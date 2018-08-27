using System;
using ConsoleUI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }
    }
}
