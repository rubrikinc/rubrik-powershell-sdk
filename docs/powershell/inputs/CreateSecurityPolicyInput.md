### CreateSecurityPolicyInput
The input for creating a security policy.

- policyName: System.String
  - Name of the policy.
- description: System.String
  - Description of the security policy.
- policyType: PolicyType
  - Type of the policy.
- filter: FilterGroupConfigInput
  - Filter configuration for the policy.
- policySeverity: Severity
  - Severity of the policy.
- policyCategory: Category
  - Category of the policy.
- isAutomationEnabled: System.Boolean
  - Whether the automation is enabled for the policy.
- automationRules: list of AutomationRuleInputs
  - The automation rules for the policy.
- thresholdFilter: FilterGroupConfigInput
  - Threshold filter for the policy.
- policyTypeInfo: PolicyTypeInfoInput
  - Specific info for the policy type. Required for Identity Event policies to specify providers.
- frameworks: list of System.Strings
  - The frameworks associated with the policy.
