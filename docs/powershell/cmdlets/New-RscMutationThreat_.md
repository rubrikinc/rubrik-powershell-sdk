# New-RscMutationThreat
## Subcommands
### cancelhunt
Cancel an in-progress threat hunt.

- There is a single argument of type CancelThreatHuntInput.
- Returns System.String.
### enablemonitoring
Enable or disable Threat Monitoring on a Rubrik cluster.

- There is a single argument of type EnableThreatMonitoringInput.
- Returns System.String.
### huntinginfoforobject
Threat Hunting information for the object.

- There is a single argument of type System.String.
- Returns ThreatHuntInfoForObjectResponse.
### monitoringinfoforobject
Threat Monitoring information for the object.

- There is a single argument of type System.String.
- Returns ThreatMonitoringInfoForObjectResponse.
### quarantinehuntmatches
Quarantine matches for a threat hunt.

- There is a single argument of type QuarantineThreatHuntMatchesInput.
- Returns QuarantineThreatHuntMatchesReply.
### releasehuntmatchesfromquarantine
Release threat hunt matches from quarantine.

- There is a single argument of type ReleaseThreatHuntMatchesFromQuarantineInput.
- Returns ReleaseThreatHuntMatchesFromQuarantineReply.
### starthunt
Start a threat hunt on a cluster.

- There is a single argument of type StartThreatHuntInput.
- Returns StartThreatHuntReply.
### starthuntv2
Start a new threat hunt.

- There is a single argument of type StartThreatHuntV2Input.
- Returns StartThreatHuntV2Reply.
### startturbohunt
Start a new turbo threat hunt.

- There is a single argument of type StartTurboThreatHuntInput.
- Returns StartTurboThreatHuntReply.
