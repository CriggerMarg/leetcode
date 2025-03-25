using System.Diagnostics;

namespace leetcode;
[DebuggerDisplay("val = {val}")]
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
	public int val = val;
	public TreeNode? left = left;
	public TreeNode? right = right;


}

[DebuggerDisplay("{val}; next is null: {next == null}")]
public class ListNode(int val = 0, ListNode? next = null)
{
	public int val = val;
	public ListNode? next = next;
}

[DebuggerDisplay("val = {val}, next is null: {next == null}")]
public class Node
{
	public int val;
	public Node? left;
	public Node? right;
	public Node? next;

	public Node() { }

	public Node(int _val)
	{
		val = _val;
	}

	public Node(int _val, Node _left, Node _right, Node _next)
	{
		val = _val;
		left = _left;
		right = _right;
		next = _next;
	}
}

public class GraphNode
{
	public int val;
	public IList<GraphNode> neighbors = [];

	public GraphNode(int _val)
	{
		val = _val;
	}

	public GraphNode(int _val, List<GraphNode> _neighbors)
	{
		val = _val;
		neighbors = _neighbors;
	}
}