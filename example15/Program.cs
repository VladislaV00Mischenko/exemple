//int[,] matrixA = new int[5, 5];
//int[,] matrixB = new int[5, 5];







void FillArrayMatrix(int[,] matr)
{
    Random rnd = new Random();
    for(int i = 0;i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(0, 10 );
        }
    }

}

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumArrayMatrix(int[,] matr) //возвращает сумму всех элементов
{
    int sumAll = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            sumAll += matr[i, j]; 
        }

    }
    return sumAll;
}

void PrintDiff(int a, int b)
{
    if(a > b) Console.WriteLine($"Число {a} больше  {b}");
    else if(a < b) Console.WriteLine($"Число {a} меньше  {b}");
    else Console.WriteLine($"Число {a} равно  {b}");
}

int SumEvenNumbers(int[,] matr) //возвращает количество четных элементов
{
    int sumNum = 0;
    
    for(int i = 0; i< matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i, j] % 2 != 0) 
            {
            sumNum ++ ;
            }
        }
    }
    return  sumNum;
}

int SumNumInArray(int[,] matr) //возвращает сумму элементов внутреннего квадрата
{
    int sumNum = 0;
    
    for(int i = 1; i< matr.GetLength(0) - 1; i++)
    {
        for(int j = 1; j < matr.GetLength(1) - 1; j++)
        {
             sumNum += matr[i, j] ;
            
        }
    }
    return  sumNum;
}

int[] SumDgit(int[,] matr) //возвращает массив с количеством нечетных чисел и их суммой
{
    int sumNum = 0;
    int sumDigit = 0;
    int[] numAndDigit = new int[2];
    for(int i = 0; i< matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i, j] % 2 != 0) 
            {
            sumNum ++ ;
            sumDigit += matr[i, j];
            }
        }
    }
    numAndDigit[0] = sumNum;
    numAndDigit[1] = sumDigit;
    return  numAndDigit;
}

void FillArrayCube(int[,,] matr)
{
    Random rnd = new Random();
    for(int i = 0;i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int z = 0; z < matr.GetLength(2); z++)
            {
                matr[i, j, z] = rnd.Next(0, 10);
            }
        }
    }

}

void PrintArrayCube(int[,,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int z = 0; z < matr.GetLength(2); z++)
            {
            Console.Write($" {matr[i, j, z]} ");
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[] MultiplaceElement(int[,] matr)
{
    
   
    int[] numAndDigit = new int[matr.GetLength(0)];
    for(int i = 0; i< matr.GetLength(0); i++)
    {
        int sumDigit = 0;
        for(int j = 1; j < matr.GetLength(1); j++)
        {
             
            sumDigit += matr[i, 0] * matr[i, j];
            
        }
        numAndDigit[i] = sumDigit;
    }
    
    return  numAndDigit;
}