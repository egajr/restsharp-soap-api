using System;
using NUnit.Framework;

namespace SOAP
{
    public class SubtractTest : BaseXML
    {        
        [TestCase("2", "2", "0", "Subtract")]
        [TestCase("15", "5", "10", "Subtract")]
        [TestCase("12", "5", "7", "Subtract")]
        [TestCase("12", "8", "4", "Subtract")]
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