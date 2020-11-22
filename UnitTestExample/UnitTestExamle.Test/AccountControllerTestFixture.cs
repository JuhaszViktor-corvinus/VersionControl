using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExamle.Test
{
    public class AccountControllerTestFixture
    {
        [Test]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            // ...
        }
        [
        Test,
        TestCase("abcd1234", false),
        TestCase("irf@uni-corvinus", false),
        TestCase("irf.uni-corvinus.hu", false),
        TestCase("irf@uni-corvinus.hu", true)
        ]
    }
}
