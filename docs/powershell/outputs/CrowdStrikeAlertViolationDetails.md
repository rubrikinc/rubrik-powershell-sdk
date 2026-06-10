### CrowdStrikeAlertViolationDetails
Crowdstrike alert violation details.

- crowdstrikeDetectionId: System.String
  - CrowdStrike detection ID.
- detectionName: System.String
  - Detection name from CrowdStrike.
- detectionDescription: System.String
  - Detection description.
- startTime: DateTime
  - Start time.
- endTime: DateTime
  - End time.
- detectionTime: DateTime
  - Detection time.
- actorIdentityId: System.String
  - Actor identity ID (principal ID).
- targetIdentityId: System.String
  - Target identity ID (principal ID - if applicable).
- mitreTactic: System.String
  - MITRE ATT&CK tactic.
- falconHostLink: System.String
  - Link to CrowdStrike console.
- actorEndpointHost: System.String
  - Actor endpoint information.
- actorEndpointIp: System.String
  - Actor endpoint IP.
