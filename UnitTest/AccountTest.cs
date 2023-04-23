using BUS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class AccountTest
    {
        private AccountBUS trueUser;
        private AccountBUS wrongUser;

        public AccountTest()
        {
            trueUser = new AccountBUS("Test", "123456");
            wrongUser = new AccountBUS("User1", "123456");
        }

        [TestMethod]
        public void checkUserExistsWillReturnTrue()
        {
            Assert.AreEqual(trueUser.isExistsUser(), true);
        }

        [TestMethod]
        public void checkUserExistsWillReturnFalse()
        {
            Assert.AreEqual(wrongUser.isExistsUser(), false);
        }

        [TestMethod]
        public void authenticationUserReturnTrue()
        {
            Assert.AreEqual(trueUser.isAuthUser(), true);
        }

        [TestMethod]
        public void authenticationUserReturnFalse()
        {
            Assert.AreEqual(wrongUser.isAuthUser(), false);
        }
    }
}
