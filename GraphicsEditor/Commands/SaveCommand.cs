using System;
using System.Collections.Generic;
using ConsoleUI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using DrawablesUI;

namespace GraphicsEditor.Commands
{
    class SaveCommand : ICommand
    {
        private Form Form;
        public string Name { get { return "save"; } }
        public string Help { get { return "Сохранить фигуру на диск"; } }

        public string Description {
            get {
                return "Параметр команды — название файла для записи";
            }
        }

        public string[] Synonyms {
            get { return new string[] { "download" }; }
        }

        public SaveCommand(Form form)
        {
            Form = form;
        }

        public void Execute(params string[] parameters)
        {
            if (parameters.Length != 1)
            {
                throw new ArgumentException("Команда принимает 1 параметр");
            }
        //тут код сохранения
           
        }
    }
}
