### MvcProfile
MvcProfile represents an MVC (Minimum Viable Company) profile for an org.

- id: System.String
  - Unique ID of the MVC profile.
- orgId: System.String
  - ID of the org this profile belongs to.
- name: System.String
  - Display name of the MVC profile.
- description: System.String
  - Optional description of the MVC profile.
- groupIds: list of System.Strings
  - IDs of the M365 groups included in this profile.
- userIds: list of System.Strings
  - IDs of the M365 users included in this profile.
- siteIds: list of System.Strings
  - IDs of the SharePoint sites included in this profile.
- totalUniqueUsers: System.Int32
  - Cached count of unique users across all groups in this profile.
- analysisJob: MvcAnalysisJob
  - Most recent MVC analysis job for this profile.
- updatedAt: DateTime
  - Timestamp when the profile was last updated.
