using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RR_Game_Gurmukh.Classes;

namespace UnitTestProject_Gurmukh
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            gamePlay gm = new gamePlay();
            var myNum = gm.RndNumber();
            if (myNum > 1)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        
    }
}
