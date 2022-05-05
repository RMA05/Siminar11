// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
//            В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
//            Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
//

Random red = new Random();
int[] info = new int[red.Next(2, 5)];

int dataLength = 0;
Console.WriteLine("Массив info");
for (int i = 0; i < info.Length; i++)
{
    info[i] = red.Next(1, 4);
    Console.Write(info[i] + "\t");
    dataLength += info[i];
}

Console.WriteLine();
int[] data = new int[dataLength];

Console.WriteLine("Массив data");
for (int i = 0; i < data.Length; i++)
{
    data[i] = red.Next(0, 2);
    Console.Write(data[i] + "\t");
}
Console.WriteLine();

int[] result = new int[info.Length];
int lastindex = 0;
for (int i = 0; i < info.Length; i++)
{
    int number = 0;
    double number1 = 0;
    int pow = info[i] - 1;
    for (int j = lastindex; j < lastindex + info[i]; j++)
    {
        number = number * 10 + data[j];
        number1 += data[j] * Math.Pow(2, pow);
        pow--;
    }
    lastindex += info[i];
    result[i] = (int)number1;
}
Console.WriteLine("Итоговый массив");
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + "\t");
}
