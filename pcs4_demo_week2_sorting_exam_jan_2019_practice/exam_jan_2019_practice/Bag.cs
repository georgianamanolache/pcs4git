using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_jan_2019_practice
{
    class Bag: IComparable<Bag> 
    {
        public double Weight { get; private set; }
        public bool IsDamaged { get; private set; }
        public string Theme { get; private set; }

        public Bag(double weight, bool isDamaged, string theme)
        {
            this.Weight = weight;
            this.IsDamaged = isDamaged;
            this.Theme = theme;
        }

        public int CompareTo(Bag other)
        {
            if(other.Weight > Weight)
            {
                return -1;
            }
            else if (other.Weight < Weight)
            {
                return 1;
            }
            return 0;
        }
       
        public override string ToString()
        {
            return Weight.ToString() + " "+ Theme + " " + IsDamaged.ToString();
        }
    }
}
