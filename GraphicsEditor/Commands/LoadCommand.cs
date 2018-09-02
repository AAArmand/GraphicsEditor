using System;
using System.Collections.Generic;
using ConsoleUI;
using System.Linq;
using System.Text;
using GraphicsEditor.Shapes;
using System.Drawing;
using System.IO;

namespace GraphicsEditor.Commands
{
    class LoadCommand : ICommand
    {
        private Picture Picture;

        public string Name { get { return "load"; } }
        public string Help { get { return "Загрузить картинку из файла"; } }

        public string Description {
            get {
                return "Параметр команды — название файла для загрузки";
            }
        }

        public string[] Synonyms {
            get { return new string[] { "output" }; }
        }

        public LoadCommand(Picture picture)
        {
            Picture = picture;
        }

        public void Execute(params string[] parameters)
        {
            if (parameters.Length != 1)
            {
                throw new ArgumentException("Команда принимает 1 параметр");
            }

            if (!File.Exists(@"C:\Projects\JunkFiles\" + parameters[0]))
            {
                throw new ArgumentException("Файл " + parameters[0] + " не существует");
            }

            Image imageFile = Image.FromFile(@"C:\Projects\JunkFiles\" + parameters[0]);
            Picture.Add(new SourceImage(imageFile, new PointF(100, 100)));
            
        }
    }
}
