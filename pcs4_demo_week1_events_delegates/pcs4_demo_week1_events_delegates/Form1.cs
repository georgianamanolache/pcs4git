using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs4_demo_week1_events_delegates
{
    public partial class Form1 : Form
    {
        Race race = new Race();

        public Form1()
        {
            InitializeComponent();
            this.race.DoneRace += new Race.DoneRaceHandler(RaceOver_Event);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled=true;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + 10 > groupBox2.Width - pictureBox1.Width)
            {
                this.timer1.Dispose();
                this.timer1.Enabled = false;
                this.timer1.Stop();
                race.CheckWinner("Player 1");                          
            }
            else
            {
                this.pictureBox1.Left += 10;
                this.pictureBox2.Left += 9;
            }            
        }

        private void RaceOver_Event(string winner)
        {
            MessageBox.Show(winner);
        }
       
    }
}
