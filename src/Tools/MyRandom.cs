using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SparseMatrices.Tools
{
   
    /// <summary>
    /// Extends System.Random class functionality with methods returning random number according to probability
    /// </summary>
    class MyRandom : Random
    {

        public MyRandom()
        {
        }

        /// <summary>
        /// Randomly returns 0 or 1
        /// </summary>
        /// <returns>0 or 1</returns>
        public int getBinary()
        {
            return Next(2);
        }

        /// <summary>
        /// Randomly returns: <list type="bullet"> <item>zero with <c>zeroProb</c> probability </item>
        /// <item>one with 1 - <c>zeroProb</c> probability </item>
        /// </list>
        /// </summary>
        /// <param name="zeroProb">Probability of returning zero (range - from 0 to 1)</param>
        /// <returns>1 or 0</returns>
        public int getBinary(double zeroProb)
        {
            double rand = NextDouble();
            if (rand < zeroProb)
                return 0;
            else
                return 1;
        }
    }
}
