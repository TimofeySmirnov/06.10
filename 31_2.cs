double distance = 10;
double dailyIncrease = 0.10;
int totalDays = 0;
 Console.Write("Введите количество дней (S): ");
 if (int.TryParse(Console.ReadLine(), out totalDays) && totalDays > 0)
  {
  double totalDistance = 0;
  for (int day = 1; day <= totalDays; day++)
   {
   totalDistance += distance;
   distance += distance * dailyIncrease;
   }

  Console.WriteLine($"Спортсмен пробежит {totalDistance:F2} км за {totalDays} дней.");
  }
else
{
Console.WriteLine("Некорректный ввод.");
}