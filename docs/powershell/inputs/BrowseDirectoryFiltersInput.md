### BrowseDirectoryFiltersInput


- analyzerGroupIds: list of System.Strings
  - List of data categories ids to filter the paths.
- whitelistEnabled: System.Boolean
  - Whether to include whitelisted results in response.
- sensitiveDataDiscoveryScope: SensitiveDataDiscoveryScope
  - Scope for sensitive data discovery.
- sids: list of System.Strings
  - List of principal IDs to filter the paths.
- riskLevelTypesFilter: list of RiskLevelTypes
  - List of risk levels that to filter the paths.
- dataTypeIds: list of System.Strings
  - List of data type ids to filter the paths.
- lastAccessFilter: UserTimeRangeInput
  - Last access time range specified in the local timezone of the user.
- lastModifiedFilter: UserTimeRangeInput
  - Last modified time range specified in the local timezone of the user.
- creationTimeFilter: UserTimeRangeInput
  - Creation time range specified in the local timezone of the user.
- lastScanFilter: UserTimeRangeInput
  - Last scan time range specified in the local timezone of the user.
- exposureFilter: list of OpenAccessTypes
  - Filter results by exposure.
- mipLabelsFilter: list of MipLabelsFilterInputs
  - List of mip labels to filter the paths.
- documentTypesFilter: list of System.Strings
  - List of document type IDs to filter the paths.
- isObjectLevelAnalysis: System.Boolean
  - Flag to indicate if object level analysis is needed.
- aggregateAtPath: System.Boolean
  - Flag to aggregate results at the current path level instead of
returning children paths.
- aggregationScope: BrowseAggregationScope
  - Specifies the level at which to aggregate browse results.
- affectedFilesDeltaTypes: list of AffectedFilesDeltaTypes
  - Filter by specific delta types of affected files. Only applicable when
sensitive_data_discovery_scope is AFFECTED_FILES_ONLY.
- baseSnapshotId: System.String
  - Specifies the baseline snapshot against which file changes are compared
when browsing affected files. This determines the reference point for
identifying which files were added, modified, or deleted. Required when
sensitive_data_discovery_scope is SENSITIVE_DATA_DISCOVERY_SCOPE_AFFECTED_FILES_ONLY.
