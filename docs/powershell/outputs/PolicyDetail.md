### PolicyDetail
Represents the policy detail.

- id: System.String
  - Policy ID.
- name: System.String
  - Policy name.
- description: System.String
  - Policy description.
- totalObjects: System.Int32
  - Total objects in a policy.
- pendingAnalysisObjects: System.Int32
  - Objects with pending initial analysis.
- analyzers: System.Int32
  - Total analyzers in a policy.
- lastUpdatedTime: System.Int64
  - Time when the policy was last updated.
- totalHits: System.Int64
  - Total sensitive hits in a policy.
- dataTypeIds: list of System.Strings
  - List of datatype IDs in a policy.
- objectsPercentCoverage: System.Int32
  - Percentage of objects covered.
- percentCoverage: System.Single
  - The percentage of coverage for a data category.
- creator: User
  - Policy creator.
