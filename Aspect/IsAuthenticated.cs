﻿using ASPNETAOP.Models;
using ASPNETAOP.Session;
using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace ASPNETAOP.Aspect
{
 
    [PSerializable]
    public sealed class IsAuthenticatedAttribute : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            HttpClient client = new HttpClient();
            String connectionString = "https://localhost:44316/api/UserLoginItems/" + Hash.CurrentHashed(AppHttpContext.Current.Session.Id);
            Task<UserLoginItem> userLogin = GetJsonHttpClient(connectionString, client); ;

            Console.WriteLine("UserLogin in IsAuthenticated" + userLogin.Result.isUserLoggedIn);

            if(userLogin.Result == null ) throw new UserNotLoggedInException();
            if(userLogin.Result.isUserLoggedIn != 1) throw new UserNotLoggedInException();
        }

        //Used to extract user information from retrieved json file
        private static async Task<UserLoginItem> GetJsonHttpClient(string uri, HttpClient httpClient)
        {
            try
            {
                return await httpClient.GetFromJsonAsync<UserLoginItem>(uri);
            }
            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }
            catch (JsonException) // Invalid JSON
            {
                Console.WriteLine("Invalid JSON.");
            }

            return null;
        }
    }

    public class UserNotLoggedInException : Exception
    {
        public UserNotLoggedInException() {}

        public UserNotLoggedInException(String message) : base(message) {}
    }
}
