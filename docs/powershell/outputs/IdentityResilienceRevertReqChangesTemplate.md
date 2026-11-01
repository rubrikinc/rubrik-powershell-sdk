### IdentityResilienceRevertReqChangesTemplate
TPR requested changes template for reverting Identity Resilience activities.

- remediationType: System.String
  - Name of the remediation type being reverted, for example
REMEDIATION_TYPE_GPO_ROLLBACK.
- targetIds: list of System.Strings
  - IDs of the remediation targets being reverted.
- resourceId: System.String
  - ID of the resource the reverted activities acted on.
- domainControllerFid: System.String
  - FID of the domain controller selected by the requester.
- templateName: System.String
  - Name of the requested changes template for quorum authorization.
- targetType: System.String
  - Name of the type of the remediation targets, for example
REMEDIATION_TARGET_TYPE_VIOLATION.
