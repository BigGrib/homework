int Summ(int i, int j, int k){
    if (i==0) return j;
    else if (i==1) return k;
    else return Summ(i-1,j,k)+Summ(i-2,j,k);

}

Console.Write("N = ");
int N = int.Parse(Console.ReadLine());
Console.Write("N1 = ");
int N1 = int.Parse(Console.ReadLine());
Console.Write("N2 = ");
int N2 = int.Parse(Console.ReadLine());
for (int i = 0;i<=N;i++){
int result = Summ(i,N1,N2);
Console.WriteLine(result);
}
