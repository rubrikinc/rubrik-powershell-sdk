# New-RscQueryThreatHunt
## Subcommands
### detail
The details of a threat hunt.

- There is a single argument of type System.String.
- Returns ThreatHunt.
### detailv2
The details of a threat hunt.

- There is a single argument of type System.String.
- Returns ThreatHuntDetailsV2.
### ingobjectmatchedfiles
List of matched files for an object for a specified threat hunt.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - huntId - System.String: ID of the threat hunt.
    - objectFid - System.String: FID of the object.
    - filenameSearchFilter - System.String: Optional filename search.
    - quarantinedFileMatchFilter - ThreatHuntQuarantinedMatchType: Optionally filter matches based on whether they are quarantined.
    - threatHuntMatchedFilesSort - ThreatHuntMatchedFilesSort: Sorts threat hunt matched files.
- Returns ThreatHuntingObjectFileMatchConnection.
### matchedsnapshots
List of matched snapshots for a set of file matches.

- There are 3 arguments.
    - huntId - System.String: ID of the threat hunt.
    - objectFid - System.String: FID of the object.
    - matchIds - list of System.Int64s: IDs of the matched files.
- Returns ThreatHuntMatchedSnapshotsReply.
### objectmetrics
Aggregated object metrics for a threat hunt.

- There is a single argument of type System.String.
- Returns ThreatHuntObjectMetricsReply.
### result
The results of the Threat Hunt.

- There are 2 arguments.
    - huntId - System.String: ID of the threat hunt.
    - objectId - System.String: The ID of the object in the threat hunt.
- Returns ThreatHuntResult.
### s
List of Threat Hunts.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - beginTime - DateTime: Filters results that started after this time.
    - endTime - DateTime: Filters results that started before this time.
    - clusterUuidFilter - list of System.Strings: Optional list of Rubrik cluster UUIDs to filter by.
    - statusFilter - list of ThreatHuntStatuss: Optional status to filter by.
    - matchesFoundFilter - list of ThreatHuntMatchesFounds: Optionally filter by if the hunt had any matches.
    - quarantinedMatchesFilter - list of ThreatHuntQuarantinedMatchTypes: Optionally filter hunts based on whether they have quarantined matches.
- Returns ThreatHuntConnection.
### summary
The summary of the threat hunt.

- There is a single argument of type System.String.
- Returns ThreatHuntSummaryReply.
### summaryv2
The summary of the threat hunt.

- There are 11 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - huntId - System.String: ID of the threat hunt.
    - objectTypeFilter - list of System.Strings: Optional list of object types to filter by. Should be of type ManagedObjectType.
    - matchesFoundFilter - ThreatHuntMatchesFound: Optionally filter by if the hunt had any matches.
    - quarantinedMatchesFilter - ThreatHuntQuarantinedMatchType: Optionally filter hunts based on whether they have quarantined matches.
    - threatHuntSummaryFilters - ThreatHuntSummaryFiltersInput: Filters to apply to the threat hunt summary.
    - threatHuntSummarySort - ThreatHuntSummarySort: Sorts threat hunt object summaries.
    - workloadNameSearch - System.String: Optional object name search filter with partial match.
- Returns ThreatHuntResultObjectsSummaryConnection.
### validatebulk
Validates a bulk threat hunt request.

- There is a single argument of type ValidateBulkThreatHuntInput.
- Returns ValidateBulkThreatHuntResponse.
