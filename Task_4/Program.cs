// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число");
string example = Console.ReadLine();
int  numberA = Convert.ToInt32(example);

if (numberA < 0)
{
    for (int numberB = numberA; numberB <= Math.Abs(numberA); numberB++)
      {  if( numberB % 2 == 0 && numberB != 0)
            {
              Console.WriteLine( String.Empty, numberA, " -> ");
              Console.Write(numberB + " ");
            }
      }
}
else
{
  for (int numberB = 0; numberB <= numberA; numberB++)
  {
    if( numberB % 2 == 0 && numberB != 0)
    {
              Console.WriteLine( String.Empty, numberA, " -> ");
              Console.Write(numberB + " ");
            }
  }
}
