//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

//456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int leng_num = num1.ToString().Length;
// int TreeNum(int num1)
// {
//     int sto = (num1 / 10) % 10;  
//     return sto;  
// }

// if (leng_num != 3)
// {
//     Console.WriteLine("Вы ввели не 3-х значное число!");
// }
// else 
// {
//     Console.WriteLine(TreeNum(num1));
// }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine("Введите число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int leng_num = num1.ToString().Length;

// int TreeNum(int num1, int leng_num)
// {
//     int sto = 1;  
//     for (int i = leng_num; i > 3; i--)
//        {
//            sto = sto * 10;
//        }

//         sto = (num1 / sto) % 10;
//     return sto;  
// }

// if (leng_num < 3)
// {
//     Console.WriteLine("Третьей цифры нет!");
// }
// else 
// {
//     Console.WriteLine(TreeNum(num1, leng_num));
// }


//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число дня недели от 1 до 7: ");
int num1 = Convert.ToInt32(Console.ReadLine());


if (num1 < 6 && num1 > 0 ) Console.WriteLine("Это рабочий день!");
if(num1 < 8 && num1 > 5)  Console.WriteLine("Это выходной!");
if (num1 < 1 || num1 > 7) Console.WriteLine("Такого дня недели нет");
