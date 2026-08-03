### PerCapSpikeDetails
PerCapSpikeDetails describes a sign-in failure spike attributed to a single
Entra ID Conditional Access Policy (CAP).

- capId: System.String
  - The Conditional Access Policy ID (raw Microsoft Graph CAP UUID).
- capDisplayName: System.String
  - Human-readable CAP display name (best-effort; chip hydration is the source
of truth at read time).
- errorCodes: list of System.Int32s
  - The sign-in error codes that drove the spike.
- results: list of System.Strings
  - Result strings observed for the spike (e.g. sign-in result/status labels).
