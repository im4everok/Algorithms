using Binary_search.Entities;

namespace Binary_search.Trees.Binary
{
    public static class BreadthFirstToList
    {
        public static List<int> GetTreeAsListBreadthFirst(BinaryTreeNode root)
        {
            Queue<int> result = new();

            Queue<BinaryTreeNode> nodes = new();
            nodes.Enqueue(root);

            while(nodes.Count > 0)
            {
                var current = nodes.Dequeue();

                if(current.Left is not null)
                {
                    nodes.Enqueue(current.Left);
                }

                if(current.Right is not null)
                {
                    nodes.Enqueue(current.Right);
                }

                result.Enqueue(current.Value);
            }

            return result.ToList();
        }
    }
}
