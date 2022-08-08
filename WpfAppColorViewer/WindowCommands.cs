using System.Windows.Input;
using WpfAppColorViewer;

public class WindowCommands
{
    static WindowCommands()
    {
        AddColor = new RoutedCommand("AddColor", typeof(MainWindow));
    }
    public static RoutedCommand AddColor { get; set; }
}
