int Summ(int i, int j, int k){
    if (i==0) return j;
    else if (i==1) return k;
    else return Summ(i-1,j,k)+Summ(i-2,j,k);

}

Console.WriteLine("Введите количество чисел которые необходимо вывести ");
Console.Write("количество итераций = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число последовательности");
Console.Write("N1 = ");
int N1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число последовательности");
Console.WriteLine("N2 = ");
int N2 = int.Parse(Console.ReadLine());
for (int i = 0;i<N;i++){
Console.WriteLine($"{i+1}ая итерация = {Summ(i,N1,N2)}");
}
