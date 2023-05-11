### ThreatHuntSummaryReply
Response to the threat hunt summary request.

- config: ThreatHuntConfig
  - The threat hunt configuration.
- huntId: System.String
  - The ID of the threat hunt.
- objectsSummary: a list of ThreatHuntResultObjectsSummarys
  - Threat hunt summaries for each object.
- stats: ThreatHuntStats
  - The stats based on results of the threat hunt.
- status: ThreatHuntStatus
  - Status of the threat hunt.
