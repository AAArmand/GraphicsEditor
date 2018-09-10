using System;
using ConsoleUI;
using System.Text;
using System.Threading.Tasks;
using DrawablesUI;

namespace GraphicsEditor.Commands
{
    class ListCommand : ICommand
    {
        private Picture Picture;

        public string Name { get { return "list"; } }

        public string Help { get { return "Вывести список фигур на картинке"; } }

        public string Description {
            get {
                return "Не принимает параметров";
            }
        }

        public ListCommand(Picture picture)
        {
            Picture = picture;
        }

        public string[] Synonyms {
            get { return new string[] { "table" }; }
        }

        public void Execute(params string[] parameters)
        {
            if (parameters.Length != 0)
            {
                throw new ArgumentException("Команда не принимает параметров");
            }

            int i = 0;
            foreach (IShape shape in Picture.GetShapes())
            {
                Console.WriteLine("[" + i + "] " + shape.Description);
                i++;
            }
        }
    }
}
