### UpdateDSPMPolicyInput
The input for updating an existing DSPM policy.

- policyId: System.String
  - ID of the policy to update.
- policyType: PolicyType
  - Type of the policy
- filter: FilterGroupConfigInput
  - Filter configuration for the policy.
- isEnabled: System.Boolean
  - Status of the policy.
- policyName: System.String
  - Name of the policy.
- description: System.String
  - Description of the security policy.
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
- keepViolationsOpen: System.Boolean
  - Whether to keep related violations open if the policy is closed.
- frameworks: list of System.Strings
  - The frameworks associated with the policy.
- policyTypeInfo: PolicyTypeInfoInput
  - Policy-type-specific configuration.
- forceUpdateThresholdFilter: System.Boolean
  - When true, the threshold_filter field is honored as-is on the wire and
written to the column (including the nil case, which clears it). When
false (proto3 default), threshold_filter is left unchanged when omitted
and updated when set. This sentinel disambiguates "omitted" (= leave
alone) from "explicit value" -- threshold_filter is a message type and
proto3 cannot represent "explicitly null" on the wire. Mirrors
PolicyUpdate.force_update_threshold_filter. See SPARK-775226.
- anomalyDetectionConfig: AnomalyDetectionConfigInput
  - Anomaly-detection tuning. Only valid for sign-in anomaly policies; rejected
for any other policy type. When omitted, the existing configuration is
preserved.
