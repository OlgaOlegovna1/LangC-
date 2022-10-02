// создаем программу с использованием в массиве рамдонного числа (МЕТОД заполнения массива и вывода его на экран)

void FillArray(int[] collection) //метод заполнения массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //метод вывода этого массива на экран
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int INDEXof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; //указываем количество элементов в массиве (по умолчанию он заполнен 0ми, поэтому используем метод выше)

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = INDEXof(array, 5); //выводит на какой позиции будет цифра 5 в массиве (код с 26строки)
Console.WriteLine(pos);