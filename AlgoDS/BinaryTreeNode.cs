﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDS
{
    class BinaryTreeNode<TNode> : IComparable<TNode>
         where TNode : IComparable<TNode>
    {
        public TNode Value { get; private set; }
        public BinaryTreeNode<TNode> Left { get; set; }
        public BinaryTreeNode<TNode> Right { get; set; }

        public BinaryTreeNode(TNode value)
        {
            Value = value;
        }

        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }
    }
}
