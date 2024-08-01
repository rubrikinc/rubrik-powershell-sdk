### SetCorsSettingInput
Input to set CORS setting for the customer's organization.

- isEnabled: System.Boolean
  - Specifies whether CORS is enabled or not.
- allowedOrigins: list of System.Strings
  - List of origins allowed to make cross-origin requests.
- allowedHeaders: list of System.Strings
  - List of headers allowed in cross-origin requests.
- allowedMethods: list of HttpMethods
  - List of methods allowed to use in cross-origin requests.
- allowedPaths: list of System.Strings
  - List of api paths allowed in RSC to use in cross-origin requests.
