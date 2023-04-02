int Pow(int M, int N) {
    if (N == 1)
        return M;
    return M * Pow(M, --N);
}

Console.WriteLine("Введите число для возведения в степень");
Console.WriteLine("число =");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральную степень");
Console.WriteLine("степень = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Pow, P = {Pow(M, N)}");