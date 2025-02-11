// https://github.com/mroeb/DevStarterPack.git
// 12. Binary Search

static int BinarySeach(int[] arr, int target)
{
    int low = 0;
    int high = arr.Length - 1;

    while ( low <= high )
    {
        int mid = low + (high - low) / 2;

        if ( arr[ mid ] == target )
        {
            return mid;
        }
        else if ( arr[ mid ] < target )
        {
            low = mid + 1;
        }
        else
        {
            high = mid - 1;
        }
    }

    return -1;
}

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int target = 5;

int result = BinarySeach(arr, target);

if ( result == -1 )
{
    Console.WriteLine("Element not found");
}
else
{
    Console.WriteLine("Element found at index: " + result);
}
