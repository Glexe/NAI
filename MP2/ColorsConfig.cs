using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP2
{
    public static class ColorsConfig
    {
        public static Color Main { get { return Color.FromArgb(250, 240, 220); } }
        public static Color ButtonDefault { get{return Color.FromArgb(180, 140, 115);} }
        public static Color ButtonPressed { get{return Color.FromArgb(120, 85, 65);} }
        public static Color Fore { get{return Color.FromArgb(30, 30, 45);} }
        public static Color LeftPane { get{return Color.FromArgb(180, 140, 115);} }

        //bttn highlighted = 105, 75, 55
        //dark 65,65,65
    }
}
