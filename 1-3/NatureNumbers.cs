
int Nature(int i)
{
    if (i==1) return 1;
    else return Nature(i-1)+1;
}


Console.WriteLine("Выбирете нужный вариант задания:");
Console.WriteLine("1. Показать натуральные числа от 1 до N (необходимо ввести N)");
Console.WriteLine("2. Показать натуральные числа от N до 1 (необходимо ввести N)");
Console.WriteLine("3. Показать натуральные числа от M до N (необходимо ввести M и N)");
Console.WriteLine();
Console.Write("Напишите нужный вариант:");
int Num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N ");
Console.Write("N = ");
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
Console.WriteLine("Введите M (M < N)");
Console.Write("M = ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine();
for (int i = M; i <= N; i++)
{
Console.WriteLine(Nature(i));
}
}
Console.WriteLine();