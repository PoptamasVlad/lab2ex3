using System;

namespace lab2ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Să se scrie un program care citeşte de la tastatură un şir de n numere
            naturale şi determină media aritmetică a celor pare, n fiind citit de la
            tastatra */

            int n = int.Parse(Console.ReadLine());
            int medie = 0;
            int x = 0, j;
            for(int i=1; i<=n; i++)
            {
                j = int.Parse(Console.ReadLine());
                if(j % 2 == 0)
                {
                    x++;
                    medie = medie + j;
                }
            }
            if(x == 0)
            {
                x++;
            }
            medie = medie / x;
            Console.WriteLine(medie);
        }
    }
}
