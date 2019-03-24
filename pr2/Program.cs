using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Type type = typeof(List<>);
            ConstructorInfo[] constructors = type.GetConstructors();
            Console.WriteLine("Конструкторы List<>: ");
            foreach(var construct in constructors)
            {
                Console.WriteLine(construct.ToString());
            }
            Console.Read();
        }
    }
}
