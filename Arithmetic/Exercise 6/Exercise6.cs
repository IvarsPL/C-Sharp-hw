using System;

namespace Exercise_6
{
    public class Exercise6
    {
        public static string CozaWozaLoza(int i)
        {
            if (i % 11 == 0)
            {
                if (i % 7 == 0) return "Woza\n";
                if (i % 5 == 0) return "Loza\n";
                if (i % 3 == 0) return "Coza\n";
                return i.ToString() + "\n";
            }
            if (i % 15 == 0) return "CozaLoza ";
            if (i % 7 == 0) return "Woza ";
            if (i % 5 == 0) return "Loza ";
            if (i % 3 == 0) return "Coza ";
            return i.ToString() + " ";

        }
        static void Main()
        {
            for (int i = 1; i <= 110; i++)
            {
                Console.Write(CozaWozaLoza(i));
            }

            Console.ReadKey();
        }
    }
}
