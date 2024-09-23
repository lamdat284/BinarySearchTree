using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BianrySearchTree
{
    public class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            Value = value;        
        }

        public Node Add(Node root, int value)
        {
            if (root == null)
            {
                return new Node(value);
            }

            if (value < root.Value)
            {
                root.Left = Add(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = Add(root.Right, value);
            }

            return root;
        }

    }

}
