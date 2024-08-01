### PersistCustomerM365AppInput
Details of the customer-owned M365 app to persist.

- tenantId: System.String
  - ID of the Azure AD tenant for M365.
- m365CloudType: M365Cloud
  - Cloud type for M365.
- appType: O365AppType
  - Type of app.
- appClientId: System.String
  - ID of the app.
- appClientSecret: System.String
  - Secret for the app.
- appCertificate: System.String
  - Certificate for the SharePoint/Teams app in X.509 PEM format.
- appPrivateKey: System.String
  - Private key for the SharePoint/Teams app in PKCS#1 PEM format.
