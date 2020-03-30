using System;
using NUnit.Framework;

namespace SOAP
{
    public class DivideTest : BaseXML
    {        
        [TestCase("2", "2", "1", "Divide")]
        [TestCase("15", "5", "3", "Divide")]
        [TestCase("25", "5", "5", "Divide")]
        [TestCase("21", "3", "7", "Divide")]
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