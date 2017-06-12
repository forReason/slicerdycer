using System;
using System.Diagnostics;
using System.Net.Http;
using System.Collections.Generic;
namespace slicerdycer
{
    public class Networkhandler
    {
        private static readonly HttpClient client = new HttpClient();
        public static string post()
	    {
            return "true";
	    }
        public static string get(string action, int user)
        {
            var responseString = client.GetStringAsync("https://api.primedice.com/api/"+action+ "?api_key="+GlobalVar.api[user]);
            Debug.WriteLine(GlobalVar.user[user]);
            Debug.WriteLine(responseString.Result);
            return responseString.Result;
            //return "hello";
        }
        public static string bet(int value, int user)
        {
            var values = new Dictionary<string, string>
            {
                { "amount", value.ToString() },
                { "condition", ">" },
                { "target", "50" }
            };
            var content = new FormUrlEncodedContent(values);

            var response = client.PostAsync("https://api.primedice.com/api/bet?api_key=" + GlobalVar.api[user], content);
            return response.Result.ToString();
        }
        public static string getbets(int user)
        {
            var response = client.GetStringAsync("https://api.primedice.com/api/mybets?api_key=" + GlobalVar.api[user]);
            return response.Result;
        }
    }
}