int[] sequence = { 1, 2, 3, 4, 1, 5, 6, 1, 7, 8, 1 };
int targetNumber = 1;
int count = 0;
foreach (int number in sequence)
{
    if (number == targetNumber)
    {
        count++;
    }
}
Console.WriteLine($"Число {targetNumber} встречается в последовательности {count} раз(а).");