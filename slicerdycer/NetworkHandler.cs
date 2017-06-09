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
        public static string get(string action)
        {
            var responseString = client.GetStringAsync("https://api.primedice.com/api/"+action+ "?api_key="+GlobalVar.api);
            return responseString.Result;
        }
        public static string bet(int value)
        {
            var values = new Dictionary<string, string>
            {
                { "amount", value.ToString() },
                { "condition", ">" },
                { "target", "49.5" }
            };
            var content = new FormUrlEncodedContent(values);

            var response = client.PostAsync("https://api.primedice.com/api/bet?api_key=" + GlobalVar.api, content);
            return response.Result.ToString();
        }
    }
}