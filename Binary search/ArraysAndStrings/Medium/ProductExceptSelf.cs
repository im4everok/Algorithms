namespace Binary_search.ArraysAndStrings.Medium
{
    internal static class ProductExceptSelfClass
    {
        public static int[] ProductExceptSelfBrute(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int val = 1;
                for(int j = 0; j < nums.Length; j++)
                {
                    if(i != j)
                    {
                        val *= nums[j];
                    }
                }

                result[i] = val;
            }

            return result;
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            (int toLeft, int toRight)[] lR = new (int toLeft, int toRight)[nums.Length];
            
            for(int i  = 0; i < nums.Length; i++)
            {
                if (i == 0) lR[i].toLeft = 1;
                else
                {
                    lR[i].toLeft = nums[i - 1] * lR[i -1].toLeft;
                }
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length - 1) lR[i].toRight = 1;
                else
                {
                    lR[i].toRight = nums[i+1] * lR[i + 1].toRight;
                }
            }

            for(int i = 0; i < nums.Length; i++)
            {
                result[i] = lR[i].toLeft * lR[i].toRight;
            }

            return result;
        }
    }
}
