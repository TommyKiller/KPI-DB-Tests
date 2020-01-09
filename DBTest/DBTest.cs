using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DB;

namespace DBTest
{
    [TestClass]
    public class DBTest
    {
        [TestMethod]
        public void Registration()
        {
            Authentificator auth = new Authentificator("test_name", "test_password");
            User user = auth.Register();
            Assert.IsTrue(user.IsLoggedIn);
        }

        [TestMethod]
        public void Login()
        {
        }
    }
}
