﻿namespace leetcode.BST;
public class _701
{
	public TreeNode InsertIntoBST(TreeNode? root, int val)
	{
		if (root == null) return new TreeNode(val);
		if (root.val < val)
		{
			root.left = InsertIntoBST(root.left, val);
		}
		else
		{
			root.right = InsertIntoBST(root.right, val);
		}
		return root;
	}
}
