namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            int value1=class1.MaximumInterger(23, 54, 89);
            Console.WriteLine("Max integer value is : "+ value1);


            class2 class2 = new class2();
            float value2=class2.MaximumFloat(24.4f, 65.3f, 87.2f);
            Console.WriteLine("Max float value is : " + value2);
            
            class3 class3 = new class3();
            String st=class3.MaximumString("ad","adityatggggggggggggggg","waghmare");
            Console.WriteLine("Maximum length of String is: " + st);

        }
    }
}