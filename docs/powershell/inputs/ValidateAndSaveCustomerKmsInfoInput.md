### ValidateAndSaveCustomerKmsInfoInput
Configuration to validate and save the customer's Azure KMS.

- kmsSpec: KmsSpecInput
  - Azure KMS configuration, excluding the app secret.
- appSecret: System.String
  - The secret of the client app.
