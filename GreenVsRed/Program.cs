using GreenVsRed.Exceptions;
using System;

namespace GreenVsRed
{
    class Program
    {
        static void Main(string[] args)
        {
         

            //I use the separate class CoordinatesSetter to set width and height
            Console.WriteLine("Enter coordinates: ");
            var setters = new CoordinatesSetter();
            

            int x;
            int y;

            try
            {
                x = setters.SetWidth();
                y = setters.SetHeight();

                if (x >= 1000 || y >= 1000)
                {
                    var ex = new NumberOutOfRangeException("Number shouldn't be equal or more than 1000!");
                    Console.WriteLine(ex);
                    return;
                }

                if (x > y)
                {
                    var ex = new NumberOutOfRangeException("Width shouldn't be more than height!");
                    Console.WriteLine(ex);
                    return;
                }

            }
            catch
            {
                var ex = new InvalidInputException("Invalid input for width or height. You should enter a number!");
                Console.WriteLine(ex.Message);
                return;
            }
      
            //Class for creating a matrix
            var grid = new Grid(x,y);
            var matrix = grid.GenerationZero;

            // I use class GridActions, where are stored the methods for calculating, filling and etc
            var gridActions = new GridActions();
            Console.WriteLine("Fill matrix");
            gridActions.FillMatrix(matrix);


            //I set the coordinates for the selected item and the number of generations
            Console.WriteLine("Enter coordinates for the selected element");
            int x1 = setters.SetWidthForElement();
            int y1 = setters.SetHeightForElement();

            if (x1 < 0 || x1 > x || y1 < 0 || y1 > y)
            {
                var ex = new ItemOutOfGridException("The item is outside of the grid!");
                Console.WriteLine(ex);
                return;

            }
            
            Console.WriteLine("Enter N generations:");
            int n = setters.SetGenerations();

            var result = gridActions.Calculate(x1, y1, n, matrix);

            // In my opinion the answer of the first example should be 6, not 5.
            // I checked all of the conditions, debugged the code many times and drawed every state of the matrix to proof this probability.

            // The condition is that we have to do calculations in Generation Zero and N, so we have 11 generations at all.
            // At Generation Zero the selected item is GREEN (count = 1). 
            // After that we have two states of the matrix, which switch themselfes every iteration (count = 5). So we have 6 times at all.
            Console.WriteLine($"The cell has been green in {result} calculations.");
        }
    }
}
