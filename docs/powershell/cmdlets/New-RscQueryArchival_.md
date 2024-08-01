# New-RscQueryArchival
## Subcommands
### bandwidthstats
Retrieve archival bandwidth statistics.

- There is a single argument of type ArchivalBandwidthStatsInput.
- Returns ArchivalBandwidthStatsReply.
### entities
List all user-created archival entities. This would include Data Center archival targets and Cloud Native archival target mappings.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - list of ArchivalEntityFilterInputs: Specifies how to filter the list of archival entities.
    - sortBy - ArchivalEntityQuerySortByField: Specifies the field by which the list of archival entities will be sorted.
    - sortOrder - SortOrder: Sort order of result.
- Returns ArchivalEntityConnection.
### hierarchyobjectrecoverytarget
Returns a single hierarchy object to be used as a recovery target. Permission checks are performed against the ProvisionOnInfrastructure operation, not the ViewInventory operation.

- There is a single argument of type System.String.
- Returns HierarchyObject.
### istotpmandatoryintargetversion
Checks whether enabling Time-based, One-Time Password (TOTP) is mandatory in the target Rubrik CDM upgrade version.

- There is a single argument of type System.String.
- Returns System.Boolean.
### locationencryptiondetails
Get all archival locations and their encryption details.

- There are 11 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sort order of result.
    - nameSearchPrefix - System.String: Prefix for searching for archival location name.
    - sortBy - QueryArchivalLocationsEncryptionDetailsSortByField: Field to sort by for archival location's encryption details.
    - archivalLocationRekeyStatusFilterArg - list of ArchivalLocationEncryptionJobStatuss: Filter based on job status of the archival location's re-key job.
    - archivalLocationRotationStatusFilterArg - list of ArchivalLocationEncryptionJobStatuss: Filter based on job status of the archival location's rotation job.
    - archivalLocationKeyTypeFilterArg - list of ArchivalLocationEncryptionKeyTypes: Filter based on the archival location's key type.
    - archivalLocationEncryptionStatusFilterArg - list of ArchivalLocationEncryptionStatusFilters: Filter based on the archival location's encryption status
- Returns ArchivalLocationEncryptionDetailsConnection.
### locationencryptionjobssummary
Get summary of all encryption jobs of an archival location.

- There is a single argument of type ArchivalLocationEncryptionJobsSummaryInput.
- Returns ArchivalLocationEncryptionJobsSummary.
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
    - sortOrder - SortOrder: Sort order of result.
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
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of TargetFilterInputs: Specifies how to filter the list of targets.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
- Returns TargetConnection.
