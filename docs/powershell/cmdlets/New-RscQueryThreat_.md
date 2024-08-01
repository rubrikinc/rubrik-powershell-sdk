# New-RscQueryThreat
## Subcommands
### feeds
List the threat feeds.

- The feeds subcommand takes no arguments.
- Returns ListThreatFeedsResponse.
### huntdetail
The details of a threat hunt.

- There is a single argument of type System.String.
- Returns ThreatHunt.
### huntdetailv2
The details of a threat hunt v2.

- There is a single argument of type System.String.
- Returns ThreatHuntDetailsV2.
### huntingobjectmatchedfiles
List of matched files for an object for a specified threat hunt.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - huntId - System.String: ID of the threat hunt.
    - objectFid - System.String: FID of the object.
    - filenameSearchFilter - System.String: Optional filename search.
    - quarantinedFileMatchFilter - ThreatHuntQuarantinedMatchType: Optionally filter matches based on whether they are quarantined or not.
- Returns ThreatHuntingObjectFileMatchConnection.
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
### huntstatus
The status of the Threat Hunt.

- There is a single argument of type System.String.
- Returns AsyncRequestStatus.
### huntsummary
The summary of the threat hunt.

- There is a single argument of type System.String.
- Returns ThreatHuntSummaryReply.
### huntsummaryv2
The summary of the threat hunt.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - huntId - System.String: ID of the threat hunt.
    - objectTypeFilter - list of System.Strings: Optional list of object types to filter by. Should be of type ManagedObjectType.
    - quarantinedMatchesFilter - ThreatHuntQuarantinedMatchType: Optionally filter hunts based on whether they have quarantined matches.
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
List of matched files for an object for Continuous Threat Monitoring.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - objectFid - System.String: FID of the object.
    - filenameSearchFilter - System.String: Optional filename search.
- Returns FileMatchConnection.
### monitoringmatchedobjects
List of matched objects for Continuous Threat Monitoring.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - beginTime - DateTime: Filters results that started after this time.
    - endTime - DateTime: Filters results that started before this time.
    - clusterUuidFilter - list of System.Strings: Optional list of Rubrik cluster UUIDs to filter by.
    - objectTypeFilter - list of System.Strings: Optional list of object types to filter by. Should be of type ManagedObjectType.
    - workloadNameSearch - System.String: Optional object name search filter to apply.
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
