using System;

namespace Z_2
{
    public class A 
    {
        public float a; 
        public float b;
        public A() { a = 3f; b = 2.5f; } 
        public float c 
        {
            get { return a / b; }
            set { c = value; } 
        }
    }
    public class B : A
    {
        public float d = 10f; 
        public int i;
        public float c2 
        {
            get { return a + b + d; }
            set { c2 = value; }
        }
        class Program
        {
            static void Main(string[] args)
            {
                A a = new A();
                B b = new B();
                Console.WriteLine("Введите число и увидите значения:");
                Console.WriteLine("1 - полей a,b,d");
                Console.WriteLine("2 - свойств с,c2");
                b.i = Convert.ToInt32(Console.ReadLine());
                switch (b.i)
                {
                    case 1: Console.WriteLine("a={0} ", b.a, "b={0} ", b.b, "d={0} ", b.d); break;
                    case 2: Console.WriteLine("2={0} ", b.c, "c2={0} ", b.c2); break;
                    default:
                        Console.WriteLine("Введено неправильное значение!"); break;
                }
            }
        }
    }
}
