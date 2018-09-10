using ConsoleUI;
using DrawablesUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Commands
{
    class WidthCommand : ICommand
    {
        private Picture Picture;

        public string Name { get { return "width"; } }

        public string Help { get { return "Смена ширины линий фигур"; } }
        
        public string Description {
            get { return "Первый параметр — целое число, ширина линии, второй и следующие параметры индексы фигур"; }
        }

        public string[] Synonyms {
            get { return new string[] { "expand" }; }
        }

        public WidthCommand(Picture picture)
        {
            Picture = picture;
        }

        public void Execute(params string[] parameters)
        {
            uint width = uint.Parse(parameters[0]);
            List<IShape> shapes = Picture.GetShapes();
            foreach (string parameter in parameters.Skip(1))
            {
                shapes.ElementAt(int.Parse(parameter)).Format = new FormatInfo(Color.Black, width);
            }
        }
    }
}
