
int Nature(int i)
{
    if (i==1) return 1;
    else return Nature(i-1)+1;
}
int NatureSumm(int i)
{
    if (i==0) return 0;
    else return i + NatureSumm(i+1);
}


Console.WriteLine("Please write number qestion");
int Num = int.Parse(Console.ReadLine());
Console.WriteLine("Please write N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
if (Num==1){
for (int i = 1; i <= N; i++)
{
Console.WriteLine(Nature(i));
}
} else if (Num==2){
    for (int i = N; i > 0; i--)
{
Console.WriteLine(Nature(i));
}
} else if (Num==3){
Console.WriteLine("Please write M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine();
for (int i = M; i <= N; i++)
{
Console.WriteLine(Nature(i));
}
} else if (Num==4){
Console.WriteLine("Please write M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine();
for (int i = M+1; i <=N; i++)
{
Console.WriteLine(NatureSumm(i));
}
}
Console.WriteLine();