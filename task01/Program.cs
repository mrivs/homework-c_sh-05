
/*/ 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
/*/

int N=PrintAndGetValue("Введите длинну массива");
int[]array=CreateArray(N);
Console.WriteLine(PrintArray(array)+" -> "+ CheckEvenNumbers(array));

int[] CreateArray(int N)  // создаем массив длинной N и значениями в диапазоне [100, 999]
{
    Random rnd = new Random();
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

int CheckEvenNumbers(int[] array) // ищем кол-во четных чисел
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) k++;
    }
    return k;
}

int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int v = int.Parse(Console.ReadLine());
    return v;
}

string PrintArray(int[] array) // пишем массив в строку
{
    string str = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) str = str + array[i] + ", ";
        else str = str + array[i] + "]";
    }
    return str;
}