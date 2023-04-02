static int Ex(string w){
    int t;
    bool f = int.TryParse(w, out t);
    if (f){
    return t;
    }
    else {
        Console.WriteLine("Введено неправильное число");
        return 0;
    }
}


static int Num(string[] arr, int n, int k){
    for (int i = 0; i < n;)
{
    if (arr[i].Length > 3){
        i++;
    } else {
        k++;
        i++;
    }
}
return k;
}

void Return(string[] arr,string[] result, int n, int j){
for (int i = 0; i < n;)
{
    if ( (arr[i]).Length > 3){
        i++;
    } else {
        result[j]=arr[i];
        i++;
        j++;
    }
}
}

void PrintMass(string[] result,int k){
Console.WriteLine("Искомые элементы массива :");
for (int i = 0; i < k;i++)
{
    Console.Write(result[i]+ " ");// Вывод решения
}
}


Console.Write("Введите количество строк, которые хотите ввести: ");
string w = Console.ReadLine()?? ""; // Считываем строку, переводим в число.
int n = Ex(w);
string[] arr = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
int k = 0;
int j = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("Введите строку №{0}:\r\n    ", i + 1);
    arr[i] = Console.ReadLine()?? ""; //Заполняем его
}
k = Num(arr,n,k);
string[] result = new string[k];//Объявляем массив строк длиной k
Return(arr,result,n,j);
PrintMass(result,k);
Console.ReadLine();
