// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 2. Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причем X≠0 и Y≠0 и выдает номер 
// координатной четверти плоскости, в которой находится эта точка

float x = 54;
float y = -27;
if (x > 0 & y > 0){
    Console.Write("I");
}
if (x > 0 & y < 0){
    Console.Write("II");
}
if (x < 0 & y < 0){
    Console.Write("III");
}
if (x < 0 & y > 0){
    Console.Write("IV");
}