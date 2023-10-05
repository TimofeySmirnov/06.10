int[] sequence = { 2, 3, 4, 5 };
int sum = 0;
foreach (int number in sequence)
{
    sum += number;
}
Console.WriteLine($"Сумма элементов последовательности: {sum}");
