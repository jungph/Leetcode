namespace Sort
{
    public class BubbleSort : ISort
    {
        public static List<int> Sort(List<int> items)
        {
            int n = items.Count();
            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = 1; j < n; ++j)
                {
                    if (items[j-1] > items[j])
                    {
                        //swap
                        int temp = items[j-1];
                        items[j-1] = items[j];
                        items[j] = temp;
                    }
                }
            }
            return items;
        }
    }
}