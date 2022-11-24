﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [Test]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            //ARRANGE
            var accountController = new AccountController();

            //ACT
            var actualResult = accountController.ValidateEmail(email);

            //ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
