using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.ObjectModel;

namespace MauiApp2
{
    public class Robot
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }
        public string RobotType { get; internal set; }
    }
}