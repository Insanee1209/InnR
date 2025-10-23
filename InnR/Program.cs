using System;

namespace TestLab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!");

            
            string name = "John";
            int age = 25;

            // แสดงผล
            Console.WriteLine($"ชื่อ: {name}");
            Console.WriteLine($"อายุ: {age}");

            // เรียกใช้ method
            SayHello("Alice");

            // คำนวณ
            int result = Add(10, 20);
            Console.WriteLine($"ผลบวก: {result}");

            // รอให้กด Enter ก่อนปิด
            Console.ReadLine();
        }

        // Method แยก
        static void SayHello(string name)
        {
            Console.WriteLine($"สวัสดี {name}!");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}