using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hive.Model.Repository;

namespace Hive.Model.Repository.Tests
{
    [TestClass]
    public class EFUserRepositoryFixture
    {
        [TestMethod]
        public void ShouldFindUser()
        {
            var repo = new EFUserRepository();
            var result = repo.Find("admin");
            Assert.AreEqual("admin", result.Login);
            Assert.AreEqual("admin", result.Password);
        }
    }
}
