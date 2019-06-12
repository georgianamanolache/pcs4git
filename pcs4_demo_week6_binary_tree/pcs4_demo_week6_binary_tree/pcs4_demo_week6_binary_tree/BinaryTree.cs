using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcs4_demo_week6_binary_tree
{
    class BinaryTree
    {
        public TreeNode Root { get; set; }
        public BinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// 1. Start with the root
        /// 2. Order the left subtree in preorder
        /// 3. Order the right subtree in preorder
        /// </summary>
        /// <returns>The tree node values in preorder</returns>
        public string TraversalPreorder()
        {
            return "None";
        }

        /// <summary>
        /// 1. Order the left subtree in inorder
        /// 2. Process the root
        /// 3. Order the right subtree in inorder
        /// </summary>
        /// <returns>The tree node values in Inorder</returns>
        public string TraversalInorder()
        {
            return "None";
        }

        /// <summary>
        /// 1. Order the left subtree in postorder
        /// 2. Order the right subtree in postorder
        /// 3. Process the root
        /// </summary>
        /// <returns>The tree node values in postorder</returns>
        public string TraversalPostorder()
        {
            return "None";
        }
    }
}
