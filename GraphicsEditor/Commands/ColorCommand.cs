using System;
using ConsoleUI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawablesUI;
using System.Drawing;

namespace GraphicsEditor.Commands
{
    class ColorCommand : ICommand
    {
        private Picture Picture;

        public string Name { get { return "color"; } }

        public string Help { get { return "Смена цвета линий фигур"; } }

        public string Description {
            get { return "Первый параметр — название цвета, второй и следующие параметры индексы фигур"; }
        }

        public string[] Synonyms {
            get { return new string[] { "colour" }; }
        }

        public ColorCommand(Picture picture)
        {
            Picture = picture;
        }

        public void Execute(params string[] parameters)
        {
            Color color = ColorTranslator.FromHtml(parameters[0]);
            List<IShape> shapes = Picture.GetShapes();
            foreach (string parameter in parameters.Skip(1))
            {
                shapes.ElementAt(int.Parse(parameter)).Format = new FormatInfo(color, 5);
            }
        }
    }
}
