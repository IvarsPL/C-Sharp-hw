using System;

namespace Exercise_8
{
    class AsciiFigure
    {
        static void Main(string[] args)
        {
            var slashCounter = 32;
            var starCounter = 0;
            var changeSize = 8;
            const int figureSize = 3;


            for (int i = 0; i < 5; i++)
            {
                if (starCounter == 0) // 1 iteracija
                {
                    for (int j = 0; j < slashCounter; j++) 
                    {
                        if (j <= 15) Console.Write('/');
                        else Console.Write((char) 92);
                    }
                }
                else if (starCounter == 8) // 2 iteracija
                {
                    for (int j = 0; j < slashCounter + starCounter; j++)
                    {
                        if (j < slashCounter / 2) Console.Write('/');
                        else if (j >= starCounter + (slashCounter/2)) Console.Write((char)92);
                        else Console.Write("*");
                    }
                }
                else if (starCounter == 16) // 3 iteracija
                {
                    for (int j = 0; j < slashCounter + starCounter; j++)
                    {
                        if (j < slashCounter / 2) Console.Write('/');
                        else if (j >= starCounter + (slashCounter / 2)) Console.Write((char)92);
                        else Console.Write("*");
                    }
                }
                else if (starCounter == 24) //4 iteracija
                {
                    for (int j = 0; j < slashCounter + starCounter; j++)
                    {
                        if (j < slashCounter / 2) Console.Write('/');
                        else if (j >= starCounter + (slashCounter / 2)) Console.Write((char)92);
                        else Console.Write("*");
                    }
                }

                else
                {
                    for (int j = 0; j < starCounter; j++)
                    {
                        Console.Write("*");
                    }
                }

                starCounter += changeSize;
                slashCounter -= changeSize;
                Console.WriteLine();
            }
            

            Console.ReadKey();
        }
    }
}
