using Binary_search.Entities;

namespace Binary_search.Trees.Binary
{
    public static class TraverseInOrderToArrayOfArrays
    {
        public static List<List<int>> GetListFromTraverseInOrder(BinaryTreeNode root)
        {
            List<List<int>> levels = new();

            Queue<BinaryTreeNode> queue = new();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                List<int> level = new();
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    var current = queue.Dequeue();

                    if (current.Left is not null)
                    {
                        queue.Enqueue(current.Left);
                    }

                    if (current.Right is not null)
                    {
                        queue.Enqueue(current.Right);
                    }

                    level.Add(current.Value);
                }

                levels.Add(level);
            }

            return levels;
        }
    }
}
