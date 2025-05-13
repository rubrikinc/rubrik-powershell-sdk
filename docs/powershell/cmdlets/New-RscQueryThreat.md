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
