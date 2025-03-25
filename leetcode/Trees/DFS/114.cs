namespace leetcode.Trees.DFS;
public class _114
{
    public void Flatten(TreeNode? root)
    {
        if (root == null) return;
        var newTree = new TreeNode(0);
        Traverse(root, newTree);
        root = newTree.right;
    }

    private TreeNode Traverse(TreeNode? original, TreeNode dest)
    {
        if (original == null) return dest;
        dest.right = new TreeNode(original.val);
        if (original.left != null)
            dest = Traverse(original.left, dest.right);
        if (original.right != null)
            dest = Traverse(original.right, dest.right);
        return dest;
    }
}
