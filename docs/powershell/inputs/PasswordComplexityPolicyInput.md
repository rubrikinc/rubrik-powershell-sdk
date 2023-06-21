### PasswordComplexityPolicyInput
Specifies the password policy to be used by the organization.

- lengthPolicy: PasswordComplexityPolicyTemplateInput
  - Policy for the length of each password string.
- lowercasePolicy: PasswordComplexityPolicyTemplateInput
  - Policy for the number of lowercase characters in each password string.
- uppercasePolicy: PasswordComplexityPolicyTemplateInput
  - Policy for the number of uppercase characters in each password string.
- specialCharsPolicy: PasswordComplexityPolicyTemplateInput
  - Policy for the number of special characters in each password string.
- numericPolicy: PasswordComplexityPolicyTemplateInput
  - Policy for the number of numeric characters in each password string.
- passwordReusePolicy: PasswordComplexityPolicyTemplateInput
  - Policy for controlling password reuse.
- passwordExpirationPolicy: PasswordComplexityPolicyTemplateInput
  - Policy for controlling password expiration.
