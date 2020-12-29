using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Trees
{
    public class EqualTrees
    {
        public class BinaryTree
        {
            public Node root1, root2;
        }

        public static void DisplayResult()
        {
            BinaryTree tree1 = new BinaryTree();
            tree1.root1 = new Node(1);
            tree1.root1.left = new Node(2);
            tree1.root1.right = new Node(3);
            tree1.root1.left.left = new Node(4);
            tree1.root1.left.right = new Node(5);
            tree1.root2 = new Node(1);
            tree1.root2.left = new Node(2);
            tree1.root2.right = new Node(3);
            tree1.root2.left.left = new Node(4);
            tree1.root2.left.right = new Node(5);

            BinaryTree tree2 = new BinaryTree();
            tree2.root1 = new Node(1);
            tree2.root1.left = new Node(2);
            tree2.root1.right = new Node(3);
            tree2.root1.left.left = new Node(4);
            tree2.root1.left.right = new Node(5);
            tree2.root2 = new Node(1);
            tree2.root2.left = new Node(2);
            tree2.root2.right = new Node(3);
            tree2.root2.left.left = new Node(4);
            tree2.root2.left.right = new Node(6);

            BinaryTree tree3 = new BinaryTree();
            tree3.root1 = new Node(1);
            tree3.root1.left = new Node(2);
            tree3.root1.right = new Node(3);
            tree3.root1.left.left = new Node(4);
            tree3.root1.left.right = new Node(5);
            tree3.root1.right.left = new Node(6);
            tree3.root1.right.right = new Node(7);
            tree3.root2 = new Node(1);
            tree3.root2.left = new Node(2);
            tree3.root2.right = new Node(3);
            tree3.root2.left.left = new Node(4);
            tree3.root2.left.right = new Node(6);

            if (IsIdentical(tree1.root1, tree1.root2))
            {
                Console.WriteLine("Boot roots are identical for Tree 1");
            }
            else
            {
                Console.WriteLine("Boot roots are not identical for Tree 1");
            }

            if (IsIdentical(tree2.root1, tree2.root2))
            {
                Console.WriteLine("Boot roots are identical for Tree 2");
            }
            else
            {
                Console.WriteLine("Boot roots are not identical for Tree 2");
            }

            if (IsIdentical(tree3.root1, tree3.root2))
            {
                Console.WriteLine("Boot roots are identical for Tree 3");
            }
            else
            {
                Console.WriteLine("Boot roots are not identical for Tree 3");
            }
        }

        public static bool IsIdentical(Node i, Node j)
        {
            if(i==null && j == null)
            {
                return true;
            }

            if (i != null && j != null)
            {
                if(i.data == j.data)
                {
                    return IsIdentical(i.left, j.left) && IsIdentical(i.right, j.right);
                }
            }

            return false;
        }
    }
}
