using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BianrySearchTree
{
    public class BST
    {
        public Node Root;

        public BST()
        {
            Root = null;
        }

        /// <summary>
        /// Thêm một node
        /// </summary>
        /// <param name="value"></param>
        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value); // Nếu cây rỗng, giá trị mới sẽ là gốc
            }
            else
            {
                Root.Add(Root, value); // Gọi phương thức Add của lớp Node để thêm giá trị vào cây
            }
        }

        // Thêm node vào BST
        //public void Insert(int value)
        //{
        //    //Root = InsertRec(Root, value);
        //    Root = Root.Add(Root, value);
        //}

        //private Node InsertRec(Node root, int value)
        //{
        //    if (root == null)
        //    {
        //        root = new Node(value);
        //        return root;
        //    }

        //    if (value < root.Value)
        //    {
        //        root.Left = InsertRec(root.Left, value);
        //    }
        //    else if (value > root.Value)
        //    {
        //        root.Right = InsertRec(root.Right, value);
        //    }

        //    return root;
        //}

    }

}
