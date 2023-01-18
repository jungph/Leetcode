namespace Sort
{
    public class QuickSort : ISort
    {
        public static void Swap(ref List<int> items, int i, int j)
        {
            int temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }

        public static int Partition(ref List<int> items, int low, int high)
        {
            int pivot = items[high];

            int i = (low - 1);
            // i = -1
            // i = 0
            // j = 1
            // pivot = 7

            //         p
            // [ 3, 3, 5, 7]
            for (int j = low; j <= high - 1; j++)
            {
                if (items[j] < pivot)
                {
                    i++;
                    Swap(items, i, j);
                }
            }
            Swap(items, i + 1, high);
            return (i + 1);
        }


        public static List<int> Sort(List<int> items)
        {
            SortHelper(ref items, 0, items.Count() - 1);
            return items;
        }

        public static void SortHelper(ref List<int> items, int low, int high)
        {
            if (low < high)
            {
                // pi is partitioning index, items[p]
                // is now at the right place
                int pi = Partition(items, low, high);
                SortHelper(items, low, pi - 1);
                SortHelper(items, pi + 1, high);
            }
        }

    }
}