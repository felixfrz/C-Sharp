﻿namespace TPLConsole
{
    internal class Program
    {
       

            static void Print1()
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print1 Method: {i}");
                }
            }
            static void Print2()
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print2 Method: {i}");
                }
            }
            static void Print3()
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print3 Method: {i}");
                }

            Console.WriteLine(".");
        }
            static void Main(string[] args)
            {
                Print1(); Print2(); Print3();

                Console.ReadLine();
            }

            
       
    }
}
