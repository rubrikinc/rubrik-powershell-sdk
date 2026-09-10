### EntraIdLinkedServicePrincipal
Summary of the service principal that shares an application's app ID. Entra
ID represents an application and the enterprise application that users sign
in to as two objects joined by that ID.

- objectId: System.String
  - Object ID of the Entra ID service principal, which differs from the
object ID of the application.
- displayName: System.String
  - Display name of the Entra ID service principal, which need not match the
display name of the application.
- hasSigningCert: System.Boolean
  - Specifies whether a token-signing certificate is configured on the Entra
ID service principal.
