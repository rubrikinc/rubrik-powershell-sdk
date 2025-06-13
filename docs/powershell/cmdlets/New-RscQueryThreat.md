# New-RscQueryThreat
## Subcommands
### analyticsenablement
Retrieves the enablement status of cloud-native accounts for Data Threat Analytics features.

- The analyticsenablement subcommand takes no arguments.
- Returns ThreatAnalyticsEnablement.
### feeds
List the threat feeds.

- The feeds subcommand takes no arguments.
- Returns ListThreatFeedsResponse.
### huntdetail
The details of a threat hunt.

- There is a single argument of type System.String.
- Returns ThreatHunt.
### huntdetailv2
The details of a threat hunt.

- There is a single argument of type System.String.
- Returns ThreatHuntDetailsV2.
### huntingobjectmatchedfiles
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
### huntmatchedsnapshots
List of matched snapshots for a set of file matches.

- There are 3 arguments.
    - huntId - System.String: ID of the threat hunt.
    - objectFid - System.String: FID of the object.
    - matchIds - list of System.Int64s: IDs of the matched files.
- Returns ThreatHuntMatchedSnapshotsReply.
### huntobjectmetrics
Aggregated object metrics for a threat hunt.

- There is a single argument of type System.String.
- Returns ThreatHuntObjectMetricsReply.
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
### huntsummary
The summary of the threat hunt.

- There is a single argument of type System.String.
- Returns ThreatHuntSummaryReply.
### huntsummaryv2
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
### monitoringmatchedfiledetails
Details of the Threat Monitoring matched file.

- There is a single argument of type System.Int64.
- Returns ThreatMonitoringFileMatchDetailsReply.
### monitoringmatchedfiledetailsv2
Details of the Threat Monitoring matched file.

- There are 2 arguments.
    - matchedSnapshotFid - System.String: FID of the snapshot where threat monitoring match was found.
    - filepath - System.String: Path of the file.
- Returns ThreatMonitoringFileMatchDetailsV2.
### monitoringmatchedfiles
List of matched files for an object for Threat Monitoring.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - objectFid - System.String: FID of the object.
    - filenameSearchFilter - System.String: Optional filename search.
- Returns FileMatchConnection.
### monitoringmatchedobjects
List of matched objects for Threat Monitoring.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - beginTime - DateTime: Filters results that started after this time.
    - endTime - DateTime: Filters results that started before this time.
    - clusterUuidFilter - list of System.Strings: Optional list of Rubrik cluster UUIDs to filter by.
    - objectTypeFilter - list of System.Strings: Optional list of object types to filter by. Should be of type ManagedObjectType.
    - workloadNameSearch - System.String: Optional object name search filter with partial match.
    - matchTypeFilter - list of IndicatorOfCompromiseKinds: Filters by the type of match.
- Returns ThreatMonitoringMatchedObjectConnection.
### monitoringobjectenablementstats
Threat Monitoring object enablement stats.

- There is a single argument of type DateTime.
- Returns GetThreatMonitoringObjectEnablementStatsResponse.
### monitoringobjects
Object level stats for threats found.

- There is a single argument of type DateTime.
- Returns ThreatMonitoringObjects.
### validatebulkhunt
Validates a bulk threat hunt request.

- There is a single argument of type ValidateBulkThreatHuntInput.
- Returns ValidateBulkThreatHuntResponse.
