﻿//namespace HelloWorld
//{
//  public class Program
//{
//  static void Main(string[] args)
//{
//Console.WriteLine("Hello, World!");
//}
//}
//}

/*namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Chris";
            var isWorking = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }
    }
}*/

namespace Variables
{
    class Program
    {
        enum PlayerState
        {
            Idle,
            Attacking
        }
        static PlayerState playerState;
        static void Main(string[] args)
        {

            switch (playerState)
            {
                case PlayerState.Idle:
                    break;
                case PlayerState.Attacking:
                    break;
            }

            MyClass myClass = new MyClass();

            //Console.WriteLine("Hellow World");

            //int i = 11;

            /*int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            List<int> intList = new List<int>() { 1, 2, 3, 4 };
            *//*intList.Add(5);
            intList.Remove(5);*//*

            int i = 0;
            do
            {
                i++;
            } while (i < 5);*/

            /*while (i < 5)
            {
                i++;
            }*/

            /*for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(i + " " + intList[i]);
            }*/

            /*foreach (int i in intList)
            {
                Console.WriteLine(i);
            }*/

            /*switch (i)
            {
                case 1:
                    Console.WriteLine("First case!");
                    break;
                case 2:
                    Console.WriteLine("Second Case");
                    break;
            }*/

            /*if (i < 10)
            {
                Console.WriteLine("True");
            } else
            {
                Console.WriteLine("False");
            } */
            
            //int i = 56;

            //Console.WriteLine("Hellow World" + i);

            //TestFunction();
            //bool b = SecondFunction(50);
            Console.ReadKey();
            

        }

        class MyClass
        {
            public MyClass()
            {
                //Customer Constructor
            }
        }

        private static void when(bool v)
        {
            throw new NotImplementedException();
        }

        static void TestFunction()
        {

        }
        static bool SecondFunction(int i)
        {
            return i < 100;
        }
    }
}
