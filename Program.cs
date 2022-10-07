void HW1()
{
    Console.Clear();
    Console.WriteLine("Данная программа отображает массив заполненный случайными вещественными числами...");
    Console.WriteLine("Введите количество строк в массиве...");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве...");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество чисел после запятой...");
    int t = Convert.ToInt32(Console.ReadLine());
    double[,] numbers = new double[m, n];
    FillArrayDouble(numbers, t);
    PrintArrayDouble(numbers);
}

void FillArrayDouble(double[,] numbers, int t)
{
    Random random = new Random();
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = Math.Round(random.NextDouble() * 10 - 5, t);
        }
    }
}

void PrintArrayDouble(double[,] numbers)
{
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t\t");
        }
        Console.WriteLine();
    }
}

////////////////////////////////////////////////////////////////

void HW2()
{
    Console.Clear();
    Console.WriteLine("Данная программа выводит элемент массива по заданным индексам...");
    Console.WriteLine("Введите количество строк в массиве...");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве...");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[m, n];
    FillArray(numbers);
    PrintArray(numbers); 
    Console.WriteLine("Нажмите клавишу S для введения индексов массива и получения значения находящегося в этом индексе...");
    Console.WriteLine("Нажмите клавишу R для введения числового значения и получения индексов данного значения...");
    var changer = Console.ReadKey();
    if(changer.KeyChar == 's')
    {
        Console.WriteLine();
        FindElement(numbers);       
    }
    if(changer.KeyChar == 'r')
    {
        Console.WriteLine();
        FindIndex(numbers);       
    }
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = random.Next(-9, 10);
        }
    }
}

void FindElement(int[,] numbers)
{
    Console.WriteLine("Введите индекс строки массива...");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца массива...");
    int y = Convert.ToInt32(Console.ReadLine());
    int findElement = 0;
    bool check = false;
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
           if(i == x && j == y)
           {
            findElement = numbers[i, j];
            check = true;
           }
           
        }
    }
    if(check)
    {
        Console.WriteLine($"Число индекса [{x}, {y}] = [{findElement}]");
    }
    else
    {
        Console.WriteLine("Индекс за границами массива.");
    }
}

void FindIndex(int [,] numbers)
{
    Console.WriteLine("Введите однозначное число...");
    int x = Convert.ToInt32(Console.ReadLine());
    int findIndex = 0;
    bool check = false;
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
           if(x == numbers[i, j])
           {
            findIndex = numbers[i, j];
            check = true;
            Console.WriteLine($"Число {findIndex} находится в индексе [{i},{j}]");
           }
           
        }
    }
    if(check)
    {
    }
    else
    {
        Console.WriteLine("Данного элемента не существует в массиве.");
    }
}

void PrintArray(int[,] numbers)
{
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

///////////////////////////////////////////////////////////////

void HW3()
{
    Console.Clear();
    Console.WriteLine("Данная программа находит среднее арифметическое элементов в каждом столбце.");
    Console.WriteLine("Введите количество строк в массиве...");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве...");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[m, n];
    FillArray(numbers);
    PrintArray(numbers); 
    Sum(numbers);
}

void Sum(int[,] numbers)
{
    Console.WriteLine();
    Console.WriteLine("Массив средних арифметических подсчётов столбцов");
    double[] result = new double[numbers.GetLength(1)];
    Console.Write("[");
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        result[j] = 0;
        for(int i = 0; i < numbers.GetLength(0); i++)
        {
            result[j] = result[j] + numbers[i, j];
            
        }
        result[j] = result[j] / numbers.GetLength(0);
        Console.Write(result[j] + "\t");      
    }
    Console.Write("]");
}
// HW1();
HW2();
// HW3();