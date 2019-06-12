using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcs4_demo_week6_binary_tree
{
    class TreeNode
    {
        public string Value { get; private set; }
        public TreeNode LeftTree { get; set; }
        public TreeNode RightTree { get; set; }
        public TreeNode(string value)
        {
            this.Value = value;
            this.LeftTree = null;
            this.RightTree = null;
        }
    }
}
