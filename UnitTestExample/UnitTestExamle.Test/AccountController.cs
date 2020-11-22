using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExamle.Test
{
    class AccountController
    {
        // Arrange
        var accountController = new AccountController();

        // Act
        var actualResult = accountController.ValidateEmail(email);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
internal object Register(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
