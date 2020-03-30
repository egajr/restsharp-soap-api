using System;
using NUnit.Framework;
using RestSharp;
using JsonSubTypes;
using Newtonsoft.Json;


namespace SOAP
{
    public class UserPage
    {
        public IRestResponse NewUser(
            int id, String username, String firstName, String lastName, String email,
            String password, String phone, int userStatus
            )
        {
            var body = new
            {
                id = id,
                username = username,
                firstName = firstName,
                lastName = lastName, 
                email = email, 
                password = password, 
                phone = phone, 
                userStatus = userStatus
            };

            RestClient client = new RestClient("https://petstore.swagger.io/v2/");
            RestRequest request = new RestRequest("user", Method.POST);
            
            request.AddHeader("Accept", "application/json");
            request.AddJsonBody(body);

            return client.Execute(request);
        }

        public IRestResponse GetUser(String username)
        {
            RestClient client = new RestClient("https://petstore.swagger.io/v2/");
            RestRequest request = new RestRequest("user/" + username, Method.GET);
            
            request.AddHeader("Accept", "application/json");
            
            return client.Execute(request);
        }
    }
}