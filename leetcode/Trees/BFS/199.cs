namespace leetcode.Trees.BFS;
public class _199
{
    public IList<int> RightSideView(TreeNode? root)
    {
        if (root == null) return [];

        List<int> ans = [];
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            int len = q.Count;
            int prev = 0;
            for (int i = 0; i < len; i++)
            {
                TreeNode node = q.Dequeue();
                prev = node.val;
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            ans.Add(prev);
        }
        return ans;
    }

}
