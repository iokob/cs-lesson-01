Console.WriteLine("* * * Найти максимальное число * * *");

int Max(int arg1, int arg2, int arg3) {
    int rezult = arg1;
    if (arg2 > rezult) rezult = arg2;
    if (arg3 > rezult) rezult = arg3;
    return rezult;
}

int n1 = 11115;
int n2 = 21;
int n3 = 339;
int n4 = 12;
int n5 = 23;
int n6 = 33;
int n7 = 13;
int n8 = 5523;
int n9 = 3362;

// int max1 = Max(n1, n2, n3);
// int max2 = Max(n4, n5, n6);
// int max3 = Max(n7, n8, n9);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(n1, n2, n3),
    Max(n4, n5, n6),
    Max(n7, n8, n9));

Console.WriteLine("максимальное число: " + max);
Console.WriteLine("* * * Программа завершена * * *");
