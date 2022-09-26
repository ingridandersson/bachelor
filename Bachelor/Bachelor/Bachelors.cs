using System;
namespace Bachelor
{
    public class Bachelors : IBachelorAttributes
    {
        public string name { get; set; }
        public int age { get; set; }
        public int looks { get; set; }
        public int charm { get; set; }

        public virtual void Attributes()
        {
            
            /*Console.WriteLine($"Bachelor {name} of age {age}, is a {looks} out of 10, and has charm level {charm}.");*/
        }
    }
    public class Bachelor1 : Bachelors
    {
        
        public Bachelor1()
        {
            Console.WriteLine("Hi, I'm Christoffer!");
        }
        public override void Attributes()
        {
            name = "Christoffer";
            age = 32;
            looks = 7;
            charm = 6;
            Console.WriteLine($"Bachelor {name} of age {age}, rates a {looks} out of 10, and has charm level {charm}.");
        }
   
    }
    public class Bachelor2 : Bachelors
    {
        public Bachelor2()
        {
            Console.WriteLine("Hi, I'm Sia!");
        }
        public override void Attributes()
        {
            name = "Sia";
            age = 36;
            looks = 6;
            charm = 8;
            Console.WriteLine($"Bachelor {name} of age {age}, rates a {looks} out of 10, and has charm level {charm}.");
        }

    }

    public class Bachelorette : IBacheloretteAttributes
    {
        public string name { get; set; }
        public int age { get; set; }
        public int looks { get; set; }
        public int charm { get; set; }
        public static int girlCount = 0;


        public Bachelorette(string girlName, int girlAge, int girlLooks, int girlCharm)
        {
            name = girlName;
            age = girlAge;
            looks = girlLooks;
            charm = girlCharm;
            girlCount++;
        }
       
    }
}

