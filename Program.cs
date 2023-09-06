namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericsMax<int> genericsMax = new GenericsMax<int>(40, 20, 53);
            var str = genericsMax.testMaximum();
            Console.WriteLine("max number of string: " + str);
            Console.WriteLine("==========================");


        }
        }
    }