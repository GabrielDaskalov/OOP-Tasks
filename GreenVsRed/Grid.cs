using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenVsRed
{
    public class Grid
    {

        public Grid(int x, int y)
        {
            GenerationZero = new string[x,y];
        }

        public string[,] GenerationZero { get; set; }

        
    }
}
