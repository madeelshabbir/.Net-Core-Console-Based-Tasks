using System;

namespace Assignment1
{
    public class MyObject
    {
        static private int count;
        public MyObject()
        {
            count++;
        }
        static public int objectCount()
        {
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyObject obj1 = new MyObject();
            MyObject obj2 = new MyObject();
            MyObject obj3 = new MyObject();
            MyObject obj4 = new MyObject();
            MyObject obj5 = new MyObject();
            Console.WriteLine($"Object Count: {MyObject.objectCount()}");
        }
    }
}