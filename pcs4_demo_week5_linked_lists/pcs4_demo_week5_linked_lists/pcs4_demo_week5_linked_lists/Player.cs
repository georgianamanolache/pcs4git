using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcs4_demo_week5_linked_lists
{
    class Player
    {
        public string Name { get; private set; }
        private PlayerList playedWith;

        public Player(string name)
        {
            Name = name;
            playedWith = new PlayerList();
        }

        public void PlayWith(Player other)
        {
            playedWith.Add(other);
        }

        public string PlayerHistory()
        {
            return $"{Name} played with: {playedWith.ToString()}";
        }

        public override string ToString()
        {
            return $"Player {Name}";
        }
    }
}
