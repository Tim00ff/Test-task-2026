
class Program
{
    public class TreeNode
    {
        public int Value;
        public TreeNode? Left;
        public TreeNode? Right;

        //Для проверки кода себе
        public TreeNode(int value, TreeNode? left = null, TreeNode? right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    static void Main()
    {
        TreeNode tree1 = new TreeNode(1,
            new TreeNode(2),
            new TreeNode(3));

        TreeNode tree2 = new TreeNode(1,
            new TreeNode(2),
            new TreeNode(3));

        Console.WriteLine($"Два одинаковых дерева: {IsSameTree(tree1, tree2)}"); // True

        TreeNode tree3 = new TreeNode(1,
            new TreeNode(2),
            null);

        TreeNode tree4 = new TreeNode(1,
            null,
            new TreeNode(2));

        Console.WriteLine($"Два одинаковых дерева: {IsSameTree(tree3, tree4)}"); // False

        TreeNode tree5 = new TreeNode(1,
            new TreeNode(2),
            new TreeNode(3));

        TreeNode tree6 = new TreeNode(1,
            new TreeNode(4),
            new TreeNode(3));

        Console.WriteLine($"Два разных дерева: {IsSameTree(tree5, tree6)}");
        Console.WriteLine($"Два пустых дерева: {IsSameTree(null, null)}");
    }

    static bool IsSameTree(TreeNode? first, TreeNode? second)
    {
        if (first == null && second == null)
            return true;

        if (first == null || second == null)
            return false;

        return first.Value == second.Value &&
               IsSameTree(first.Left, second.Left) &&
               IsSameTree(first.Right, second.Right);
    }
}