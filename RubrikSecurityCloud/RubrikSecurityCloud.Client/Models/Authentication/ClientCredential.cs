namespace Rubrik.SecurityCloud.NetSDK.Client.Models.Authentication
{
    public class ClientCredential
    {
        public string client_id { get; private set; }
        public string client_secret { get; private set; }

        public ClientCredential(string client_id, string client_secret)
        {
            this.client_id = client_id;
            this.client_secret = client_secret;
        }
    }
}

