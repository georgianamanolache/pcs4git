using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcs4_demo_week5_linked_lists
{
    class PlayerNode
    {
        public PlayerNode Next { get; set; }
        public Player Value { get; private set; }
    

        public PlayerNode(Player value)
        {
            Value = value;
        }

        public void Add(Player value)
        {
          if (Next != null)
            {
                Next.Add(value);
            }
            else
            {
                Next = new PlayerNode(value);
            }
        }

        public override string ToString()
        {
            string returner = $" {Value.Name}";
            if (Next != null)
            {
                returner += ", " + Next.ToString();
            }
            return returner;
        }
    }


}
