﻿using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        //main thread
        //foreground thread - thread which is continuely run even main thread alive or not.
        //background thread - thread which exit when main thread exit.
        static void Main(string[] args)                 //main thread start to execute
        {
            Console.WriteLine("Main thread started....");  
            //child thread
            Thread t1 = new Thread(function1);          //fuction1 thread initilzed but not start
            t1.IsBackground = true;
            t1.Start();                                 //t1 will start to execute
            // Thread t2 = new Thread(function2);
            // t2.Start();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
            }
            Thread.Sleep(1000);
            Console.WriteLine("Main thread exited....");           
        }                                               //main thread end to execute
        static void function1()
        {
            Console.WriteLine("function1 thread started....");
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.ReadLine();
            Console.WriteLine("function1 thread exited....");
        }

        static void function2()
        {
            Console.WriteLine("function2 thread started....");
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.ReadLine();
            Console.WriteLine("function2 thread exited....");
        }
    }
}
