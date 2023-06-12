### ThreatHuntSummaryReply
Response to the threat hunt summary request.

- huntId: System.String
  - The ID of the threat hunt.
- config: ThreatHuntConfig
  - The threat hunt configuration.
- status: ThreatHuntStatus
  - Status of the threat hunt.
- stats: ThreatHuntStats
  - The stats based on results of the threat hunt.
- objectsSummary: list of ThreatHuntResultObjectsSummarys
  - Threat hunt summaries for each object.
