using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcs4_demo_week1_events_delegates
{
    class Race
    {
        // First define delegate
        public delegate void DoneRaceHandler(string winner);
        // Second, define event
        public event DoneRaceHandler DoneRace;

        public void CheckWinner(string winner)
        {
            //hfudhjgjdrrhdg

            if (DoneRace != null)
                DoneRace(winner);
        }
    }
}
