using System;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        Console.WriteLine(rand.Next());
        Console.WriteLine(rand.Next(-10, 11));
        Console.WriteLine(rand.NextDouble());


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(rand.Next());
        }


        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rand.Next(-10, 11));
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(rand.NextDouble());
        }


        int[] array1 = new int[8];
        int[] array2 = new int[8];

        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = rand.Next(0, 10);

        }
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = rand.Next(0, 10);

        }
        Console.WriteLine("Index | Array1 | Array2 | Outcome");
        Console.WriteLine("---------------------------------");
        for (int i = 0; i < array1.Length; i++)
        {

            char outcome;
            if (array1[i] > array2[i])
            {
                outcome = 'W';
            }
            else if (array1[i] == array2[i])
            {
                outcome = 'T';
            }
            else
            {
                outcome = 'L';
            }
            Console.WriteLine($"{i,5} | {array1[i],6} | {array2[i],6} | {outcome,7}");



        }
    }
}