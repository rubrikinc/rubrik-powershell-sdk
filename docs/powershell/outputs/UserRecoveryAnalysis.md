### UserRecoveryAnalysis
Per-user recovery analysis data containing activity statistics for Exchange, OneDrive, and SharePoint.

- userId: System.String
  - The unique identifier of the user.
- userEmail: System.String
  - The email address of the user.
- userName: System.String
  - The display name of the user.
- exchange: ExchangeAnalysisResult
  - Exchange activity analysis for this user including emails, calendar events, and contacts.
- onedrive: OnedriveAnalysisResult
  - OneDrive activity analysis for this user including file counts.
- sharepoint: SharepointAnalysisResult
  - SharePoint activity analysis for this user including sites and files accessed.
