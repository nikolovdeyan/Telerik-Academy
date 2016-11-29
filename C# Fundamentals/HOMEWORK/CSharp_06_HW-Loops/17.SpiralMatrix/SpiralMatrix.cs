using System;

class SpiralMatrix
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        int[,] matrix = new int[inputNum, inputNum];

        FillMatrix(matrix, inputNum);
        ShowResult(matrix, inputNum);
    }


    private static void FillMatrix(int[,] matrix, int n)
    {
        int posX = n / 2;
        int posY = n % 2 == 0 ? (n / 2) - 1 : (n / 2);
        int direction = 0;
        if (n % 2 == 1)
        {
            direction = 2;
        }

        int stepsCount = 1; 
        int stepPosition = 0;
        int stepChange = 0;

        for (int i = n * n; i > 0; i--) 
        {
            matrix[posX, posY] = i;
            if (stepPosition < stepsCount)
            {
                stepPosition++;
            }
            else
            {
                stepPosition = 1;
                if (stepChange == 1)
                {
                    stepsCount++;
                }
                stepChange = (stepChange + 1) % 2;
                direction = (direction + 1) % 4;
            }

            switch (direction)
            {
                case 0:
                    posY++;
                    break;
                case 1:
                    posX--;
                    break;
                case 2:
                    posY--;
                    break;
                case 3:
                    posX++;
                    break;
            }
        }
    }

    private static void ShowResult(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}