### ComplianceState
Stores the compliance status of a workload type.

- compliancePercentage: System.Int32
  - Percentage of compliance.
- lowComplianceReason: System.String
  - Reasons for low compliance. If there is no valid reason, this field will be empty.
- shouldAllowSwitchToOnboardingMode: System.Boolean
  - Describes if a switch to onboarding mode can be allowed.
- lastComplianceUpdateTime: DateTime
  - Returns the last compliance update time.
