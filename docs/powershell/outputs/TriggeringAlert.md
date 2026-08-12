### TriggeringAlert
The alert behind a mark or recommendation.

- source: System.String
  - The threat source that raised the alert, for example "defender" or
"crowdstrike".
- detectionName: System.String
  - The alert title or detection name.
- vendorDetectionId: System.String
  - The vendor's detection taxonomy id: the Defender detectorId or the
CrowdStrike pattern_id. Empty when the source supplies none.
- alertTime: DateTime
  - When the alert fired.
- originId: System.String
  - The originating violation id.
