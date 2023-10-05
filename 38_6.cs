int[] sequence = { 2, 3, 4, 5 };
int product = 1;
foreach (int number in sequence)
{
    product *= number;
}
Console.WriteLine($"Произведение элементов последовательности: {product}");
