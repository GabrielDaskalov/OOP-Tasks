using GreenVsRed.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenVsRed
{
    public class GridActions : IGridActions
    {
        public int Calculate(int x1, int y1, int generations, string[,] matrix)
        {
            //Count of the times, when the selected cell was green
            int count = 0;

            //I create two lists, where I store the coordinates of the item, which should be changed
            var listReds = new List<int[]>();
            var listGreens = new List<int[]>();
            int width = matrix.GetLength(0);
            int height = matrix.GetLength(1);

            while (generations >= 0)
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        //I use the methods below (CheckRedElement and CheckGreenElement) to check if the element should be changed
                        if (matrix[i, j] == "0")
                        {
                            if (CheckRedElement(i, j, matrix))
                            {
                                listReds.Add(new int[2] { i, j });
                            }


                        }
                        else if (matrix[i, j] == "1")
                        {
                            if (CheckGreenElement(i, j, matrix))
                            {
                                listGreens.Add(new int[2] { i, j });
                            }

                        }

                    }

                }
                

                if (matrix[x1, y1] == "1")
                {
                    count++;
                }

                if (listReds.Any() || listGreens.Any())
                {
                    UpdateMatrix(listReds, listGreens, matrix);

                }

                generations--;

            }

            return count;
        }

        //I use this method to update the matrix after the generation
        private void UpdateMatrix(List<int[]> listReds, List<int[]> listGreens, string[,] matrix)
        {
            foreach (var item in listReds)
            {
                int i = item[0];
                int j = item[1];

                matrix[i, j] = "1";

            }

            foreach (var item in listGreens)
            {
                int i = item[0];
                int j = item[1];

                matrix[i, j] = "0";
            }

            listReds.Clear();
            listGreens.Clear();


        }

        private bool CheckGreenElement(int i, int j, string[,] matrix)
        {
            int greenCellsCount = 0;
            int width = matrix.GetLength(0);
            int height = matrix.GetLength(1);

            if (j + 1 < width && matrix[i, j + 1] == "1")
            {
                greenCellsCount++;
            }

            if (j + 1 < width && i - 1 >= 0 && matrix[i - 1, j + 1] == "1")
            {
                greenCellsCount++;
            }

            if (i - 1 >= 0 && matrix[i - 1, j] == "1")
            {
                greenCellsCount++;
            }

            if (j - 1 >= 0 && i - 1 >= 0 && matrix[i - 1, j - 1] == "1")
            {
                greenCellsCount++;
            }

            if (j - 1 >= 0 && matrix[i, j - 1] == "1")
            {
                greenCellsCount++;

            }

            if (i + 1 < height && j - 1 >= 0 && matrix[i + 1, j - 1] == "1")
            {
                greenCellsCount++;
            }

            if (i + 1 < height && matrix[i + 1, j] == "1")
            {
                greenCellsCount++;

            }

            if (i + 1 < height && j + 1 < width && matrix[i + 1, j + 1] == "1")
            {
                greenCellsCount++;
            }

            return greenCellsCount != 3 && greenCellsCount != 6 && greenCellsCount != 2;
        }

        private bool CheckRedElement(int i, int j, string[,] matrix)
        {
            int width = matrix.GetLength(0);
            int height = matrix.GetLength(1);

            int greenCellsCount = 0;

            if (j + 1 < width && matrix[i, j + 1] == "1")
            {
                greenCellsCount++;
            }

            if (j + 1 < width && i - 1 >= 0 && matrix[i - 1, j + 1] == "1")
            {
                greenCellsCount++;
            }

            if (i - 1 >= 0 && matrix[i - 1, j] == "1")
            {
                greenCellsCount++;
            }

            if (j - 1 >= 0 && i - 1 >= 0 && matrix[i - 1, j - 1] == "1")
            {
                greenCellsCount++;
            }

            if (j - 1 >= 0 && matrix[i, j - 1] == "1")
            {
                greenCellsCount++;

            }

            if (i + 1 < height && j - 1 >= 0 && matrix[i + 1, j - 1] == "1")
            {
                greenCellsCount++;
            }

            if (i + 1 < height && matrix[i + 1, j] == "1")
            {
                greenCellsCount++;

            }

            if (i + 1 < height && j + 1 < width && matrix[i + 1, j + 1] == "1")
            {
                greenCellsCount++;
            }

            return greenCellsCount == 3 || greenCellsCount == 6;
        }

        //I use this method to fill the matrix with elements
        public void FillMatrix(string[,] matrix)
        {
            int width = matrix.GetLength(0);
            int height = matrix.GetLength(1);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    matrix[i, j] = Console.ReadLine();

                }
            }
        }

    }
}
