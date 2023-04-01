Console.Write("Введите количество строк, которые хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
int k = 0;
int j = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("Введите строку №{0}:\r\n    ", i + 1);
    strs[i] = Console.ReadLine(); //Заполняем его
}
Console.WriteLine("Искомые элементы массива :");
for (int i = 0; i < n;)//Проверка количества элементов в массиве удовлетворяющив условию задачи 
{
    if (strs[i].Length > 3){
        i++;
    } else {
        k++;
        i++;
    }
}
string[] result = new string[k];//Объявляем массив строк длиной k
for (int i = 0; i < n;)//перенос элементов  удовлетворяющих условию задачи в новый массив 
{
if (strs[i].Length > 3){
        i++;
    } else {
        result[j]=strs[i];
        i++;
        j++;
    }
}
for (int i = 0; i < k;i++)
{
    Console.Write(result[i]+ " ");// Вывод решения
}
Console.ReadLine();