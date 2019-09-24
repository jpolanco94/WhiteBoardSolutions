using Microsoft.VisualStudio.TestTools.UnitTesting;
using SubstringInString;

namespace SubstringInStringTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EasyTest()
        {
            Assert.AreEqual(2, SubstringInString.Program.FindIndexOfSubstring("ssssxssss", "sxss"));
        }
    }
}
