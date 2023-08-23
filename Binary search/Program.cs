using Binary_search;
using Binary_search.BackTracking;
using Binary_search.Entities;
using Binary_search.StringMisc;
using Binary_search.Trees.Binary;
using Binary_search.TwoPointerTechnique;

namespace X
{
    class Program
    {
        static void PrintIntList(List<int> numbers)
        {
            // Join the array elements into a single string with commas as separators
            string result = string.Join(", ", numbers);

            string withLimiters = string.Concat("[", result, "]");
            // Print the result
            Console.WriteLine(withLimiters);
        }

        static void PrintArrayOfArrays(List<List<int>> subsets)
        {
            foreach (var subset in subsets)
            {
                Console.Write("[");
                Console.Write(string.Join(" , ", subset));
                Console.WriteLine("]");
            }
        }

        public static void Main(string[] args)
        {
            int[] forBinarySearch = new[] { 1, 5, 7, 9, 15, 25, 36, 53, 54, 69, 75, 95, 105, 120, 145, 156, 169 };

            var elementIndexByBinary = BinarySearch.SearchForElementIndex(forBinarySearch, 105);

            Console.WriteLine(elementIndexByBinary);
            Console.Write("Element at index: ");

            Console.Write(forBinarySearch[elementIndexByBinary]);
            Console.WriteLine();

         

            int[] twoPointerNums = { -20, -17, -15, -11, -9, 4, 6, 7, 8, 9, 10, 12 };

            var indeces = TwoElementsThatSumToZero.GetIndecesOfElementsThatSumsToZero(twoPointerNums);

            Console.Write("Item 1: ");
            Console.WriteLine(indeces.Item1.ToString());

            Console.Write("Item 2:");
            Console.WriteLine(indeces.Item2.ToString());

            var anagramString = "anagram";
            var anagramString2 = "amgrana";

            

            Console.Write("Is anagram: ");
            Console.WriteLine(Anagram.CheckIfStringsAreAnagram(anagramString, anagramString2));

            var subsetArray = new int[] { 1, 2, 3 };

            var subsets = Subsets.AllSubsets(subsetArray);

            PrintArrayOfArrays(subsets);
            Console.WriteLine("######################");

            BinaryTreeNode treeRoot = new BinaryTreeNode(5);
            treeRoot.Left = new BinaryTreeNode(3);
            treeRoot.Right = new BinaryTreeNode(7);
            treeRoot.Left.Left = new BinaryTreeNode(2);
            treeRoot.Left.Right = new BinaryTreeNode(4);
            treeRoot.Right.Left = new BinaryTreeNode(6);
            treeRoot.Right.Right = new BinaryTreeNode(8);

            PrintArrayOfArrays(TraverseInOrderToArrayOfArrays.GetListFromTraverseInOrder(treeRoot));

            var depthFirstTree = DepthFirstToList.GetTreeAsListDepthFirst(treeRoot);

            Console.Write("depth first");
            PrintIntList(depthFirstTree);

            Console.Write("breadth first");
            var breadthFirstTree = BreadthFirstToList.GetTreeAsListBreadthFirst(treeRoot);
            PrintIntList(breadthFirstTree);
        }
    }
}