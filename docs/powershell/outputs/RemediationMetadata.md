### RemediationMetadata


- remediationId: System.String
  - Unique identifier for the remediation.
- resourceId: System.String
  - The resource ID that the remediation have been applied on.
- state: RemediationState
  - The state of the remediation.
- type: RemediationType
  - The type of the remediation.
- policyViolationId: System.String
  - This field is deprecated.
- lastUpdatedBy: System.String
  - The user who last updated the remediation.
- lastUpdatedAt: DateTime
  - The time when the remediation was last updated.
- remediationDetails: RemediationActionDetails
  - The details of the remediation.
- targets: RemediationTargets
  - The targets that the remediation have been applied on.
- location: RemediationLocation
  - The location that the remediation have been invoked from.
- resourceType: PolicyResourceType
  - The resource type of the remediation resource.
