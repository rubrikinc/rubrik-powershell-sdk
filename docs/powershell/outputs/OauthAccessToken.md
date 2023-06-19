### OauthAccessToken
Request parameters for an OauthAccessTokenRequest.

- clientId: System.String
  - ClientID required to authenticate OAuth request for access token.
- code: System.String
  - Unique code required to authenticate OAuth request for access token.
- codeVerifier: System.String
  - Code verifier required to authenticate code challenge in the database.
- expiryTime: System.String
  - The time after which the Rubrik CDM OVA expires.
- redirectUri: System.String
  - If the RSC registration fails, refer to this URL.
