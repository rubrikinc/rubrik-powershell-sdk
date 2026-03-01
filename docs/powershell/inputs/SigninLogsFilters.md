### SigninLogsFilters
Filters for querying sign-in logs.

- userSids: list of System.Strings
  - Filter by user SIDs (unique user identifiers).
- providers: list of EventProviders
  - Filter by provider type.
- eventTypes: list of System.Strings
  - Filter by event type (varies by provider).
- results: list of SigninLogResults
  - Filter by result.
- tenantIds: list of System.Strings
  - Filter by tenant IDs.
- riskLevels: list of SigninLogRiskLevels
  - Filter by risk level.
- applicationNames: list of System.Strings
  - Filter by application names.
- ipAddresses: list of System.Strings
  - Filter by IP addresses.
- countries: list of System.Strings
  - Filter by countries.
- locations: list of System.Strings
  - Filter by locations (city + country code, e.g. "New York, US").
- displayNames: list of System.Strings
  - Filter by display names.
