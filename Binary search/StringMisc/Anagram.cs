namespace Binary_search.StringMisc
{
    public static class Anagram
    {
        public static bool CheckIfStringsAreAnagram(string one, string two)
        {
            if (one.Length != two.Length)
            {
                return false;
            }

            var asArrayFirst = one.ToArray();
            Array.Sort(asArrayFirst);

            var asArraySecond = two.ToArray();
            Array.Sort(asArraySecond);

            for (int i = 0; i < asArrayFirst.Length; i++)
            {
                if (asArrayFirst[i] != asArraySecond[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
