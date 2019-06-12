using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs4_demo_week6_binary_tree
{
    public partial class Form1 : Form
    {
        private BinaryTree tree;

        public Form1()
        {
            InitializeComponent();
            this.createBinaryTree();
        }

        public void createBinaryTree()
        {
            this.tree = new BinaryTree();
            /** Add TreeNodes:
                             a
                            / \
                           b   c
                          /   / \
                         d   e   f
                        / \
                       g   h
            **/
            TreeNode nodeA = new TreeNode("a");
            TreeNode nodeB = new TreeNode("b");
            TreeNode nodeC = new TreeNode("c");
            TreeNode nodeD = new TreeNode("d");
            TreeNode nodeG = new TreeNode("g");
            TreeNode nodeH = new TreeNode("h");
            TreeNode nodeE = new TreeNode("e");
            TreeNode nodeF = new TreeNode("f");

            this.tree.Root = nodeA;

            nodeA.LeftTree = nodeB;
            nodeA.RightTree = nodeC;

            nodeB.LeftTree = nodeD;

            nodeC.LeftTree = nodeE;
            nodeC.RightTree = nodeF;

            nodeD.LeftTree = nodeG;
            nodeD.RightTree = nodeH;
        }

        private void btnPreorder_Click(object sender, EventArgs e)
        {
            lblResult.Text = this.tree.TraversalPreorder();
        }

        private void btnInorder_Click(object sender, EventArgs e)
        {

        }

        private void btnPostorder_Click(object sender, EventArgs e)
        {

        }
    }
}
