using Binary_search.Entities;

namespace Binary_search.Trees.Binary
{
    public static class DepthFirstToList
    {
        public static List<int> GetTreeAsListDepthFirst(BinaryTreeNode root)
        {
            Stack<int> result = new();
            
            Stack<BinaryTreeNode> nodes = new();

            nodes.Push(root);

            while (nodes.Count > 0)
            {
                var current = nodes.Pop();

                if (current.Left is not null)
                {
                    nodes.Push(current.Left);
                }

                if (current.Right is not null)
                {
                    nodes.Push(current.Right);
                }

                result.Push(current.Value);
            }

            return result.ToList();
        }
    }
}
