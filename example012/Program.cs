

int[] array = new int[20];

FillArray(array);
PrintArray(array);
 SortArrayMaxMin(array);
 Console.WriteLine();
PrintArray(array);


void FillArray(int[] arr)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    arr[i] = rnd.Next(0, 100);
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void SortArrayMaxMin(int[] arr)
{
    int max;
    for(int i = 0; i < arr.Length; i++)
    {
        
        for(int j = i + 1; j < arr.Length; j++)
        {
            if(arr[i] < arr[j]) 
            {
                max = arr[j];
                arr[j] = arr[i];
                arr[i] = max;
            }
            
        }
       
    }

}

void SortArrayMinMax(int[] arr)
{
    int min;
    for (int i = 0; i < arr.Length - 1; i++)
    {
    for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                min = arr[i];
                arr[i] = arr[j];
                arr[j] = min;
            }
        }
    }
}