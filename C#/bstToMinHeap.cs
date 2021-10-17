// C# implementation to convert the given
// BST to Min Heap
using System;
using System.Collections.Generic;
public class GFG
{

// structure of a node of BST
public

class Node
{
	public
int data;
	public
Node left, right;
};

/* Helper function that allocates a new node
with the given data and null left and right
pointers. */
static Node getNode(int data)
{
	Node newNode = new Node();
	newNode.data = data;
	newNode.left = newNode.right = null;
	return newNode;
}

// function prototype for preorder traversal
// of the given tree

// function for the inorder traversal of the tree
// so as to store the node values in 'arr' in
// sorted order
static void inorderTraversal(Node root)
{
	if (root == null)
		return;

	// first recur on left subtree
	inorderTraversal(root.left);

	// then copy the data of the node
	arr.Add(root.data);

	// now recur for right subtree
	inorderTraversal(root.right);
}

// function to convert the given BST to MIN HEAP
// performs preorder traversal of the tree
static void BSTToMinHeap(Node root)
{
	if (root == null)
		return;

	// first copy data at index 'i' of 'arr' to
	// the node
	root.data = arr[++i];

	// then recur on left subtree
	BSTToMinHeap(root.left);

	// now recur on right subtree
	BSTToMinHeap(root.right);
}
static List<int> arr = new List<int>();
static int i;

// utility function to convert the given BST to
// MIN HEAP
static void convertToMinHeapUtil(Node root)
{

	// vector to store the data of all the
	// nodes of the BST
	i = -1;

	// inorder traversal to populate 'arr'
	inorderTraversal(root);

	// BST to MIN HEAP conversion
	BSTToMinHeap(root);
}

// function for the preorder traversal of the tree
static void preorderTraversal(Node root)
{
	if (root == null)
		return;

	// first print the root's data
	Console.Write(root.data + " ");

	// then recur on left subtree
	preorderTraversal(root.left);

	// now recur on right subtree
	preorderTraversal(root.right);
}

// Driver program to test above
public static void Main(String[] args)
{

	// BST formation
	Node root = getNode(4);
	root.left = getNode(2);
	root.right = getNode(6);
	root.left.left = getNode(1);
	root.left.right = getNode(3);
	root.right.left = getNode(5);
	root.right.right = getNode(7);

	convertToMinHeapUtil(root);
	Console.Write("Preorder Traversal:" +"\n");
	preorderTraversal(root);
}
}

// This code contributed by Rajput-Ji
