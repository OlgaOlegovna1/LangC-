// показана Функция (МЕТОД) нахождения максимального числа. сравниваем по 3 числа и битва победителей
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

int a1 = 10;
int a2 = 15;
int a3 = 27;
int a4 = 420;
int a5 = 1;
int a6 = 17;
int a7 = 33;
int a8 = 110;
int a9 = 5;

int max1 = Max(a1,a2,a3);
int max2 = Max(a4,a5,a6);
int max3 = Max(a7,a8,a9);
int MAX = Max(max1,max2,max3);

Console.WriteLine(MAX);