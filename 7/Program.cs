int Summ(int i){
    if (i==0) return 0;
    else if (i==1) return 1;
    else return Summ(i-1)+Summ(i-2);

}




Console.Write("N = ");
int N = int.Parse(Console.ReadLine());
for (int i = 0;i<=N;i++){
int result = Summ(i);
Console.WriteLine(result);
}
