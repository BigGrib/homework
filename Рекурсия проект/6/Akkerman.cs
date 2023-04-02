static int A(int M, int N)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

Console.WriteLine("Введите первое число");
Console.Write("число M = ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число");
Console.Write("число N = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"F({M},{N}), F = {A(M, N)}");