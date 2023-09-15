namespace Algorithms;

public class SimpleBinaryTree<T> where T : IComparable<T>
{
    private SimpleBinaryTree<T>? _left;
    private SimpleBinaryTree<T>? _right;
    private SimpleBinaryTree<T>? _parent;
    private T Value { get; set; }

    public SimpleBinaryTree(T value, SimpleBinaryTree<T>? parent)
    {
        Value = value;
        _parent = parent;
    }

    public static void Print(SimpleBinaryTree<int>? treeNode)
    {
        while (true)
        {
            if (treeNode == null) return;
            Print(treeNode._left);
            Console.Write(treeNode.Value + " ");
            if (treeNode._right != null)
            {
                treeNode = treeNode._right;
                continue;
            }
            break;
        }
    }

    public SimpleBinaryTree<T> Add(T val)
    {
        if (val.CompareTo(Value) < 0)
        {
            if (_left is null)
            {
                _left = new SimpleBinaryTree<T>(val, this);
            }
            else
            {
                _left.Add(val);
            }
        }
        else
        {
            if (_right is null)
            {
                _right = new SimpleBinaryTree<T>(val, this);
            }
            else
            {
                _right.Add(val);
            }
        }
        return this;
    }
}

public static class TestNode
{
    public static void Main()
    {
        var head = new SimpleBinaryTree<int>(10, null);
        head.Add(5).Add(7).Add(1).Add(4).Add(13).Add(12).Add(11);
        SimpleBinaryTree<int>.Print(head);
    }
}