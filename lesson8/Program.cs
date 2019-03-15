using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//Богатов Максим
namespace lesson8
{
    class Program
    {
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }

        static void Main(string[] args)
        {
            //1.С помощью рефлексии выведите все свойства структуры DateTime
            DateTime dateTime = new DateTime();

            Type tp = typeof(DateTime);
            Type tp2 = dateTime.GetType();

            // получить перечень свойств
            PropertyInfo[] properties = tp.GetProperties();

            // вывести перечень свойств
            int i = 0;
            foreach (PropertyInfo p in properties)
            {
                i++;
                Console.WriteLine("Property[{0}] = {1}", i, p.Name);
            }

            Console.ReadKey();

        }
    }
}
