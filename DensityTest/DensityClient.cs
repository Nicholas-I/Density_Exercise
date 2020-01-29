using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DensityTest.DensityModels;
using Newtonsoft.Json;

namespace DensityTest
{
    public class DensityClient
    {
        private string _baseURL = "https://api.density.io/v2/";
        private string _authToken = "tok_Un7Qj5gCQ3mNsPRkvGMLMcEYRtYZsVXxZUIVgQJeJpk";

        private readonly HttpClient _httpClient;

        public DensityClient()
        {
            _httpClient = new HttpClient{BaseAddress = new Uri(_baseURL), DefaultRequestHeaders = { Authorization = AuthenticationHeaderValue.Parse($"Bearer {_authToken}") } };
        }

        public async Task<List<Space>> GetSpacesList()
        {
            var result = await _httpClient.GetAsync("spaces");
            if (!result.IsSuccessStatusCode)
            {
                Console.Write(result.StatusCode);
            }

            var listOfSpaces =
                JsonConvert.DeserializeObject<ListSpaceResult>(result.Content.ReadAsStringAsync().Result);

            if (listOfSpaces == null)
            {
                Console.Write("No data returned");
                return null;
            }

            var spaces = listOfSpaces.results;

            return spaces;
        }

        public async Task<List<Count>> GetCounts(string spaceID, DateTimeOffset startTime, DateTimeOffset endTime)
        {
            var extraURL = "spaces/" + spaceID + "/counts/?start_time=" + startTime.UtcDateTime.ToString("o") + "&end_time=" + endTime.UtcDateTime.ToString("o");
            var result = await _httpClient.GetAsync(extraURL);

            if (!result.IsSuccessStatusCode)
            {
                Console.Write(result.StatusCode);
            }

            var listOfCounts = JsonConvert.DeserializeObject<CountResult>(result.Content.ReadAsStringAsync().Result);

            if (listOfCounts == null)
            {
                Console.Write("No data returned");
                return null;
            }

            var counts = listOfCounts.results;

            return counts;
        }
    }
}
