using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp13
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;
        public Address address;
    }

    public class Address
    {
        public String street, city, province;
    }

    class Program
    {
        static List<Student> students = new List<Student>
        {
           new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}, address= new Address(){street="123 Road rd.",city = "Toronto",province="ON" } },
           new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}, address= new Address(){street="123 Road rd.",city = "Toronto",province="AB" } },
           new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}, address= new Address(){street="123 Road rd.",city = "Toronto",province="MB" } },
           new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}, address= new Address(){street="123 Road rd.",city = "Toronto",province="YK" } },
           new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}, address= new Address(){street="123 Road rd.",city = "Toronto",province="BC" } },
           new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}, address= new Address(){street="123 Road rd.",city = "Toronto",province="SK" } },
           new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}, address= new Address(){street="123 Road rd.",city = "Toronto",province="NU" } },
           new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}, address= new Address(){street="123 Road rd.",city = "Toronto",province="AB" } },
           new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}, address= new Address(){street="123 Road rd.",city = "Toronto",province="NB" } },
           new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}, address= new Address(){street="123 Road rd.",city = "Toronto",province="NS" } },
           new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}, address= new Address(){street="123 Road rd.",city = "Toronto",province="QC" } },
           new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91} , address= new Address(){street="123 Road rd.",city = "Toronto",province="ON" } }
        };
        static void Main(string[] args)
        {
            string json = JsonConvert.SerializeObject(students);
            File.WriteAllText("json.out", json);
            Console.ReadLine();

        }

        public static void StackOverflow()
        {
            StackOverflow();
        }

        public static double HowToMath(int x)
        {
            return (x + 23) / 5.0;
        }
    }
}
