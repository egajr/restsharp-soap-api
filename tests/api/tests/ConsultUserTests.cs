using System;
using NUnit.Framework;

namespace SOAP
{
    public class ConsultUserTests : UserPage
    {
        [Test]
        [Category("2")]           
        [TestCase("2424", "Gordo")]
        public void TestGetUser(String id, String username)
        {
            var response = GetUser(username);

            Console.WriteLine(response.Content);
            Console.WriteLine(response.ErrorMessage);
            Assert.AreEqual(200, (int)response.StatusCode);            
            Assert.That(response.Content.Contains(username));
            Assert.That(response.Content.Contains(id));

        }
    }
}