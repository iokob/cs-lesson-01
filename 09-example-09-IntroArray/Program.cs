Console.WriteLine("* * * Найти максимальное число * * *");

int Max(int arg1, int arg2, int arg3) {
    int rezult = arg1;
    if (arg2 > rezult) rezult = arg2;
    if (arg3 > rezult) rezult = arg3;
    return rezult;
}
int[] array = {41, 26, 34, 24, 65, 65, 72, 38, 59};

int max = Max(
    Max(array[1], array[2], array[0]),
    Max(array[4], array[5], array[3]),
    Max(array[7], array[8], array[6]));

Console.WriteLine("максимальное число: " + max);
Console.WriteLine("* * * Программа завершена * * *");
