using System;
using System.Diagnostics;
using System.Net.Http;
using System.Collections.Generic;
namespace slicerdycer
{
    public class Networkhandler
    {
        private static readonly HttpClient client = new HttpClient();
        public static string Post()
	    {
            return "true";
	    }
        public static string Get(string action, int user)
        {
            var responseString = client.GetStringAsync("https://api.primedice.com/api/"+action+ "?api_key="+GlobalVar.api[user]);
            Debug.WriteLine(GlobalVar.user[user]);
            Debug.WriteLine(responseString.Result);
            return responseString.Result;
            //return "hello";
        }
        public static string Bet(int amount, int user)
        {
            var values = new Dictionary<string, string>
            {
                { "amount", amount.ToString() },
                { "condition", ">" },
                { "target", "50" }
            };
            var content = new FormUrlEncodedContent(values);

            var response = client.PostAsync("https://api.primedice.com/api/Bet?api_key=" + GlobalVar.api[user], content);
            return response.Result.ToString();
        }
        public static string GetBets(int user)
        {
            var response = client.GetStringAsync("https://api.primedice.com/api/mybets?api_key=" + GlobalVar.api[user]);
            return response.Result;
        }
        public static string TipAnUser(int amount, int user, string userToTip )
        {
            var values = new Dictionary<string, string>
            {
                { "username", userToTip},
                { "amount", amount.ToString() },
                { "hide", "true" },
            };
            var content = new FormUrlEncodedContent(values);
            var response = client.PostAsync("https://api.primedice.com/api/tip?api_key=" + GlobalVar.api[user], content);
            Debug.WriteLine(response.Result.ToString());
            return response.Result.ToString();
        }
    }
}