namespace Binary_search
{
    public static class BinarySearch
    {
        public static int SearchForElementIndex(int[] array, int searchFor)
        {
            int left = 0, right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == searchFor)
                {
                    return mid;
                }

                if (array[mid] < searchFor)
                {
                    left = mid + 1;
                }

                if (array[mid] > searchFor)
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
