Console.Write("Введите количество часов (n) кратное трём: ");
int n = int.Parse(Console.ReadLine());
int amebaCount = 1;
for (int hours = 3; hours <= n; hours += 3)
{
    amebaCount *= 2;
}
Console.WriteLine($"Через {n} часов будет {amebaCount} амеб.");