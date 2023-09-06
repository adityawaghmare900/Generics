namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            var str=class1.GenericsMax("aditya", "waghmare", "kdjfkd");
            Console.WriteLine("max number of string: "+str); 
            Console.WriteLine("==========================");

           var number= class1.GenericsMax(12, 23, 54);
            Console.WriteLine("max number is: " + number);
            Console.WriteLine("==========================");

           
            var floatnum = class1.GenericsMax(23.3, 45.4, 55.3);
            Console.WriteLine("max number of string: " + str);
            Console.WriteLine("==========================");
        }
    }
}