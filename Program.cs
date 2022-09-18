bool check(string b)
{
    bool result=true;
    if (b.Length > 3)
        result = true; 
        else result = false;
    return result;
}
int m = new Random().Next(1, 6);
Console.WriteLine($"Случайное число элементов m={m}, введи элементы");
string[] a = new string[m];
string[] b = new string[m];
int k = 0;
for (int i = 0; i < m; i = i + 1)
{
    a[i] = Console.ReadLine();
    if (check(a[i]) == true)
        b[k] = a[i];
    k = k + 1;
}
Console.WriteLine("Итоговый массив:");
for (int i = 0; i < k; i = i + 1)
    Console.Write($"{b[i]} ");
    Console.WriteLine();