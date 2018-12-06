using System;
using Xunit;

namespace WhatsNewInCSharp7
{
    public class MixOfNamedAndUnnamedParameters
    {
        [Fact]
        public void Test1()
        {
            // named parameters can now be a mix of named and unnamed
            TestMethod("test", parm2: "test2", parm3: "test3");
            TestMethod("test", parm3: "test3");
        }

        private void TestMethod(string parm1 = "one", string parm2 = "two", string parm3="three")
        { }
    }
}
