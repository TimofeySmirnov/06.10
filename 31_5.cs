int totalLegs = 64;
for (int numGoose = 0; numGoose <= totalLegs / 2; numGoose++)
{
    int numRabbits = (totalLegs - (numGoose * 2)) / 4;
    int remainingLegs = totalLegs - (numGoose * 2) - (numRabbits * 4);
    if (remainingLegs == 0)
    {
        Console.WriteLine($"Гусей: {numGoose}, Кроликов: {numRabbits}");
    }
}
