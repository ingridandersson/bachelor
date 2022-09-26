using Bachelor;
using System.Collections.Generic;

internal class Program
{
    public static void Main()
    {
        int num;
        int i = 1;
        
        List<Bachelorette> myBachelorettes = new List<Bachelorette>();

        Bachelor1 b1 = new Bachelor1();
        b1.Attributes();

        Thread.Sleep(1500);
        Console.WriteLine();

        Bachelor2 b2 = new Bachelor2();
        b2.Attributes();

        Console.WriteLine();

        Console.Write("---<---<@");
        Thread.Sleep(1500);

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine($"How many bachelorettes do you want {b1.name} & {b2.name} to date?");
        
        num = Convert.ToInt32(Console.ReadLine());
        
       
        Console.WriteLine();

        while (num >= i)
        {
            try
            {
                Console.WriteLine("Enter name: ");
                string girlName = Console.ReadLine();
                Console.WriteLine("Enter age: ");
                int girlAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter looks on a scale of 1-10: ");
                int girlLooks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter level of charm: ");
                int girlCharm = Convert.ToInt32(Console.ReadLine());

                Bachelorette singleGirl = new Bachelorette(girlName, girlAge, girlLooks, girlCharm);

                myBachelorettes.Add(singleGirl);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (var girl in myBachelorettes)
            {
                /*Console.WriteLine("Bachelorette: " + girl.name);
                Console.WriteLine("Age: " + girl.age);
                Console.WriteLine("Looks on a scale of 1-10: " + girl.looks);
                Console.WriteLine("Charm level :" + girl.charm);*/
                Console.WriteLine();
                Console.WriteLine($"{girl.name} says hi!");
                Console.WriteLine("---<---<@");
                Console.WriteLine("_________________________________________");
                Console.WriteLine();
            }
            i++;
        }
        Console.WriteLine($"How many girls are dating {b1.name} & {b2.name}?");
        Thread.Sleep(700);
        Console.WriteLine(Bachelorette.girlCount + " girls are competing for love.");

        Console.WriteLine();

        string aMessage = "...And the contestents are...:";
        for (int e = 0; e < aMessage.Length; e++)
        {
            Console.Write(aMessage[e]);
            if (aMessage[e] == ':')
            {
                Thread.Sleep(1000);
            }
            else
            {
                Thread.Sleep(100);
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        foreach (var girl in myBachelorettes)
        {
            Console.WriteLine("Name: " + girl.name + ", Age: " + girl.age);
            Console.WriteLine("Looks on a scale of 1-10: " + girl.looks);
            Console.WriteLine("Charm level: " + girl.charm);
            Console.WriteLine("--<@--<--<@--<--<@--<--<@--<--<@--<--<@--<--<@");
        }

    
        Console.ReadKey();
    }
}