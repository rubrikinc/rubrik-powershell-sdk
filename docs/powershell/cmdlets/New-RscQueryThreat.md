# New-RscQueryThreat
## Subcommands
### huntdetail
The details of a threat hunt.

- There is a single argument of type System.String.
- Returns ThreatHunt.
### huntresult
The results of the Threat Hunt.

- There are 2 arguments.
    - huntId - System.String: ID of the threat hunt.
    - objectId - System.String: The ID of the object in the threat hunt.
- Returns ThreatHuntResult.
### hunts
List of Threat Hunts.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - beginTime - DateTime: Filters results that started after this time.
    - endTime - DateTime: Filters results that started before this time.
    - clusterUuidFilter - list of System.Strings: Optional list of Rubrik cluster UUIDs to filter by.
    - statusFilter - list of ThreatHuntStatuss: Optional status to filter by.
    - matchesFoundFilter - list of ThreatHuntMatchesFounds: Optionally filter by if the hunt had any matches.
    - quarantinedMatchesFilter - list of ThreatHuntQuarantinedMatchTypes: Optionally filter hunts based on whether they have quarantined matches.
- Returns ThreatHuntConnection.
### huntsummary
The summary of the threat hunt.

- There is a single argument of type System.String.
- Returns ThreatHuntSummaryReply.
