System.Console.WriteLine("Введите количество углеводов, употребленных за день: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество белков, употребленных за день: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество жиров, употребленных за день: ");
int num3 = Convert.ToInt32(Console.ReadLine());
void Norm(double current, int min, int max)
{
    if (current < min) System.Console.Write("Это слишком мало");
    else if (current > max) System.Console.Write("Это слишком много");
    else System.Console.Write("Это в пределах нормы");
}
int sum = num1*4+num2*4+num3*9;
double percentCarb = num1*4*100/sum;
double percentProt = num2*4*100/sum;
double percentFat = num3*9*100/sum;
System.Console.WriteLine($"Вы употребили {sum} кКал.");
Norm(sum, 2000, 2900);
System.Console.WriteLine();
System.Console.WriteLine($"В вашем рационе { Math.Round(percentCarb, 2) } % углеводов =>");
Norm(percentCarb, 40, 55);
System.Console.WriteLine();
System.Console.WriteLine($"В вашем рационе { Math.Round(percentProt, 2) } % белков =>");
Norm(percentProt, 10, 20);
System.Console.WriteLine();
System.Console.WriteLine($"В вашем рационе { Math.Round(percentFat, 2) } % жиров =>");
Norm(percentFat, 25, 40);
System.Console.WriteLine();