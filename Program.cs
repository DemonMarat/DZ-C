// // Задача 2: Напишите программу, 
// которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// Console.WriteLine("Введите число");

// int num = Convert.ToInt32(Console.ReadLine());

// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num>num2) {
// Console.WriteLine(num);
// } else {
// Console.WriteLine(num2);
// }

// Задача 4: Напишите программу, 
// которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите 3 числа:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if (num2 > max)
// {
// max = num2;
// }

// if (num3 > max)
// {
// max = num3;
// }

// Console.WriteLine("Наибольшее из введённых чисел -> " + max);

// //Задача 6: Напишите программу, 
// которая на вход принимает число и выдаёт
// , является ли число чётным 
// (делится ли оно на два без остатка).

// Console.WriteLine("Введите число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// if ((num % 2) == 0)
// {
// Console.WriteLine("Четное");
// }
// else
// {
// Console.WriteLine("Нечетное");
// }

// Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int evenNumber = 2;

// if(num > 1)
// {
// while(evenNumber <= num)
// {
// Console.Write(evenNumber + " ");
// evenNumber = evenNumber + 2;
// }
// }

// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();
// Console.WriteLine("Задача 10 ");
// Console.Write("Введи трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);

// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Задача 13 ");

// Console.Write("Введи число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2)
// {
//   Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
// else {
//   Console.WriteLine("-> третьей цифры нет");
// }


// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введи цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());

// void CheckingTheDayOfTheWeek (int dayNumber) {
//   if (dayNumber == 6 || dayNumber == 7) {
//   Console.WriteLine("(этот день выходной) -> да");
//   }
//   else if (dayNumber < 1 || dayNumber > 7) {
//     Console.WriteLine("это вообще не день недели");
//   }
//   else Console.WriteLine("(этот день не выходной) -> нет");
// }

// CheckingTheDayOfTheWeek(dayNumber);


