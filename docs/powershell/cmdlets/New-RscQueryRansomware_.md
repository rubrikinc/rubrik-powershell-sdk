# New-RscQueryRansomware
## Subcommands
### detectionworkloadlocations
Get the list of workload locations on which Ransomware Investigation has run.

- There are 3 arguments.
    - beginTime - DateTime: Filter only locations that processed workloads after this time.
    - endTime - DateTime: Filter only locations that processed workloads before this time.
    - returnOnlyForAnomalousEntities - System.Boolean: Specifies whether to return only the locations having anomalous entities or all locations.
- Returns ListLocationsReply.
### investigationanalysissummary
Get a per day summary of the radar analysis results from start day to end day.

- There are 7 arguments.
    - startDay - System.String: Start day, formatted(ISO 8601) as YYYY-MM-DD.
    - endDay - System.String: End day, formatted(ISO 8601) as YYYY-MM-DD.
    - timezone - System.String: Deprecated timezone field that will not be used. All results are in UTC.
    - objectTypeFilter - list of System.Strings: Optional list of object types to filter by. Should be of type ManagedObjectType.
    - clusterUuidFilter - list of System.Strings: Optional list of Rubrik cluster UUIDs to filter by.
    - slaFidFilter - list of System.Strings: Optional list of SLA Domain FIDs to filter by.
    - hideSuspiciousDataIfNonAnomalous - System.Boolean: Do not include the suspicious byte count or suspicious file count of non anomalous snapshots.
- Returns RansomwareInvestigationAnalysisSummaryReply.
### investigationenablement
Get the enablement status of entities on which Ransomware Monitoring can be enabled.

- The investigationenablement subcommand takes no arguments.
- Returns RansomwareInvestigationEnablementReply.
### investigationobjects
Object level stats for ransomware investigation dashboard.

- There is a single argument of type DateTime.
- Returns RansomwareInvestigationObjectsReply.
### monitoringpipelinehealth
Retrieve the ransomware monitoring pipeline health metric.

- There is a single argument of type DateTime.
- Returns RansomwareMonitoringPipelineHealth.
### monitoringtimelineanalysis
Retrieve the Ransomware Monitoring timeline analysis data.

- There is a single argument of type DateTime.
- Returns RansomwareMonitoringTimelineAnalysis.
### overallinvestigationsummary
Overall ransomware investigation summary.

- There is a single argument of type System.Int32.
- Returns OverallRansomwareInvestigationSummary.
### processedinvestigationworkloadcount
Get the number of workloads that have passed through the Radar pipeline in the past 24 hours.

- The processedinvestigationworkloadcount subcommand takes no arguments.
- Returns ProcessedRansomwareInvestigationWorkloadCountReply.
### result
Result of the Ransomware Investigation.

- There are 3 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - managedId - System.String: Workload managed ID.
    - snapshotId - System.String: Corresponds to snapshot ID in Rubrik CDM tables.
- Returns RansomwareResult.
### resultopt
Optional result of the Ransomware Investigation.

- There are 3 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - managedId - System.String: Workload managed ID.
    - snapshotId - System.String: Corresponds to snapshot ID in Rubrik CDM tables.
- Returns RansomwareResult.
### results
Results for Ransomware Investigations.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - RansomwareResultSortBy: Sort ransomware results by field.
    - filter - RansomwareResultFilterInput: Filter ransomware results by input.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns RansomwareResultConnection.
### resultsgrouped
Results for the Ransomware Investigations grouped by an argument.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - groupBy - RansomwareResultGroupBy: Group ransomware results by field.
    - filter - RansomwareResultFilterInput: Filter ransomware results by input.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns RansomwareResultGroupedDataConnection.
