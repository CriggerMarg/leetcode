namespace leetcode.BST;
public class _270
{
	int _val = int.MaxValue;
	double _diff = int.MaxValue;
	public int ClosestValue(TreeNode? root, double target)
	{
		Traverse(root, target);
		return _val;
	}

	private void Traverse(TreeNode? root, double target)
	{
		if (root == null) return;

		var diff = Math.Abs(root.val - target);
		if (diff <= _diff)
		{
			if (diff < _diff) _val = root.val;
			else _val = Math.Min(_val, root.val);
			_diff = diff;
		}
		Traverse(root.left, target);
		Traverse(root.right, target);
	}
}
