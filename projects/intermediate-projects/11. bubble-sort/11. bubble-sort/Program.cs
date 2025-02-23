﻿// https://github.com/mroeb/DevStarterPack.git
// 11. Bubble Sort

int[] BubbleSort(int[] arr)
{
    int n = arr.Length;
    for ( int i = 0 ; i < n - 1 ; i++ )
    {
        for ( int j = 0 ; j < n - i - 1 ; j++ )
        {
            if ( arr[ j ] > arr[ j + 1 ] )
            {
                int temp = arr[j];
                arr[ j ] = arr[ j + 1 ];
                arr[ j + 1 ] = temp;
            }
        }
    }
    return arr;
}

int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

int[] sortedArr = BubbleSort(arr);

foreach ( int i in sortedArr )
{
    Console.Write(i + " ");
}