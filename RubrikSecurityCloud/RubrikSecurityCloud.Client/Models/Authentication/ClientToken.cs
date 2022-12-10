using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.NetSDK.Client.Models.Authentication
{
    public class ClientToken
    {
        public string ClientId { get; private set; }
        public string AccessToken { get; private set; }

        [JsonConstructor]
        public ClientToken(string client_id, string access_token)
        {
            ClientId = client_id;
            AccessToken = access_token;
        }
    }
}
