using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace battleship_game
{
    class CheckForCollision
    {
        public List<int> CheckUp (List<int> x, List<int> y)
        {
            for (int i = 0; i < y.Count(); i++)
            {
                if (y[i] > 1)
                {
                    y[i]--;
                    return y;
                }
            }
            return y;
        }

        public List<int> CheckDown (List<int> x, List<int> y)
        {
            for (int i = 0; i < y.Count(); i++)
            {
                if (y[i] > 1)
                {
                    y[i]++;
                    return y;
                }
            }
            return y;
        }
    }
}
