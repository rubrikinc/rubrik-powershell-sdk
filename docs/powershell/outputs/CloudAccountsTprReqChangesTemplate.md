### CloudAccountsTprReqChangesTemplate
Template for TPR request changes regarding the cloud account deletion.

- cloudVendor: CloudVendor
  - Vendor of the cloud account.
- cloudAccountIds: list of System.Strings
  - Cloud account IDs for customer accounts.
- features: list of CloudAccountFeatures
  - Features corresponding to cloud accounts.
- cloudAccountsDetails: list of CloudAccountDetails
  - Details of the cloud accounts.
- requestedAction: System.String
  - Requested action string.
- templateName: System.String
  - Name of the requested changes template for quorum authorization.
