using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using NUnit.Framework;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.NetSDK.Client.Models.Authentication;

namespace RubrikSecurityCloud.Client.Tests
{
    [TestFixture]
    public class DisconnectTests
    {
        private static string MakeToken(DateTime expires)
        {
            var token = new JwtSecurityToken(
                notBefore: expires.AddHours(-1),
                expires: expires);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        // Port 1 is unassigned, so any HTTP call fails with a connection
        // error instead of silently succeeding.
        private static RscGraphQLClient MakeAuthorizedClient(string accessToken)
        {
            var client = new RscGraphQLClient(
                "client-id", "client-secret", "http://localhost:1", null);
            typeof(RscGraphQLClient)
                .GetField("_clientToken", BindingFlags.NonPublic | BindingFlags.Instance)!
                .SetValue(client, new ClientToken("client-id", accessToken));
            typeof(RscGraphQLClient)
                .GetField("_authenticationState", BindingFlags.NonPublic | BindingFlags.Instance)!
                .SetValue(client, AuthenticationState.AUTHORIZED);
            return client;
        }

        // ── IsTokenExpired ──────────────────────────────────────────

        [Test]
        public void IsTokenExpired_PastExpiry_ReturnsTrue()
        {
            var now = DateTime.UtcNow;
            Assert.IsTrue(RscGraphQLClient.IsTokenExpired(
                MakeToken(now.AddMinutes(-1)), now));
        }

        [Test]
        public void IsTokenExpired_FutureExpiry_ReturnsFalse()
        {
            var now = DateTime.UtcNow;
            Assert.IsFalse(RscGraphQLClient.IsTokenExpired(
                MakeToken(now.AddMinutes(30)), now));
        }

        [Test]
        public void IsTokenExpired_WithinRefreshThreshold_ReturnsFalse()
        {
            var now = DateTime.UtcNow;
            Assert.IsFalse(RscGraphQLClient.IsTokenExpired(
                MakeToken(now.AddMinutes(2)), now));
        }

        // ── Disconnect ──────────────────────────────────────────────

        [Test]
        public void Disconnect_ExpiredToken_SkipsDeleteAndClearsState()
        {
            var client = MakeAuthorizedClient(
                MakeToken(DateTime.UtcNow.AddMinutes(-10)));

            Assert.DoesNotThrowAsync(() => client.Disconnect());
            Assert.AreEqual(
                AuthenticationState.NOT_AUTHORIZED, client.AuthenticationState);
        }

        [Test]
        public void Disconnect_ValidToken_AttemptsDelete()
        {
            var client = MakeAuthorizedClient(
                MakeToken(DateTime.UtcNow.AddMinutes(30)));

            Assert.ThrowsAsync<HttpRequestException>(() => client.Disconnect());
        }
    }
}
