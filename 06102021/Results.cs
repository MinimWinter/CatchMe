using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06102021
{
    class Results
    {
        private List<int> values = new List<int>();
        public int BestTime 
        {
            get
            {
                return this.values.Min();
            } 
        }
        
        public int AverageTime 
        {
            get
            {
                return (int) this.values.Average();
            }
        }

        public int LastTime 
        { 
            get
            {
                //return this.values[this.values.Count - 1];
                return this.values.Last();
            }
        
        }

        public void Add(int value)
        {
            this.values.Add(value);
        }
    }
}
