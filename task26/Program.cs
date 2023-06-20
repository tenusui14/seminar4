//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Input(){
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}
int calc(int a){
int numOfNum = 0;
while (a > 0){
    a /= 10;
    numOfNum++;
}
return numOfNum;
}
int number = Input();
int col = calc(number);
Console.WriteLine(col);