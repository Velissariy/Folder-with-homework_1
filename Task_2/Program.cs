// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int numberC = Convert.ToInt32(System.Console.ReadLine());

int result = Convert.ToInt32(0); 

if ( numberA > numberB)
  result = numberA;

     if ( numberC > numberA)
       result = numberC;

          if ( numberB > numberC)
            result = numberB;

Console.Write("max = "); 
Console.WriteLine(result);



 


