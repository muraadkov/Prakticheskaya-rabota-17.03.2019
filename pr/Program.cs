using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите от какого числа начинается ваша подстрока: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер подстроки: ");
            int finish = int.Parse(Console.ReadLine());
            char[] name = new char[100];
            Console.WriteLine("Введите имя: ");
            String text = Console.ReadLine();
            name = text.ToCharArray();
            Type type = text.GetType();
            object valid = Activator.CreateInstance(type, new Object[] { name, start, finish });
            Console.WriteLine(valid);
            Console.Read();
        }
    }
}
