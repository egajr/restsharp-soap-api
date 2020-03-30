using System;
using NUnit.Framework;

namespace SOAP
{
    public class MultiplyTest : BaseXML
    {        
        [TestCase("2", "2", "4", "Multiply")]
        [TestCase("15", "4", "60", "Multiply")]
        [TestCase("2", "5", "10", "Multiply")]
        [TestCase("6", "5", "30", "Multiply")]
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