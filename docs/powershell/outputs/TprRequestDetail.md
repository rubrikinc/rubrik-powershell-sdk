### TprRequestDetail
Details of a TPR request.

- inventoryObjects: list of ManagedObjectSummarys
  - Managed objects that are part of the request.
- clusters: list of ClusterSummarys
  - Clusters that are part of the request.
- slaDomain: SlaDomainSummary
  - SLA Domain to be updated.
- targetSlaDomain: SlaDomainSummary
  - Target SLA domain to be assigned.
- editedPolicy: TprPolicySummary
  - TPR policy to be edited.
- description: System.String
  - Description of the request.
- requestedChangesTemplate: RequestedChangesTemplate
  - Requested changes.
