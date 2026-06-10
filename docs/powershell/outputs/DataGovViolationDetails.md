### DataGovViolationDetails
Additional metadata about the data associated with the violation.

- snapshotId: System.String
  - The ID of the snapshot.
- violatedSensitiveFiles: System.Int64
  - Total number of sensitive files after allowlisting.
- violatedSensitiveHits: System.Int64
  - Total number of sensitive hits after allowlisting.
- violatedNoRiskSensitiveHits: System.Int64
  - Total number of no-risk sensitive hits after allowlisting.
- violatedLowRiskSensitiveHits: System.Int64
  - Total number of low-risk sensitive hits after allowlisting.
- violatedMediumRiskSensitiveHits: System.Int64
  - Total number of medium-risk sensitive hits after allowlisting.
- violatedHighRiskSensitiveHits: System.Int64
  - Total number of high-risk sensitive hits after allowlisting.
- dataTypes: list of DataTypeStatss
  - Data type counts in the data.
- dataCategories: list of DataCategoryStatss
  - Data category counts in the data.
- mipLabels: list of MipLabelStatss
  - MIP label counts in the data.
- permissions: Permissions
  - The permissions that violate the policy.
- identityViolationDetails: IdentityViolationDetails
  - Identity violation details associated with
a Data Governance (datagov) violation.
- documentTypes: list of DocumentTypeStatss
  - Document type counts in the data.
- referenceTime: DateTime
  - The reference time used to evaluate the violation.
