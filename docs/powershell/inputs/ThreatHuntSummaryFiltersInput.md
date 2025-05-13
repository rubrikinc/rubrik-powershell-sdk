### ThreatHuntSummaryFiltersInput
Filters to specify the threat hunt summary.

- clusterUuids: list of System.Strings
  - List of cluster UUIDs.
- cloudProviders: list of System.Strings
  - List of cloud providers. Valid Options = [AWS, Azure].
- matchTypes: list of IndicatorOfCompromiseKinds
  - List of match types.
- objectScanStatus: list of ThreatHuntObjectStatuss
  - List of object scan statuses.
