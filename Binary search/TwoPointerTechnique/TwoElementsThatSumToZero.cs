namespace Binary_search.TwoPointerTechnique
{
    public static class TwoElementsThatSumToZero
    {
        public static (int, int) GetIndecesOfElementsThatSumsToZero(int[] array)
        {
            int left = 0, right = array.Length - 1;

            while (left < right)
            {
                int sum = array[left] + array[right];

                if (sum == 0)
                {
                    return new(left, right);
                }

                if (sum < 0)
                {
                    left++;
                }

                if (sum > 0)
                {
                    right--;
                }
            }

            return new(-1, -1);
        }
    }
}
