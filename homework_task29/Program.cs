// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int input(string message){
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int [] genArray (int minRNG, int maxRNG){
    int [] array = new int[8];
    for(int i = 0; i < array.Length; i++){
        array[i] = Random.Shared.Next(minRNG, maxRNG + 1);
    }
    return array;
}

void Print(int [] array){
    
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i] + " "}");
    }
}
int min = input("Введите минимальное значение для рандомной генерации: ");
int max = input("Введите максимальное значение для рандомной генерации: ");
int[] array = genArray(min, max);
Print(array);