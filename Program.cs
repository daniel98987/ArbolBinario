using BinaryTree.BinaryTree;

int[] inputs = { 70,84,85, 70,84,78,80, 70,84,78,76,70,49,54,51,70,49,37,40,70,49,37,22 };


BinaryTreeHandler tree = new BinaryTreeHandler(inputs[0]);

for (int i = 1; i < inputs.Length; i++)
{
    tree.Insert(inputs[i]);
}

tree.InOrder(tree.Root);

Node lca1 = tree.FindAncestor(tree.Root, 40, 78);
Console.WriteLine("Ancestro (40,78) = " + lca1.Value);

Node lca2 = tree.FindAncestor(tree.Root, 51, 37);
Console.WriteLine("Ancestro (51,37) = " + lca2.Value);

Node lca3 = tree.FindAncestor(tree.Root, 76, 85);
Console.WriteLine("Ancestro (76,85 = " + lca3.Value);
