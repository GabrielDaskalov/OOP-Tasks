using System;
using System.Collections.Generic;
using System.Text;

namespace GreenVsRed
{
    public interface IGridActions
    {
        void FillMatrix(string[,] matrix);

        int Calculate(int x1, int y1, int n, string[,] matrix);

    }
}
