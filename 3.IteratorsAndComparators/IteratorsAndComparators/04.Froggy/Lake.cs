﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private readonly IList<int> stones;

        public Lake( IEnumerable<int> stones)
        {
            this.stones = new List<int>(stones);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i+=2)
            {
                yield return this.stones[i];
            }

            int lastOddIndex = this.stones.Count - 1;

            if (lastOddIndex %2 ==0)
            {
                lastOddIndex--;
            }
            for (int i = lastOddIndex; i > 0; i-=2)
            {          
                   yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
