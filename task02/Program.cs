/*/
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
/*/

int N = PrintAndGetValue("Введите длинну массива");
int min = PrintAndGetValue("Введите минимальное значение");
int max = PrintAndGetValue("Введите максимальное значение");

int[] array = CreateArray(N, min, max);

Console.WriteLine(PrintArray(array)+" -> "+ SummNotEvenPos(array));

int SummNotEvenPos(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        summ = summ + array[i];

    }
    return summ;
}

int[] CreateArray(int N, int min, int max)  // создаем массив длинной N и значениями в диапазоне [min, max]
{
    Random rnd = new Random();
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int PrintAndGetValue(string message) // пишем запрос, вводим число
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