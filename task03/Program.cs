/*/
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
/*/

double[] array = PrintStrAndGetArrayOfDouble("Введите массив чисел (через пробел)");
Console.WriteLine(PrintArrayOfDouble(array)+" -> "+ Diff(array));


double Diff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    double diff = max - min;
    return diff;
}

double[] PrintStrAndGetArrayOfDouble(string message) // пишем сообщение и задаем массив вещественных чисел
{
    Console.WriteLine(message);

    string ArrayInOneString = (Console.ReadLine());
    string[] ArrayOfString = ArrayInOneString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] ArrayOfDouble = new double[ArrayOfString.Length];

    for (int i = 0; i < ArrayOfDouble.Length; i++)
    {
        ArrayOfDouble[i] = double.Parse(ArrayOfString[i]);
    }
    return ArrayOfDouble;
}

string PrintArrayOfDouble(double[] array) // пишем массив double в строку
{
    string str = "["+string.Join(" ",array)+"]";
    return str;
}

