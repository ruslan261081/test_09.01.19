using System;

namespace HelekB
{
    class Program
    {
        static void Main(string[] args)
        {
            int WinXO = 3;
            int[,] matrix = new int[WinXO, WinXO];


            Random r = new Random();

            int counterOfCards = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j <matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(0, 2);

                    if(matrix[i, j] == 1)
                    {
                        counterOfCards++;
                    }
                    Console.WriteLine(" X ");

                }
                Console.WriteLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(0, 2);

                    if (matrix[i, j] == 1)
                    {
                        counterOfCards++;
                    }
                    Console.WriteLine(" O ");

                }
                Console.WriteLine();

                int trials = 0;

                do
                {
                    Console.WriteLine("Enter row for Card:");
                    int row = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter column for Card:");
                    int column = Convert.ToInt32(Console.ReadLine());

                    if (matrix[row, column] == 1)
                    {
                        Console.WriteLine("You Win!");
                        counterOfCards--;
                        matrix[row, column] = 0;
                    }
                    else
                    {
                        Console.WriteLine("Wrong");
                    }

                    trials++;
                }
                while (counterOfCards > 0);


            }
          


        }
    }
}
