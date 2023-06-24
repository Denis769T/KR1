int n=Numbers("Введите количество элементов массива: ");
int m = 0;
string[] str = new string[n];
for (int i = 0; i < n; i++)
    {
        Console.Write("Введите элемент массива №{0}:\r\n    ", i + 1);
        str[i] = Console.ReadLine(); //Заполняем массив
    }
    
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("Вы ввели следующие строки:");
Console.WriteLine("----------------------------------------------------");
for (int i = 0; i < n; i++)
{
    Console.WriteLine("  "+ str[i]);
}

Console.WriteLine("----------------------------------------------------");

// Сортировка данных массива

Console.WriteLine("Вывод строк с значением меньше, либо равно трем символам  ");
for (int index = 0; index < n; index++)
    
{
    string strg = str[index];
    if (strg.Length <= 3)
 
     {
        str[m] = str[index];
        m++;
     }
      
}
Console.WriteLine("-----------------------------------------");

for (int i = 0; i < m; i++)//Вывод нового массива
{
    Console.WriteLine("  " + str[i]);
}

int Numbers(string text)
{
    Console.Write(text);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
