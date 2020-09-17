using System;
using System.Collections.Generic;
using System.Text;

namespace GreenVsRed
{
    public interface ICoordinatesSettingActions
    {
        public int SetWidth();

        public int SetHeight();

        public int SetWidthForElement();

        public int SetHeightForElement();

        public int SetGenerations();

    }
}
