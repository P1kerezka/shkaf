using System;
class Zadacha
{
    static void Main()
    {

        int[] a = new int[100];
        for (int i = 0; i < 100; i++)
            a[i] = 0;

        for (int b = 1; b <= 100; b++)
        {
            for (int c = b; c < 100; c += b)
            {
                if (a[c] == 0)
                {
                    a[c] = 1;
                }
                else
                {
                    a[c] = 0;
                }
            }
        }
        for (int d = 0; d < 100; d++)
        {
            if (a[d] == 1)
            {
                Console.WriteLine(d);
            }
        }
    }
}