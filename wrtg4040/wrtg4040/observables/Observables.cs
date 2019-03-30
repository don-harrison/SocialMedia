using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static Users.Users;

namespace wrtg4040
{
    struct Endpoints
    {
        public static string RandomUser = "https://uinames.com/api/";
        public static string RandomKanyeQuotes = "https://uinames.com/api/";
        public static string RandomDumbJokes = "https://geek-jokes.sameerkumar.website/api";
        public static string RandomPoems = "https://www.poemist.com/api/v1/randompoems";
    }
    /// <summary>
    /// The Class That handles calls to the API that sends the Random Users.
    /// </summary>
    public static class UserObservables
    {

        private static HttpClient CreateClientRandomUser()
        {
            // Create a client whose base address is the GitHub server
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Endpoints.RandomUser);

            // Tell the server that the client will accept this particular type of response data
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            // There is more client configuration to do, depending on the request.
            return client;
        }

        static async void GETUser(int amount)
        {
            Users = new
            try
            {
                using (HttpClient client = CreateClientRandomUser())
                {

                    // Compose and send the request.
                    //StringContent content = new StringContent(JsonConvert.SerializeObject(stateRequest), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.GetAsync(Endpoints.RandomUser);

                    // Deal with the response
                    if (response.IsSuccessStatusCode)
                    {
                        String result = await response.Content.ReadAsStringAsync();
                         = JsonConvert.DeserializeObject<StateResponse>(result);

                    }
                    else
                    {
                        MessageBox.Show("Error registering: " + response.StatusCode + "\n" + response.ReasonPhrase);
                    }
                }

                return stateResponse;
            }

            catch (TaskCanceledException)
            {
                return stateResponse;
            }  
        }

    }

    /// <summary>
    /// The Class That handles calls to the API that sends the Random Post.
    /// </summary>
    public static class PostObservables
    {
        
    }
}
