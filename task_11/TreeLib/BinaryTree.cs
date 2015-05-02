using System;
using System.Collections.Generic;

namespace TreeLib 
{ 
    public class BinaryTree<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private class BinaryTreeNode<TNode> : IComparable
        where TNode : IComparable<TNode>
        {
            public BinaryTreeNode(TNode value)
            {
                Value = value;
            }

            public TNode Value { get; private set; }

            public BinaryTreeNode<TNode> Left { get; set; }
            public BinaryTreeNode<TNode> Right { get; set; }

            public int CompareTo(object obj)
            {
                if (!(obj is BinaryTreeNode<TNode>))
                    throw new ArgumentException();

                BinaryTreeNode<TNode> otherNode = (BinaryTreeNode<TNode>)obj;
                return Value.CompareTo(otherNode.Value);
            }
        }

        BinaryTreeNode<T> _head;

        public void Add(T value)
        {
            if (_head == null)
                _head = new BinaryTreeNode<T>(value);
            else
                AddTo(_head, value);
        }

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            bool isDone = false;

            while (!isDone)
            {
                if (value.CompareTo(node.Value) < 0)
                {
                    if (node.Left == null)
                    {
                        node.Left = new BinaryTreeNode<T>(value);
                        isDone = true;
                    }
                    else
                        node = node.Left;
                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = new BinaryTreeNode<T>(value);
                        isDone = true;
                    }
                    else
                        node = node.Right;
                }
            }
        }

        public bool Remove(T value)
        {
            BinaryTreeNode<T> current;
            BinaryTreeNode<T> parent;

            current = FindWithParent(value, out parent);

            if (current == null)
                return false;

            if (current.Right == null)
            {
                if (parent == null)
                    _head = current.Left;
                else
                {
                    int result = parent.CompareTo(current.Value);

                    if (result > 0)
                        parent.Left = current.Left;
                    else if (result < 0)
                        parent.Right = current.Left;
                }
            }
            else if(current.Right.Left == null)
            {
                current.Right.Left = current.Left;

                if (parent == null)
                    _head = current.Right;
                else
                {
                    int result = parent.CompareTo(current.Value);

                    if (result > 0)
                        parent.Left = current.Right;

                }
            }
            else
            {
                BinaryTreeNode<T> leftmost = current.Right.Left;
                BinaryTreeNode<T> leftmostParent = current.Right;

                while (leftmost.Left == null)
                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.Left;
                }

                leftmostParent.Left = leftmost.Right;

                leftmost.Left = current.Left;
                leftmost.Right = current.Right;

                if (parent == null)
                    _head = leftmost;
                else
                {
                    int result = parent.CompareTo(current.Value);

                    if (result > 0)
                        parent.Left = leftmost;
                    else if (result < 0)
                        parent.Right = leftmost;    
                }
            }

            return true;
        }

        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> current = _head;
            parent = null;

            while (current != null)
            {
                int result = current.CompareTo(value);

                if (result > 0)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                    break;
            }
            return current;
        }

        public IEnumerable<T> GetNodeValues()
        {
            if (_head == null)
                yield break;

            Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
            BinaryTreeNode<T> current = _head;

            bool goLeftNext = true;

            stack.Push(current);

            while (stack.Count > 0)
            {
                if (goLeftNext)
                {
                    while (current.Left != null)
                    {
                        stack.Push(current);
                        current = current.Left;
                    }
                }

                yield return current.Value;

                if (current.Right != null)
                {
                    current = current.Right;
                    goLeftNext = true;
                }
                else
                {
                    current = stack.Pop();
                    goLeftNext = false;
                }
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            return GetNodeValues().GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
