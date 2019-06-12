using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcs4_demo_week5_linked_lists
{
    class PlayerList
    {
        private PlayerNode root;

        public void Add(Player value)
        {
            if (root == null)
            {
                root = new PlayerNode(value);
            }
            else
            {
                root.Add(value);
            }
        }

        public override string ToString()
        {
            if (root != null)
            {
                return root.ToString();
            }
            return "None";
        }
    }
}
