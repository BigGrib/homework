int Summ(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;           
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                       
    else if (M < N) return N + Summ(M, N - 1); 
    else return N + Summ(M, N + 1);            
}
        
        
Console.WriteLine("Введите первое число");
Console.Write("число M = ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
Console.Write("число N = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел между ними равна  {Summ(M, N)}");
Console.ReadLine();
        