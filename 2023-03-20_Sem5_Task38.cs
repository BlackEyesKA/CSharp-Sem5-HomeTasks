//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void InputArray(int[] array) //метод заполняет массив случайными элементами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100); //[1, 99]
    }
}

int ReleaseArray(int[] array)
{
    int Dif = 0, max = array[0], min = array[0];
    for (int i = 1; i < array.Length; i ++)
        if (array[i] > max) max = array[i];
    for (int i = 1; i < array.Length; i ++)
        if (array[i] < min) min = array[i];
    Dif = max - min;
    return Dif;
}

void PrintArray (int[] array) //метод выводит на экран элементы массива
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

Console.Clear();
Console.Write($"количество элементов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
Console.Write($"разница между максимальным и минимальным элементами массива = ");
Console.WriteLine(ReleaseArray(array));