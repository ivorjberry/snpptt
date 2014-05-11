using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace snpptt.Models
{
    public class Snip
    {
        public string URL { get; set; }
        public int WindowWidth { get; set; }
        public int WindowHeight {get; set;}
        public int ScrollPosition {get; set; }
        public Rectangle Snapshot {get; set;}
    }
}