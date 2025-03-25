namespace leetcode.Trees.DFS;

/// <summary>
/// https://leetcode.com/problems/binary-tree-inorder-traversal/
/// </summary>
public class _94
{
    public IList<int> InorderTraversal(TreeNode? root)
    {
        var list = new List<int>();
        Traverse(root, list);
        return list;
    }

    private void Traverse(TreeNode? root, IList<int> list)
    {
        if (root == null) return;
        Traverse(root.left, list);
        list.Add(root.val);
        Traverse(root.right, list);
    }
}
