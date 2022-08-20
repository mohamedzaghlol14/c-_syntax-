using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class indexer
    {

        
        private int[] segments = new int[4];

        public indexer(int seg1, int seg2, int seg3, int seg4)
        {
            segments[0] = seg1;
            segments[1] = seg2;
            segments[2] = seg3;
            segments[3] = seg4;
        }

        public string adress()
        {
            return string.Join(".", this.segments);
        }


        public int this[int index]
        {
            get 
            {
                return segments[index];
            }
            set 
            {
                segments[index] = value;
            } 
        }
        

    }
}
