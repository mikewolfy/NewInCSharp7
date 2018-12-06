using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace WhatsNewInCSharp7
{
    public class InKeywordForParameter
    {
        [Fact]
        public void TestInKeyword()
        {
            var i = "test";
            var x = "test";
            TestClass.ChangeParm(i);
            Assert.Equal(i, x);
        }

        private static class TestClass
        {
            public static void ChangeParm(in string parm1)
            {
                //can't be change
            }
        }
    }
}
