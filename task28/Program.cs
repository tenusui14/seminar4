// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Input(){
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
return num;
}
int calc(int a){
    int pow = 1;
    for( int i = 1; i <= a; i++ ){
        pow *= i;
    }
    return pow;
}
int number = Input();
int result = calc(number);
Console.WriteLine(result);
