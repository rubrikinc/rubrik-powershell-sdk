# New-RscQueryArchival
## Subcommands
### hierarchyobjectrecoverytarget
Returns a single hierarchy object to be used as a recovery target. Permission checks are performed against the ProvisionOnInfrastructure operation, not the ViewInventory operation.

- There is a single argument of type System.String.
- Returns HierarchyObject.
### istotpmandatoryintargetversion
Checks whether enabling Time-based, One-Time Password (TOTP) is mandatory in the target Rubrik CDM upgrade version.

- There is a single argument of type System.String.
- Returns System.Boolean.
### rcslocationsconsumptionstats
RCS Azure archival location consumption stats.

- There is a single argument of type RcsConsumptionStatsInput.
- Returns RcsAzureArchivalLocationsConsumptionStatsOutput.
### storageusage
Storage usage of an archival location.

- There is a single argument of type System.String.
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
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of TargetMappingFilterInputs: Specification on how to filter a list of target mappings.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
    - isRcsStatsRequired - System.Boolean: Corresponds to rcs stats flag, only true value will add rcs stats in response.
- Returns list of TargetMappings.
### targets
All archival locations.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - ArchivalLocationQuerySortByField: Specifies the field by which the list of targets will be sorted.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of TargetFilterInputs: Specifies how to filter the list of targets.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
- Returns TargetConnection.
