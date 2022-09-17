int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Задача 1. Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    Console.WriteLine("2. Задача 2. Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.");
    Console.WriteLine("3.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
        Console.Clear();
        Console.WriteLine($"Задача 1. Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
        int m = InputNumbers("Введите m: ");
        int n = InputNumbers("Введите n: ");
        int range = InputNumbers("Введите диапазон: от 1 до ");

        int[,] array = new int[m, n];
        CreateArray(array);
        WriteArray(array);

        int minSumLine = 0;
        int sumLine = SumLineElements(array, 0);
        for (int i = 1; i < array.GetLength(0); i++)
        {
        int tempSumLine = SumLineElements(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
        }

        Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


        int SumLineElements(int[,] array, int i)
        {
        int sumLine = array[i,0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sumLine += array[i,j];
        }
        return sumLine;
        }

        int InputNumbers(string input)
        {
        Console.Write(input);
        int output = Convert.ToInt32(Console.ReadLine());
        return output;
        }

        void CreateArray(int[,] array)
        {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
            array[i, j] = new Random().Next(range);
            }
        }
        }

        void WriteArray (int[,] array)
        {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
            Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
        }
        break;

        case 2:
        Console.Clear();
        Console.WriteLine($"Задача 2. Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.");
        Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
        int m1 = InputNumbers1("Введите число строк 1-й матрицы: ");
        int n1 = InputNumbers1("Введите число столбцов 1-й матрицы (и строк 2-й): ");
        int p1 = InputNumbers1("Введите число столбцов 2-й матрицы: ");
        int range1 = InputNumbers1("Введите диапазон случайных чисел: от 1 до ");

        int[,] firstMartrix = new int[m1, n1];
        CreateArray1(firstMartrix);
        Console.WriteLine($"\nПервая матрица:");
        WriteArray1(firstMartrix);

        int[,] secomdMartrix = new int[n1, p1];
        CreateArray1(secomdMartrix);
        Console.WriteLine($"\nВторая матрица:");
        WriteArray1(secomdMartrix);

        int[,] resultMatrix = new int[m1,p1];

        MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
        Console.WriteLine($"\nПроизведение первой и второй матриц:");
        WriteArray1(resultMatrix);

        void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
        {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i,k] * secomdMartrix[k,j];
            }
            resultMatrix[i,j] = sum;
            }
        }
        }

        int InputNumbers1(string input)
        {
        Console.Write(input);
        int output = Convert.ToInt32(Console.ReadLine());
        return output;
        }

        void CreateArray1(int[,] array)
        {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
            array[i, j] = new Random().Next(range1);
            }
        }
        }

        void WriteArray1 (int[,] array)
        {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
            Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
        }
        break;

        case 3:
        
        break;
    }
}