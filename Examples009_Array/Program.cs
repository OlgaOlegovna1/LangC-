// Функция с массивом []
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

int[] array = {1,23,35,24,56,699,77,668,19};
/* Нахождения числа, по номеру массива например - [8] 
array[0] = 12;
Console.WriteLine(array[7]);*/

/*второй вариант функции*/
int MAX = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
/*int max1 = Max(a1,a2,a3);
int max2 = Max(a4,a5,a6);
int max3 = Max(a7,a8,a9);
int MAX = Max(max1,max2,max3);*/

Console.WriteLine(MAX);