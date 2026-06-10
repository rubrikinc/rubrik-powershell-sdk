### DefenderAlertViolationDetails
Microsoft Defender for Identity alert violation details.

- defenderAlertId: System.String
  - Unique alert ID from Defender.
- detectionName: System.String
  - Alert name (title).
- detectionDescription: System.String
  - Full alert description.
- startTime: DateTime
  - Earliest activity associated with the alert.
- endTime: DateTime
  - Latest activity associated with the alert.
- detectionTime: DateTime
  - When Defender created the alert.
- actorIdentityId: System.String
  - Actor identity ID (principal ID).
- targetIdentityId: System.String
  - Target identity ID (principal ID - if applicable).
- mitreTactic: System.String
  - MITRE ATT&CK tactic (from alert category).
- mitreTechniques: list of System.Strings
  - MITRE ATT&CK technique IDs (array, unlike CrowdStrike's single value).
- alertWebUrl: System.String
  - Link to the Microsoft Security portal.
