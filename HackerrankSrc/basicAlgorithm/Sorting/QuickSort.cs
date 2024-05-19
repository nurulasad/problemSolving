namespace HackerrankSrc
{

    public class QuickSort
    {
        //https://www.geeksforgeeks.org/quick-sort/

        public void Sort(int[] arr, int left, int right)
        {
            if (left > right)
                return;

            int pivot_index = Partition(arr, left, right);

            Sort(arr, left, pivot_index - 1);
            Sort(arr, pivot_index + 1, right);
        }

        private int Partition(int[] arr, int left, int right)
        {
//            ShowSubArray(arr, left, right);

            int pivot = arr[right];


            int i = left;
            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++;

                    //ShowArray(arr);
                }
            }

            int t2 = arr[i];
            arr[i] = arr[right];
            arr[right] = t2;


            //ShowArray(arr, $"\nSwap pivot: pivot={pivot} with {t2}. New partition from index {i}\n");

            return i; //partiotionainng point
        }
        

        //public static void ShowArray(int[] arr, string text = "")
        //{
        //    if (!string.IsNullOrEmpty(text))
        //    {
        //        Console.Write(text);
        //    }
        //    else
        //    {
        //        Console.Write("\nArray is: ");
        //    }

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //}

        //public static void ShowSubArray(int[] arr, int left, int right, string text = "")
        //{
        //    if (!string.IsNullOrEmpty(text))
        //    {
        //        Console.Write(text);
        //    }
        //    else
        //    {
        //        Console.Write("\nSub Array is: ");
        //    }
        //    for (int i = left; i <= right; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //}

        //static void Main(string[] args)
        //{

        //    //int[] arr = new int[] { 50, 23, 9, 18, 61, 32 };
        //    int[] arr = new int[] { 10, 80, 30, 90, 40, 50, 70 };
        //    //int[] arr = new int[] { 5000, 80, 30,60, -1, -500, 0 };
        //    int n = 10, i;
        //    Console.WriteLine("Quick Sort");
        //    ShowArray(arr, "Initial array is: ");
        //    QuickSort(arr, 0, arr.Length - 1);
        //    ShowArray(arr, "Sorted Array is: ");
        //    Console.ReadLine();
        //}
    }
}
    

