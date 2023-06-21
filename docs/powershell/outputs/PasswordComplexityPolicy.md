### PasswordComplexityPolicy
Represents the password complexity policy that applies when users in the organization set or update passwords.

- lengthPolicy: PasswordComplexityPolicyTemplate
  - Policy for the length of each password string.
- lowercasePolicy: PasswordComplexityPolicyTemplate
  - Policy for the number of lowercase characters in each password string.
- uppercasePolicy: PasswordComplexityPolicyTemplate
  - Policy for the number of uppercase characters in each password string.
- specialCharsPolicy: PasswordComplexityPolicyTemplate
  - Policy for the number of special characters in each password string.
- numericPolicy: PasswordComplexityPolicyTemplate
  - Policy for the number of numeric characters in each password string.
- passwordReusePolicy: PasswordComplexityPolicyTemplate
  - Policy for controlling password reuse.
- passwordExpirationPolicy: PasswordComplexityPolicyTemplate
  - Policy for controlling password expiration.
