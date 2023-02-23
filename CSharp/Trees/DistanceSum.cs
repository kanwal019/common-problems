using System;
using System.Collections.Generic;

namespace CSharp.Trees;

public class DistanceSum
{ 
    public static void DisplayResult()
    {
        int count = Convert.ToInt32(Console.ReadLine());
        List<int> binaryTreeList = new();

        for(int i = 0; i < count; i++)
        {
            var line = Console.ReadLine().Trim().Split(' ');
            for(int j = 0; j < line.Length; j++)
            {
                binaryTreeList.Add(Convert.ToInt32(line[j].Trim()));
            }
        }

        Tree binaryTree = new();
        binaryTree.Root = binaryTree.InsertLevelOrder(binaryTreeList, binaryTree.Root, 0);
        // binaryTree.InOrder(binaryTree.Root);

        Tree.Result = 0;
        Tree.DepthFirstSearch(binaryTree.Root, 4);
        Console.WriteLine(Tree.Result);
    }
}

public class Tree
{
    public Node Root;
    public static int Result;

    public class Node
    {
        public int Data;
        public Node Left, Right;

        public Node(int data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }
    }

    public Node InsertLevelOrder(List<int> list, Node root, int i)
    {
        if (i < list.Count && list[i] != -1)
        {
            root = new Node(list[i]);
            root.Left = InsertLevelOrder(list, root.Left, 2 * i + 1);
            root.Right = InsertLevelOrder(list, root.Right, 2 * i + 2);
        }
        return root;
    }

    public void InOrder(Node root)
    {
        if (root != null)
        {
            InOrder(root.Left);
            Console.Write(root.Data + " ");
            InOrder(root.Right);
        }
    }

    public static int[] DepthFirstSearch(Node root, int distance)
    {
        int[] res;
        if (root == null) 
        {
            return new int[distance + 1];
        }
            
        if (root.Left == null && root.Right == null)
        {
            res = new int[distance + 1];
            res[1]++;
            return res;
        }

        int[] left = DepthFirstSearch(root.Left, distance);
        int[] right = DepthFirstSearch(root.Right, distance);
        res = new int[distance + 1];

        for (int i = res.Length - 2; i >= 1; i--)
        {
            res[i + 1] = left[i] + right[i];
        }

        for (int l = 0; l < left.Length; l++)
        {
            for (int r = 0; r < right.Length; r++)
            {
                if (l + r <= distance)
                {
                    Result += left[l] * right[r];
                }
            }
        }

        return res;
    }
}
