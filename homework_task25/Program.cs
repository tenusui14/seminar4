// Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int i = 1;
int temp = numberA;
while (i < numberB){
    numberA *= temp;
    i++;
}
Console.WriteLine($"{temp} в степени {numberB} = {numberA}");
