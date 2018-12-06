using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace WhatsNewInCSharp7
{
    public class Tuples
    {
        [Fact]
        public void TestTuples()
        {
            int x = 1, y = 2, z = 2;
            var tuple = ReturnTuple(x, y, z);
            Assert.Equal(x, tuple.Item1);
            Assert.Equal(y, tuple.Item2);
            Assert.Equal(z, tuple.Item3);
        }

        private Tuple<int, int, int> ReturnTuple(int x, int y, int z)
        {
            return new Tuple<int, int, int>(x, y, z);
        }
    }
}
