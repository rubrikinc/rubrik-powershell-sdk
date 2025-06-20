# New-RscQueryArchival
## Subcommands
### featurepermissionfordatacenterrolebased
Retrieves a list of AWS permissions required for Data Center Role Based Archival that is based on the selected permission groups.

- There is a single argument of type list of PermissionsGroups.
- Returns FeaturePermission.
### hierarchyobjectrecoverytarget
Returns a single hierarchy object to be used as a recovery target. Permission checks are performed against the ProvisionOnInfrastructure operation, not the ViewInventory operation.

- There is a single argument of type System.String.
- Returns HierarchyObject.
### istotpmandatoryintargetversion
Checks whether enabling Time-based, One-Time Password (TOTP) is mandatory in the target Rubrik CDM upgrade version.

- There is a single argument of type System.String.
- Returns System.Boolean.
### perobjectinfo
Get archival information for all objects with data archived to the specified location.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - ArchivalPerObjectInfoSortByField: Specifies the field by which the list of archival object info will be sorted.
    - filter - list of ArchivalPerObjectInfoFilterInputs: Specifies how to filter the list of archival object info.
    - input - System.String: Corresponds to ID of the target in Rubrik.
- Returns ArchivalObjectInfoConnection.
### rcslocationsconsumptionstats
RCS Azure archival location consumption stats.

- There is a single argument of type RcsConsumptionStatsInput.
- Returns RcsAzureArchivalLocationsConsumptionStatsOutput.
### storageusage
Storage usage of an archival location.

- There are 2 arguments.
    - input - System.String: Corresponds to ID of the target in Rubrik.
    - lookBackWindow - LookBackWindow: Lookback window defines how far back in time to look for a specific archival-related metric.
- Returns list of ArchivalStorageUsages.
### target
- There is a single argument of type System.String.
- Returns Target.
### targetmapping
- There is a single argument of type System.String.
- Returns TargetMapping.
### targetmappings
List all target mappings.

- There are 5 arguments.
    - sortBy - ArchivalGroupQuerySortByField: Specification on how to sort a list of target mappings.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of TargetMappingFilterInputs: Specification on how to filter a list of target mappings.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
    - isRcsStatsRequired - System.Boolean: Corresponds to rcs stats flag, only true value will add rcs stats in response.
- Returns list of TargetMappings.
### targets
All archival locations.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - ArchivalLocationQuerySortByField: Specifies the field by which the list of targets will be sorted.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of TargetFilterInputs: Specifies how to filter the list of targets.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
- Returns TargetConnection.
