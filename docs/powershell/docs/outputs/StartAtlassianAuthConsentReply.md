### StartAtlassianAuthConsentReply
- authorizationUrl: System.String
  - The URL to which the request is directed to obtain the authorization
 code during the first leg of OAuth workflow.
- sessionId: System.String
  - A unique identifier for the in-memory session in the Rubrik environment
 that contains information about an ongoing OAuth workflow.
 This is obtained after the kickoff of the OAuth consent flow.
- state: System.String
  - A unique identifier to identify an OAuth workflow session.
