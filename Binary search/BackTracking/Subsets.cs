namespace Binary_search.BackTracking
{
    public static class Subsets
    {
        public static void GenerateSubsets(int[] initialArray, List<List<int>> allSubsets,
                int index, List<int> currentSubset)
        {
            if (index == initialArray.Length)
            {
                allSubsets.Add(new List<int>(currentSubset));
                return;
            }

            currentSubset.Add(initialArray[index]);
            GenerateSubsets(initialArray, allSubsets, index + 1, currentSubset);

            currentSubset.RemoveAt(currentSubset.Count - 1);
            GenerateSubsets(initialArray, allSubsets, index + 1, currentSubset);
        }

        public static List<List<int>> AllSubsets(int[] arr)
        {
            List<List<int>> result = new();

            List<int> currentSubset = new();

            GenerateSubsets(arr, result, 0, currentSubset);

            return result;
        }
    }
}
