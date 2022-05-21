using System;

namespace SomeCsharpInformations
{
    public delegate void FullNameDelegate(string name, string surname);
    internal class Program
    {
        static void Main(string[] args)
        {
            FullNameDelegate fullNameDelegate1 = new FullNameDelegate(FullNameMethod1);
            FullNameDelegate fullNameDelegate2 = new FullNameDelegate(FullNameMethod2);
            FullNameDelegate fullNameDelegate3 = new FullNameDelegate(FullNameMethod3);

            FullNameDelegate multipleDelegate = fullNameDelegate1 + fullNameDelegate2+ fullNameDelegate3;
            multipleDelegate("Berkan", "Çelik");
            Console.WriteLine(multipleDelegate);
        }

        public static void FullNameMethod1(string name, string surName)
        {
            Console.WriteLine(name + " " + surName);
        }

        public static void FullNameMethod2(string  name, string surName)
        {
            Console.WriteLine(name.ToUpper()+ " " + surName.ToUpper());
        }

        public static void FullNameMethod3(string name, string surName)
        {
            Console.WriteLine(name.ToUpper() + " " + surName.ToUpper());
        }
    }
}

