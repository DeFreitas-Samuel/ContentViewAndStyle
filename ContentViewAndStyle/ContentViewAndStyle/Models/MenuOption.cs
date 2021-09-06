using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewAndStyle.Models
{
    class MenuOption
    {
        public MenuOption(string image, string name, string detail)
        {
            Image = image;
            Name = name;
            Detail = detail;
        }

        public string Image { get; }
        public string Name { get; }
        public string Detail { get; }
    }
}
