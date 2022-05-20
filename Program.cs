using System;
using TestApp_VDcom.CustomCircleDoubleLinkedList;
using TestApp_VDcom.train;

namespace TestApp_VDcom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Размер полученный экспериментально: " + new Train(create()).getTrainSize());
        }

        private static CircleDoubleLinkedList<Wagon> create()
        {
            CircleDoubleLinkedList<Wagon> train = new CircleDoubleLinkedList<Wagon>();
            Random rand = new Random();


            for (int i = 0; i < rand.Next(5, 30); i++)
            {
                train.add(new Wagon(rand.Next(-1, 1) == 0 ? false : true));
            }

            Console.WriteLine("Полученный поезд:\n"+train.ToString());
            return train;
        }


    }
}
