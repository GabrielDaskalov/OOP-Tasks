using System;
using System.Collections.Generic;
using System.Text;

namespace GreenVsRed
{
    public class CoordinatesSetter: ICoordinatesSettingActions
    {

        public int SetWidth()
        {
            return int.Parse(Console.ReadLine());

        }

        public int SetHeight()
        {
            return int.Parse(Console.ReadLine());
        
        }

        public int SetWidthForElement()
        {

            return int.Parse(Console.ReadLine());
        
        }

        public int SetHeightForElement()
        {
            return int.Parse(Console.ReadLine());
        }

        public int SetGenerations()
        {
            return int.Parse(Console.ReadLine());
        
        }

    }
}
