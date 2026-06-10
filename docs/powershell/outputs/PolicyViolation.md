### PolicyViolation
Details of policy violation.

- resourceId: System.String
  - Resource involved in a policy violation.
- resourceType: PolicyResourceType
  - Resource type.
- policy: DSPMPolicy
  - Policy associated with this violation.
- policyVersion: System.Int32
  - The version of the policy.
- status: PolicyViolationStatus
  - The current status of the policy violation.
- statusReason: PolicyViolationStatusReason
  - A reason explaining the last change in status.
- lastUpdatedBy: System.String
  - ID of the user who last changed the policy violation.
- policyViolationId: System.String
  - The ID of the policy violation.
- createdAt: DateTime
  - The time the violation was created at.
- lastUpdatedAt: DateTime
  - The last time the violation was updated.
- lastEvaluatedAt: DateTime
  - Last time when this violation was evaluated by korg job.
- userFriendlyViolationId: System.String
  - policy violation ID in user friendly format
- secondaryResourceId: System.String
  - Secondary resource that is involved in a policy violation.
This field will be null if the violation has only one resource.
- secondaryResourceType: PolicyResourceType
  - The type of the secondary resource.
This field will be UNSPECIFIED when the secondary resource ID is null.
- parentPolicyViolationId: System.String
  - The ID of the parent policy violation.
This field will be null if the violation is primary-level violation.
- name: System.String
  - The name of the violation.
This field will be null if the violation does not have a name.
- originId: System.String
  - The origin ID of the violation.
- originStartTime: DateTime
  - Origin start time is the timestamp when the violation was triggered at the
origin platform.
- violationSeverity: Severity
  - The severity of the violation itself, if set.
SEVERITY_UNSPECIFIED when no violation-level severity override exists.
- resourceViolationsCount: System.Int32
  - Resource-level aggregate violation counts:
- resourceCriticalViolationsCount: System.Int32
  - 
- resourceHighViolationsCount: System.Int32
  - 
- resourceMediumViolationsCount: System.Int32
  - 
- resourceLowViolationsCount: System.Int32
  - 
- resourceMaxSeverity: Severity
  - 
- details: ViolationDetailsUnion
  - Additional details about the policy violation.
- resourceMetadata: ResourceMetadata
  - Metadata for the resource involved in the policy violation.
- userLastUpdated: User
  - The user who last updated the violation.
- remediations: list of RemediationMetadatas
  - Details of the remediations associated with the violation.
- possibleRemediationsForViolationTarget: list of RemediationAvailabilitys
  - Possible remediations for violation target type.
- violationSummaryForResource: ViolationSummaryForResource
  - The violations summary for the resource in the violation
