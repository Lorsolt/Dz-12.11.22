// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2)
{
    Console.WriteLine(" Больше " + num1 + " Меньше " + num2);
}
else if (num1 == num2)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine(" Больше " + num2 + " Меньше " + num1);
}