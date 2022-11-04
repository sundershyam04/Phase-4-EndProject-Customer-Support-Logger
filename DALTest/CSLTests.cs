using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DALTest
{
    [TestFixture]
    public class CSLTests
    {
        CSLoperations operations;
        public CSLTests()
        {
           operations = new CSLoperations();
        }

        //UserInfoTest
        //[Test]

        [TestCase(1,"ravi@gmail.com","Ravi@123",ExpectedResult =true)]
        public bool ValidateUser(int user, string email,string pw)
        {
           
            var found = operations.ValidateUser(user,email, pw);

            return found;

        }

        //custloginfo

        [Test]
        public bool GetAllLoginInfoTest()
        {
            csldbEntities context = new csldbEntities();
            var got = context.CustLogInfoes.ToList();
            return got != null;
        }

        [Test]
        [TestCase("Ravi", ExpectedResult = true)]
        [TestCase("Ram", ExpectedResult = false)]
        public bool SaveCustLogInfoTest(string s)
        {
            csldbEntities context = new csldbEntities();
            var found = context.CustLogInfoes.ToList().Find(c => c.CustName == s);

            return found != null;

        }


    }
}

