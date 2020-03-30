using System;
using NUnit.Framework;
using RestSharp;

namespace SOAP
{
    public class BaseXML
    {  
        public IRestResponse PostRequest(int intA, int intB, String oper)
        {
            String xmlData = "<Envelope xmlns = 'http://schemas.xmlsoap.org/soap/envelope/'>" + 
                                "<Body>" +                            
                                    "<" + oper + " xmlns = 'http://tempuri.org/'>" +                            
                                        "<intA>"+ intA +"</intA>" +                            
                                        "<intB>"+ intB +"</intB>" +                            
                                    "</" + oper + ">" +                            
                                "</Body>" +
                            "</Envelope>";

            IRestClient client = new RestClient("http://www.dneonline.com/calculator.asmx?WSDL");
            IRestRequest request = new RestRequest();//(Method.POST) {RequestFormat = DataFormat.Xml};

            request.AddHeader("Content-Type", "text/xml;charset=utf-8");
            request.AddParameter("XmlBody", xmlData, ParameterType.RequestBody);            

            return client.Post(request);              
        }
    }
}