### InsertCustomerO365AppInput
Details of the customer-owned O365 app to insert.

- appType: System.String
  - Type of app to insert.
- appClientId: System.String
  - ID of the app.
- appClientSecret: System.String
  - Secret for the app.
- subscriptionId: System.String
  - ID of the subscription that the app would access.
- base64AppCertificate: System.String
  - Certificate for a SharePoint-typed app.
- base64AppPrivateKey: System.String
  - Private key for a SharePoint-typed app.
- updateAppCredentials: System.Boolean
  - Specifies whether the application exists in RSC. If so, you can update the application credentials.
- appSecretExpiry: DateTime
  - Expiration date of the app secret.
- appCertificateExpiry: DateTime
  - Expiration date of the app certificate.
