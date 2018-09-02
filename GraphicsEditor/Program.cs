using System;
using System.Text;
using ConsoleUI;
using DrawablesUI;
using GraphicsEditor.Commands;
using System.Windows.Forms;

namespace GraphicsEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var picture = new Picture();
            var ui = new DrawableGUI(picture);
            var app = new ConsoleUI.Application();

            app.AddCommand(new ExitCommand(app));
            app.AddCommand(new ExplainCommand(app));
            app.AddCommand(new HelpCommand(app));
            app.AddCommand(new PointCommand(picture));
            app.AddCommand(new LineCommand(picture));
            app.AddCommand(new SaveCommand(ui.GetForm()));
            app.AddCommand(new LoadCommand(picture));
            app.AddCommand(new RemoveCommand(picture));
            app.AddCommand(new ListCommand(picture));
            app.AddCommand(new EllipseCommand(picture));
            app.AddCommand(new CircleCommand(picture));

            picture.Changed += ui.Refresh;
            ui.Start();
            app.Run(Console.In);
            ui.Stop();
        }
    }
}
