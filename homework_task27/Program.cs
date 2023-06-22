// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int input(){
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int calculations(int a){
    int temp = 0;
    while(a>0) {
        temp += a % 10;
         a = a/10; 
     }
return temp;
}

int number = input();
Console.WriteLine($"Сумма цифр в числе = {calculations(number)}");