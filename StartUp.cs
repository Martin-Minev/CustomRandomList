using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList();
            randomList.Add("Pesho");
            randomList.Add("Dimitrichko");
            randomList.Add("Gogi");
            randomList.Add("Manitu");
            randomList.Add("Gesho");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomList.RandomString());
            }
        }
    }
}
