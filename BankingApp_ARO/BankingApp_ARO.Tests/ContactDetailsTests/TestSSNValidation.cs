using System;
using BankingApp_ARO.ViewModels;
using NUnit.Framework;

namespace BankingApp_ARO.Tests.ContactDetailsTests
{
    [TestFixture]
    public class TestSSNValidation
    {
        public TestSSNValidation()
        {
        }

        [Test]
        public void Test_If_S_S_N_IS_Valid()
        {
            // positive test case 
            var isMatch = SSNValidationVM.ValidateSSN("9011074444198");
            Assert.IsTrue(isMatch);
        }
    }
}
