namespace Sort
{
    public class InsertionSort : ISort
    {
        public static List<int> Sort(List<int> items)
        {
            int n = items.Count();

            for (int i = 1; i < n; ++i)
            { 
                //    k
                // [3,5,6]
                int key = items[i];
                int j = i - 1;

                // move elements of arr[0...i-1]
                // that are greater than key
                // to one position ahead of their current position
                while (j >= 0 && items[j] > key)
                {
                    items[j+1] = items[j];
                    j--;
                }
                items[j+1] = key;
            }

            return items;
        }
    }
}