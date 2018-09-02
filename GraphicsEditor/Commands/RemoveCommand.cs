using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Commands
{
    class RemoveCommand : ICommand
    {
        private Picture Picture;

        public string Name { get { return "remove"; } }

        public string Help { get { return "Удалить фигуру"; } }

        public string Description {
            get {
                return "Параметры команды — индексы элементов, которые нужно удалить с картинки";
            }
        }

        public RemoveCommand(Picture picture)
        {
            Picture = picture;
        }

        public string[] Synonyms {
            get { return new string[] { "delete" }; }
        }

        public void Execute(params string[] parameters)
        {
            foreach (string parameter in parameters)
            {
                Picture.RemoveAt(int.Parse(parameter));
            }
        }
    }
}
