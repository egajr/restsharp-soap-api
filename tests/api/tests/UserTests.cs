using System;
using NUnit.Framework;

namespace SOAP
{
    public class UserTests : UserPage
    {
        [Test]
        [Category("1")]       
        [TestCase(2424, "Gordo", "Gordinho", "Gordao", "ggg@hotmail.com", "242424", "3234215646", 1)]
        public void TestNewUser(
            int id, String username,String firstName, String lastName, String email, 
            String password, String phone, int userStatus
            )
        {
            var response = NewUser(id, username,firstName, lastName, email, password, phone, userStatus);

            System.Console.WriteLine(response.Content);
            System.Console.WriteLine(response.ErrorMessage);
            Assert.AreEqual(200, (int)response.StatusCode);            
            Assert.That(response.Content.Contains(id.ToString()));
        }
    }
}