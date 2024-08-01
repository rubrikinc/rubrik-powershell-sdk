### CompleteSaasAppAuthConsentInput
Configuration for the SaaS App OAuth consent flow.

- sessionId: System.String
  - A unique identifier for the in-memory session in the Rubrik environment that contains information about an ongoing OAuth workflow. This is obtained after the kickoff of the OAuth consent flow.
- state: System.String
  - The unique identifier to identify an OAuth workflow.
- authorizationCode: System.String
  - A short-lived code obtained after the first leg of the OAuth workflow. This code is used to obtain subsequent tokens.
