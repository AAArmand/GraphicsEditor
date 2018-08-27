using System;
using ConsoleUI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }
    }
}
