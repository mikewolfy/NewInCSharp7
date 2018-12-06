using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace WhatsNewInCSharp7
{

    public class NullCheck
    {
        [Fact]
        public void TestNullable()
        {
            string test = null;
            var result = test ?? "default";
            Assert.Equal("default", result);
        }
    }
}
