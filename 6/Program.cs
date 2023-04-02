int Pow(int M, int N) {
    if (N == 1)
        return M;
    return M * Pow(M, --N);
}

Console.Write("M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("N = ");
int N = int.Parse(Console.ReadLine());
int result = Pow(M,N);
Console.WriteLine(result);