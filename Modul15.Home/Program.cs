using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Modul15.Home
{
    internal class Program
    {
        static void PrintConsoleMethods()
        {
            Type consoleType = typeof(Console);
            MethodInfo[] methods = consoleType.GetMethods();

            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }
        static void PrintProperties(Student student)
        {
            Type studentType = student.GetType();
            PropertyInfo[] properties = studentType.GetProperties();

            foreach (var prop in properties)
            {
                Console.WriteLine($"{prop.Name} = {prop.GetValue(student)}");
            }
        }
        static void PrintSubstring(string str, int startIndex, int length)
        {
            MethodInfo substringMethod = typeof(string).GetMethod("Substring", new[] { typeof(int), typeof(int) });
            string result = (string)substringMethod.Invoke(str, new object[] { startIndex, length });

            Console.WriteLine(result);
        }
        static void PrintListConstructors()
        {
            Type listType = typeof(List<>);
            ConstructorInfo[] constructors = listType.GetConstructors();

            foreach (var ctor in constructors)
            {
                Console.WriteLine(ctor.ToString());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            PrintConsoleMethods();
            Console.WriteLine("Задание 2");
            var student = new Student { Name = "Alex", Age = 20 };
            PrintProperties(student);
            Console.WriteLine("Задание 3");
            PrintSubstring("Hello World", 6, 5);
            Console.WriteLine("Задание 4");
            PrintListConstructors();
            Console.ReadKey();
        }
    }
    
}
