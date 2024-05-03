using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private int currentValue;
        private static Random random = new Random(); // Static field to make sure only one Random object is created at a
        //  timeand used across all Die instances.

        public int CurrentValue
        {
            get { return currentValue; }
        }

        public int Roll()
        {
            currentValue = random.Next(1, 7);
            return currentValue;
        }
    }
}