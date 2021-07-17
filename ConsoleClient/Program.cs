using System;

namespace MyMessanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message();
            Console.WriteLine("Начало проекта!");
            Console.WriteLine(msg.ToString());
        }
    }
}
