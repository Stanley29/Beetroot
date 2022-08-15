void Sort(int[] arr, SortAlgorithmType type, OrderBy order)
{
    switch (type)
    {
        case SortAlgorithmType.SelectionSort:
            SortSelection(arr);
            break;
        case SortAlgorithmType.BubbleSort:
            SortBubble(arr);
            break;
        case SortAlgorithmType.InsertionSort:
            SortInsertion(arr);
            break;
        default:
            Console.WriteLine("Dunno such type!");
            break;
    }

    if (order == OrderBy.Desc)
    {
        Array.Reverse(arr);
    }
}

void SortSelection(int []arr)
{
    int n = arr.Length;
 
    // One by one move boundary of unsorted subarray
    for (int i = 0; i < n - 1; i++)
    {
        // Find the minimum element in unsorted array
        int min_idx = i;
        for (int j = i + 1; j < n; j++)
            if (arr[j] < arr[min_idx])
                min_idx = j;
 
        // Swap the found minimum element with the first
        // element
        (arr[min_idx], arr[i]) = (arr[i], arr[min_idx]);
    }
}

void SortBubble(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    for (int j = 0; j < n - i - 1; j++)
        if (arr[j] > arr[j + 1]) {
            // swap temp and arr[i]
            (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
        }
}

void SortInsertion(int[] arr)
{
    int n = arr.Length;
    for (int i = 1; i < n; ++i) {
        int key = arr[i];
        int j = i - 1;
  
        // Move elements of arr[0..i-1],
        // that are greater than key,
        // to one position ahead of
        // their current position
        while (j >= 0 && arr[j] > key) {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = key;
    }
}

void PrintArray(int[] arr)
{
    foreach (var number in arr)
    {
        Console.Write($"{number} ");
    }
}

Console.WriteLine("\n\nSelection sort(Descending):");
int[] arr = new int[] {5, 15, 2, 9, 7, 4, 3};
PrintArray(arr);
Sort(arr, SortAlgorithmType.SelectionSort, OrderBy.Desc);
Console.WriteLine();
PrintArray(arr);

Console.WriteLine("\n\nBubble sort(Ascending):");
arr = new int[] {6, 2, 3, 1, 10, 15, 20};
PrintArray(arr);
Sort(arr, SortAlgorithmType.BubbleSort, OrderBy.Asc);
Console.WriteLine();
PrintArray(arr);

Console.WriteLine("\n\nInsertion sort(Descending):");
arr = new int[] {15, 8, 4, 27, 18, 1, 0};
PrintArray(arr);
Sort(arr, SortAlgorithmType.InsertionSort, OrderBy.Desc);
Console.WriteLine();
PrintArray(arr);

enum SortAlgorithmType
{
    SelectionSort = 1,
    BubbleSort,
    InsertionSort
}

enum OrderBy
{
    Asc = 1,
    Desc
}

//checked
