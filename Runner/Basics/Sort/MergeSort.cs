namespace Sort
{
    public class MergeSort : ISort
    {
        public static List<int> Sort(List<int> items)
        {
            MergeSortHelper(ref items, 0, items.Count()-1);
            return items;
        }

        public static void MergeSortHelper(ref List<int> items, int l, int r)
        {
            if (l < r)
            {
                // find the mid
                int m = l + (r-l)/2;
                
                // sort first and second halves
                MergeSortHelper(ref items, l, m);
                MergeSortHelper(ref items, m+1, r);
                Merge(ref items, l, m, r);
            }

        }
        
        public static void Merge(ref List<int> items, int l, int m, int r)
        {  
            //  0  1    2  3
            //  l  m       r
            // [1, 2], [3, 4]
            // Find sizes of two subarrays
            int n1 = m - l + 1; // 2
            int n2 = r - m; // 2

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;
            
            for (i = 0; i < n1; ++i)
            {
                L[i] = items[l+i];
            }
            for (j = 0; j < n2; ++j)
            {
                R[j] = items[m+1+j];
            }

            // merge the temp arrays
            // initial indices of first and second subarrays
            i = 0;
            j = 0;

            // initial index of merge subarray array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    items[k] = L[i];
                    i++;
                }
                else
                {
                    items[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            while (i < n1)
            {
                items[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                items[k] = R[j];
                j++;
                k++;
            }
        }
    }
}