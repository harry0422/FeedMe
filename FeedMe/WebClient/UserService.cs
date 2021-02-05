using FeedMe.WebClient.DTOs;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace FeedMe.WebClient
{
    public class UserService
    {
        private const string WS_URL = "https://demo-stefanini-api-management.azure-api.net/usersservice/Users/";

        public async Task<UserDto> GetUserByUserName(string userName)
        {
            string json = await CallUrl(WS_URL + userName);
            UserDto user = JsonConvert.DeserializeObject<UserDto>(json);

            return user;
        }

        private async Task<string> CallUrl(string url)
        {
            HttpClient client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            client.DefaultRequestHeaders.Accept.Clear();

            return await client.GetStringAsync(url);
        }
    }
}
