using System.Text;
using NStack;
using Terminal.Gui;

namespace LearningTheConsoleUi.WindowManagement;

public static class Logo
{
    public static Label Get()
    {
        Label logo = new Label()
        {
            ColorScheme = Colors.TopLevel,
            X =  10,
            Y = 10,
            AutoSize = true
        };
        
        var block = new StringBuilder();

        block.AppendLine("░██████╗░██╗░░░██╗██╗░█████╗░██╗░░██╗░██████╗████████╗░█████╗░██████╗░ ");
        block.AppendLine("██╔═══██╗██║░░░██║██║██╔══██╗██║░██╔╝██╔════╝╚══██╔══╝██╔══██╗██╔══██╗ ");
        block.AppendLine("██║██╗██║██║░░░██║██║██║░░╚═╝█████═╝░╚█████╗░░░░██║░░░███████║██████╔╝ ");
        block.AppendLine("╚██████╔╝██║░░░██║██║██║░░██╗██╔═██╗░░╚═══██╗░░░██║░░░██╔══██║██╔══██╗ ");
        block.AppendLine("░╚═██╔═╝░╚██████╔╝██║╚█████╔╝██║░╚██╗██████╔╝░░░██║░░░██║░░██║██║░░██║ ");
        block.AppendLine("░░░╚═╝░░░░╚═════╝░╚═╝░╚════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝ ");
        block.AppendLine("    █▄▄ █▄█   █▀▄▀█ █▀█ █▄░█ █ █▀▀ █▀   █▀ █▄█ █▀ ▀█▀ █▀▀ █▀▄▀█ █▀ ");
        block.AppendLine("    █▄█ ░█░   █░▀░█ █▄█ █░▀█ █ █▄▄ ▄█   ▄█ ░█░ ▄█ ░█░ ██▄ █░▀░█ ▄█ ");
        logo.Text = ustring.Make(block.ToString());

        return logo;
    }
}