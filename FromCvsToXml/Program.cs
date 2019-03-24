using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
//Богатов Максим
//5.	**Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
namespace FromCvsToXml
{
    class Program
    {

        public Program()
        {

        }

        static void SaveAsXmlFormat(List<Student> obj, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            // Создаем файловый поток(проще говоря, создаем файл)
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            // В этот поток записываем сериализованные данные(записываем xml-файл)
            xmlFormat.Serialize(fStream, obj);
            fStream.Close();
        }

        static void Main(string[] args)
        {
            //Создаем список студентов
            List<Student> list = new List<Student>();
            //DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_4.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    //Добавляем в список новый экземляр класса Student
                    Student t;
                    t = new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), Convert.ToInt32(s[6]), int.Parse(s[7]), s[8]);
                    list.Add(t);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            sr.Close();
            SaveAsXmlFormat(list, "data.xml");

            string sj = JsonConvert.SerializeObject(list);
            File.WriteAllText("data.json",sj);
            Console.WriteLine("Готово...");
            Console.ReadKey();

        }
    }
}
