int[] array = {18, 23, 3, 48, 25, 689, 37, 8, 59};
int n = array.Length;
int find = 689;

int index = 0;

while (index < n) {
    if (array[index] == find) {
        Console.WriteLine(index);
        break;
    }
    index++;
}
Console.WriteLine("* * * Программа завершена * * *");
