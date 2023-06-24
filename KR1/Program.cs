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




int Numbers(string text)
{
    Console.Write(text);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
