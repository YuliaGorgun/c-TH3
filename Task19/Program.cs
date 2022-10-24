// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 
//14212 -> нет
//12821 -> да
//23432 -> да
 
Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()!);
int rev = 0, num = number;
while (number > 0)
{rev = rev * 10 + number % 10; number /= 10;}
Console.WriteLine(num == rev ? " данное число является палиндром" : "данное число не является палиндром");
 
 

