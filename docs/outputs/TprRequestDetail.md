### TprRequestDetail
Details of a TPR request.

- clusters: a list of ClusterSummarys
  - Clusters that are part of the request.
- description: System.String
  - Description of the request.
- editedPolicy: System.String
  - TPR policy to be edited.
- objects: a list of ManagedObjectSummarys
  - Managed objects that are part of the request.
- requestedChanges: a list of TprRequestedChanges
  - Requested changes in the request.
- slaDomain: SlaDomainSummary
  - SLA Domain to be updated.
- targetSlaDomain: SlaDomainSummary
  - Target SLA domain to be assigned.
