using System;

namespace Exercise_8
{
    class AsciiFigure
    {
        static void Main(string[] args)
        {
            const int figureSize = 5;
            var figuresPerOneRowAdded = 8;
            var howManyFigures = 0;
            var firstFigure = '/';
            var secondFigure = (char)92;
            var starFigure = '*';

            for (int i = 1; i < figureSize; i++)
            {
                howManyFigures += figuresPerOneRowAdded;
            }

            var starCounter = 0;

            for (int i = 0; i < figureSize; i++)
            {
                var secondFigureCount = (starCounter + howManyFigures) / 2;
                var firstFigureCount = (howManyFigures - starCounter) / 2;

                for (int j = 0; j < howManyFigures; j++)
                {
                    if (j < firstFigureCount) Console.Write(firstFigure);
                    else if (j >= secondFigureCount) Console.Write(secondFigure);
                    else Console.Write(starFigure);
                }

                starCounter += figuresPerOneRowAdded;
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
