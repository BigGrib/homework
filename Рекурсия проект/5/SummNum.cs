int Sum(int num)
    {
        if (num < 10) return num;
        else return num % 10 + Sum(num / 10);
    }


Console.WriteLine("Введите число для вычисления суммы его чисел");
Console.Write("число = ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"сумма чисел числа {num} = {Sum(num)}");