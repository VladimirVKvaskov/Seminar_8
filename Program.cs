/*

//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
	
    Console.Clear();
    Console.WriteLine("введите количество строк");
	int lines = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("введите количество столбцов");
	int columns = Convert.ToInt32(Console.ReadLine());
	int[,] numbers = new int[lines, columns];
	Random(numbers);
	Console.WriteLine();
	Console.WriteLine("Исходный массив");
	PrintArray(numbers);
	
	for (int i = 0; i < numbers.GetLength(0); i++)
	{
	    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
	    {
	        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
	        {
	            if (numbers[i, z] < numbers[i, z + 1]) 
	            {
	                int n = 0;
	                n = numbers[i, z];
	                numbers[i, z] = numbers[i, z + 1];
	                numbers[i, z + 1] = n;
	            }
	        }
	    }
	}
	Console.WriteLine();
	Console.WriteLine("Упорядоченный массив");
	PrintArray(numbers);
	
	void Random(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            array[i, j] = new Random().Next(0, 10);
	        }
	    }
	}
	
	void PrintArray(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        Console.Write("[ ");
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            Console.Write(array[i, j] + " ");
	        }
	        Console.Write("]");
	        Console.WriteLine("");
	    }
	}




//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
	
    Console.Clear();

	Console.WriteLine("введите размер массива");
	int massVol = Convert.ToInt32(Console.ReadLine());
	int[,] numbers = new int[massVol, massVol];
	Random(numbers);
	PrintArray(numbers);
	int minsum = Int32.MaxValue;
	int indexLine = 0;
	
	for (int i = 0; i < numbers.GetLength(0); i++)
	{
	    int sum = 0;
	    for (int j = 0; j < numbers.GetLength(1); j++)
	    {
	        sum = sum + numbers[i, j];        
	    }
	    if (sum < minsum)
	    {
	        minsum = sum;
	        indexLine++;
	    }
	}
	
	Console.WriteLine("строка с наименьшей суммой элементов номер: " + (indexLine));
    Console.WriteLine("сумма = " + (minsum));
	
	void Random(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            array[i, j] = new Random().Next(0, 10);
	        }
	    }
	}
	
	void PrintArray(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        Console.Write("[ ");
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            Console.Write(array[i, j] + " ");
	        }
	        Console.Write("]");
	        Console.WriteLine("");
	    }
	}




//Заполните спирально массив 4 на 4.
	
    Console.Clear();

	Console.WriteLine("Введите размер массива");
	int size = Convert.ToInt32(Console.ReadLine());
	
	int[,] nums = new int[size, size];
	
	int num = 1;
	int i = 0;
	int j = 0;
	
	while (num <= size * size)
	{
	    nums[i, j] = num;
	    if (i <= j + 1 && i + j < size - 1)
	        ++j;
	    else if (i < j && i + j >= size - 1)
	        ++i;
	    else if (i >= j && i + j > size - 1)
	        --j;
	    else
	        --i;
	    ++num;
	}
	
	PrintArray(nums);
	
	void PrintArray(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        Console.Write("[ ");
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            Console.Write(array[i, j] + " ");
	        }
	        Console.Write("]");
	        Console.WriteLine("");
	    }
	}

*/

