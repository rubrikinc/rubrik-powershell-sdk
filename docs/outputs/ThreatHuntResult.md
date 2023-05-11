### ThreatHuntResult
Represents the configuration and results for a threat hunt.

- config: ThreatHuntConfig
  - The configuration of the Threat Hunt.
- huntId: System.String
  - ID of the threat hunt.
- results: a list of MalwareScanResults
  - Results of the scan on each object.
- stats: ThreatHuntStats
  - The statistics based on results of the threat hunt.
- status: ThreatHuntStatus
  - Status of the threat hunt.
