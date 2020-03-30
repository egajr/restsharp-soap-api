using System;
using NUnit.Framework;

namespace SOAP
{
    public class AddTest : BaseXML
    {        
        [TestCase("2", "2", "4", "Add")]
        [TestCase("15", "5", "20", "Add")]
        [TestCase("2", "5", "7", "Add")]
        [TestCase("12", "5", "17", "Add")]
        public void TestSoma(int num1, int num2, int result, String oper)
        {
            var response = PostRequest(num1, num2, oper);

            Console.WriteLine(response.Content);
            Console.WriteLine(response.ErrorMessage);
            Assert.AreEqual(200, (int)response.StatusCode);            
            Assert.That(response.Content.Contains("<" + oper + "Result>" + result + "</" + oper + "Result>"));

        }
    }
}