using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppColorViewer.Models;

namespace WpfAppColorViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            select = new ColorSelect();
            CommandBinding commandBinding1 = new CommandBinding();
            commandBinding1.Command = WindowCommands.AddColor;
            commandBinding1.Executed += AddColor_Executed;
            btnAdd.CommandBindings.Add(commandBinding1);
            select.buttons.Add(btn0);
            select.buttons.Add(btn1);
            select.buttons.Add(btn2);
            select.buttons.Add(btn3);
            select.buttons.Add(btn4);
            select.buttons.Add(btn5);
            select.buttons.Add(btn6);
            select.buttons.Add(btn7);

        }
        public ColorSelect select;
        private void AddColor_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            select.colors.Add(rctColor.Background);
            ListColor.Items.Add(rctColor.Background.ToString());
            foreach(var item in select.buttons)
            {/*if(item.Background.)*/
               item.Background= rctColor.Background;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            select.colors.Add(rctColor.Background);
            ListColor.Items.Add(rctColor.Background);
            foreach (var item in select.buttons)
            {
                if (item.Background == DefaultStyleKey)
                    item.Background = rctColor.Background;
                break;
            }
        }
    }
}
