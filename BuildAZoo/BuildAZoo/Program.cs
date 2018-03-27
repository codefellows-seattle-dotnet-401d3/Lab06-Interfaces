using System;

namespace BuildAZoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Classes.Lion leon = new Classes.Lion();
            Classes.Water oasis = new Classes.Water();
            Classes.Duck donald = new Classes.Duck();
            Classes.Sky sky = new Classes.Sky();
            sky.Flying(donald);
            oasis.Swim(leon);
            Console.ReadLine();
        }
    }
}
