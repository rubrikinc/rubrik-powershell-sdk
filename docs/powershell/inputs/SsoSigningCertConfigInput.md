### SsoSigningCertConfigInput
SsoSigningCertConfig is the per-object signing certificate a user uploads
for SSO signing certificate recovery.

- id: System.String
  - Specifies the object ID of the service principal or application.
- appId: System.String
  - Specifies the app ID of the object.
- uploadedCertificate: System.String
  - Specifies the Base64-encoded PFX bundle uploaded by the user. Carries the private key.
- password: System.String
  - Specifies the password protecting the PFX file, if any.
