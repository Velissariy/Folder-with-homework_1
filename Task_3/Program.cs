// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


System.Console.WriteLine("Введите число");
double numberA = Convert.ToInt32(System.Console.ReadLine());
int numberB = Convert.ToInt32(System.Console.ReadLine()); 
double x = Convert.ToInt32(0);
double y = Convert.ToInt32(0);

numberB = numberA;

x = numberA / 2;

y = numberB / 2;
// //y = x;

//  double numberA = numberA;
//     int b = 0;
//   b = (int)numberA;
//   b = numberA / 2;
    
//    y = x - b;

// Console.Write(b);
Console.Write(x);
Console.Write(y);



// using System;
 
// public class Example
// {
//     public static void Main()
//     {
//         bool b = true;
//         int i = Convert.ToInt32(b);
//         Console.WriteLine(i);    // 1
 
//         b = false;
//         i = Convert.ToInt32(b);
//         Console.WriteLine(i);    // 0
//     }
// }






// //int x = Convert.ToInt32(0);

//     {
//         bool b = true;
//         int i = Convert.ToInt32(b);
//         //Console.WriteLine(i);    // 1
 
//         b = false;
//         i = Convert.ToInt32(b);
//         //Console.WriteLine(i);    // 0
//     }

// if (( numberA/2)%0) 
// {
//   System.Console.Write("Да");
// }
// else 
//    System.Console.Write("Нет");



// bool t = true;
// int i = t ? 1 : 0;
// Console.Write(i); // 1

// bool f = false;
// int y = Convert.ToInt32(f);
// Console.WriteLine(y); // 0

// System.Console.Write("Да");

// class Program
// {
//     static void Main()
//     {
// 	// Example bool is true.
// 	bool t = true;

// 	// A.
// 	// Convert bool to int.
// 	int i = t ? 1 : 0;
// 	Console.WriteLine(i); // 1

// 	// Example bool is false.
// 	bool f = false;

// 	// B.
// 	// Convert bool to int.
// 	int y = Convert.ToInt32(f);
// 	Console.WriteLine(y); // 0
//     }
// }

// Output

//1
//0

// using System;
 
// using System.Collections.Generic;
 
// using System.Linq;
 
// using System.Text;
 
 
 
// namespace check1
 
// {
 
//     class Program
 
//     {
 
//         static void Main(string[] args)
 
//         {
 
//             int i;
 
//             Console.Write("Введите число : ");
 
//             i = int.Parse(Console.ReadLine());
 
//             if (i % 2 == 0)
 
//             {
 
//                 Console.Write("Введенное число является четным");
 
//                 Console.Read();
 
//             }
 
//             else
 
//             {
 
//                 Console.Write("Введенное число нечетное");
 
//                 Console.Read();
 
//             }
 
//         }
 
//     }
 
// }