using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs4_demo_week5_linked_lists
{
    public partial class Form1 : Form
    {
        Player me;
        public Form1()
        {
            InitializeComponent();
            me = new Player("t3rm!nat0r");
            addPlayers();
        }

        private void addPlayers()
        {
            this.listBox1.Items.Add(new Player("P1"));
            this.listBox1.Items.Add(new Player("P2"));
            this.listBox1.Items.Add(new Player("P3"));
            this.listBox1.Items.Add(new Player("P4"));
            this.listBox1.Items.Add(new Player("P5"));
        }

        private void btnPlayWith_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                me.PlayWith((Player)listBox1.SelectedItem);
            }
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(me.PlayerHistory());
        }
    }
}
