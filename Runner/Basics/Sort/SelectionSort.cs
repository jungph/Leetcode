namespace Sort
{
    public class SelectionSort : ISort
    {
        public static List<int> Sort(List<int> items)
        {
            for (int i = 0; i < items.Count() - 1; ++i)
            {
                var minIdx = i;

                for (int j = i+1; j < items.Count(); ++j)
                {
                    if (items[j] < items[minIdx])
                    {
                        minIdx = j;
                    }
                }
                var temp = items[minIdx];
                items[minIdx] = items[i];
                items[i] = temp;
            }
            return items;
        }
    }
}