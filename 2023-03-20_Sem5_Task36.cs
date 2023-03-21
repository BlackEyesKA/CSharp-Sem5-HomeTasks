//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void InputArray(int[] array) //метод заполняет массив случайными элементами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 100); //[-10, 99]
    }
}

int ReleaseArray(int[] array)
{
    int SumN = 0;
    for (int i = 0; i < array.Length; i += 2)
        SumN += array[i];
    return SumN;
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
Console.Write($"сумма элементов, стоящих на нечётных позициях = ");
Console.WriteLine(ReleaseArray(array));