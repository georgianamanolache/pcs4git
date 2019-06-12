using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_jan_2019_practice
{
    public partial class Form1 : Form
    {
        List<Bag> damaged;
        List<Bag> notDamaged;

        List<Bag> bags = new List<Bag>{
            new Bag(0.5, true, "Gucci"), new Bag(1.0, false, "DG"),
            new Bag(0.6, true, "DG"), new Bag(0.2, false, "DG"),
            new Bag(1.9, true, "gucci"), new Bag(0.7, false, "Versace"),
            new Bag(0.78, true, "Versace"), new Bag(0.21, false, "Gucci")
        };

        public Form1()
        {
            InitializeComponent();
            showInfoInList();

            damaged = new List<Bag>();
            notDamaged = new List<Bag>();
        }

        private void showInfoInList()
        {
            string row = "";
            foreach(Bag b in bags)
            { 
                row += b.ToString() + ", ";
            }

            this.listBox1.Items.Add(row);
        }

        private void btnSortWeight_Click(object sender, EventArgs e)
        {
            SortByWeight();
            showInfoInList();
        }

        public void SortByWeight()
        {
            Bag[] arr = bags.ToArray();

            int  smallest, n = bags.Count;
            Bag temp;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j].Weight < arr[smallest].Weight)
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest]= arr[i];
                arr[i] = temp;
            }

            bags = new List<Bag>();
            foreach(Bag b in arr)
            {
                bags.Add(b);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bags.Sort();
            showInfoInList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortByIsDamagedTheme();
        }


        private void SortByIsDamagedTheme()
        {
            for (int i = 0; i < bags.Count; i++)
            {
                if (bags[i].IsDamaged)
                {
                    damaged.Add(bags[i]);
                }
                else
                {
                    notDamaged.Add(bags[i]);
                }
            }

            bags = new List<Bag>();
            bags = SortByTheme(damaged);
            foreach (Bag b in SortByTheme(notDamaged))
            {
                bags.Add(b);
            }

            showInfoInList();
        }

        private List<Bag> SortByTheme(List<Bag> damagedOrNotDamaged)
        {
            Bag[] arr = damagedOrNotDamaged.ToArray();

            int smallest, n = damagedOrNotDamaged.Count;
            Bag temp;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    int x = String.Compare(arr[j].Theme, arr[smallest].Theme);
                    if(x == -1)
                        smallest = j;
                    
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }

            List<Bag> l = new List<Bag>();
            foreach (Bag b in arr)
            {
                l.Add(b);
            }

            return l;

        }
    }
}
