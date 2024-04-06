// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 4. Напишите программу, которая на вход принимает натуральное число
// N, а на выходе показывает его цифры через запятую


// using System.Globalization;

int number = 17968;
int number2 = number;
int digits = 0; // кол-во цифр
while (number2 > 0)
{
  digits++;
  number2 = (int)(number2/10);
}
   
Console.WriteLine(digits); // Вывод количества цифр в числе

int result = 0;
int y = digits;
 
while (number > 0)
{
    result *= 10;
    result += number % 10;
    number /= 10;
}
 
for (int i = 0; i < y; i++)
{
    Console.Write(result%10+ ",");
    result /= 10;
}
 
// Console.ReadKey();  
 
// }