using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace WpfAppColorViewer.Models
{
    public class ColorSelect
    {
        public ICollection<object> colors;
        public ICollection<Button> buttons;
        public ColorSelect()
        {
               buttons = new List<Button>();
               colors = new List<object>();
        }
    }
}
