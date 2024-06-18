Console.WriteLine("Введите количество строк:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int y = int.Parse(Console.ReadLine());

int[,] array = new int[x, y];

for(int i = 0; i < x; i++)
{
    for(int j = 0; j < y; j++)
    {
        array[i, j] = -1;
    }
}

Console.WriteLine("Введите координату x: ");
int startX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
int startY = int.Parse(Console.ReadLine());

array[startX, startY] = 0;

Console.WriteLine("Введите количество припятсвий:");
int let = int.Parse(Console.ReadLine());

Random random = new Random();

for (int k = 0; k < let; k++)
{
    int letX = random.Next(0, x);
    int letY = random.Next(0, y);

    while (array[letX, letY] != -1)
    {
        letX = random.Next(0, x);
        letY = random.Next(0, y);
    }

    if (k == let - 1)
    {
        array[letX, letY] = 99;
    }
    else
    {
        array[letX, letY] = -2;
    }
}
    
Console.WriteLine("Массив:");
for (int i = 0; i < x; i++)
{
    for(int j = 0; j < y; j++)
    {
        Console.Write($"{array[i, j], -4}\t");
    }

    Console.WriteLine("");
}

