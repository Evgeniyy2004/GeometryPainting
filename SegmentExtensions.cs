using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryTasks;

namespace GeometryPainting
{
    //Напишите здесь код, который заставит работать методы segment.GetColor и segment.SetColor
    static class Extension
    {
        public static void SetColor(this Segment seg, Color color)
        {
            if (color == null) return;
            if (!Colors.ContainsKey(seg)) Colors.Add(seg, color);
            else Colors[seg] = color;
        }

        public static Color GetColor(this Segment seg)
        {
            if (Colors.ContainsKey(seg))
            {
                var c = Colors[seg];
                if (c == Color.Empty || c == null) return Color.Black;
                return c;
            }
            else return Color.Black;
        }

        public static Dictionary<Segment, Color> Colors = new Dictionary<Segment, Color>();
    }
}