// SЗадача 3. Напишите программу, которая принимает на вход 
// целое число из отрезка (10, 99) и показывает наибольшую цифру 
// числа.

int n = 55; 
int first = n / 10;
int second = n % 10;
if (first > second) 
Console.WriteLine("First"); 
else 
    { if ( first != second) 
    Console.WriteLine("second");
    else Console.WriteLine("equal");
}



