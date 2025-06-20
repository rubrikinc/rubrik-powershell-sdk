# Changelog

## Version 1.13.1

Schema Update:

See [API Changelog](https://rubrikinc.github.io/rubrik-api-documentation/changelog/changes/)
for API additions, deprecations and breaking changes.

## Version 1.13.0

New Features:

Multi-DC MSSQL database management

Manage the protection for these multi-DC replicas as a single linked group. Two new cmdlets have been introduced for this:

`Get-RscMssqlLinkedAvailabilityGroup` - This cmdlet will show the linked status for any replica availability groups across multiple Rubrik clusters.

`Protect-RscLinkedWorkload` - This cmdlet manages linking replica availability groups or databases and SLA assignment for the linked group.

Fixes:

- `Get-RscMssqlDatabaseRecoveryPoint -LastFull` was previously returning the snapshot date, which is not the same as the recovery date, resulting in recoveries that would still perform log recoveries in addition to the snapshot recovery. The cmdlet has been updated to get use the correct time property.

- `Get-RscSnapshot` has been updated to include `MssqlAppMetadata.EndBackupTimestampMs`, needed to get the SQL recovery time for snapshot restores. The cmdlet has also been refactored to make future modifications easier.

- New cmdlet `Get-RscMssqlLinkedAvailabilityGroup`

Breaking Changes:

## Version 1.12.7

Schema Update:

See [API Changelog](https://rubrikinc.github.io/rubrik-api-documentation/changelog/changes/)
for API additions, deprecations and breaking changes.

Fixes:

- Get-RscSnapshot now retrieves snapshots for MSSQL databases. MSSQL database snapshots are tied to the DAG ID, not the ID of the object. Pipeline support now works with Get-RscMssqlDatabase:

```powershell
# Retrieve all snapshots for "example" database
Get-RscMssqlDatabase -Name "example" -Relic:$false -Replica:$false | Get-RscSnapshot
```

- Protect-RscWorkload now works with MSSQL databases. MSSQL database protection is tied to the DAG ID, not the ID of the object.

```powershell
# Assign "example" database to the Bronze SLA
Get-RscMssqlDatabase -Name "example" -Relic:$false -Replica:$false | Protect-RscWorkload -Sla (Get-RscSla Bronze)
```

## Version 1.12.6

Schema Update:

See [API Changelog](https://rubrikinc.github.io/rubrik-api-documentation/changelog/changes/)
for API additions, deprecations and breaking changes.

Fixes:

- Bugfix in StartRscManagedVolume and StopRscManagedVolume

Breaking Changes:

- Up to 1.12.5, when creating an empty Query object with `-FieldProfile EMPTY`, the object
  was automatically populated with minimum fields (with the AutoField feature), since
  an empty query is invalid. Starting in 1.12.6, we changed the rationale with empty
  Query objects: when you now create an empty Query object with `-FieldProfile EMPTY`,
  the object does contain an empty query. It is then up to the user to populate the
  fields manually in that query. We believe it is a better model. However, it implies
  that anybody who had scripts purposely creating an empty Query object (expecting
  AutoField to give them some field specification) and sending it as-is to the API
  server, will now break. Note though that it is a very peculiar scenario: if you
  wanted to created an auto-filled object, you'd give `-FieldProfile DEFAULT`, 
  or rather, not specify any field profile since it defaults to `DEFAULT`. 

## Version 1.12.5

Schema Update:

See [API Changelog](https://rubrikinc.github.io/rubrik-api-documentation/changelog/changes/)
for API additions, deprecations and breaking changes.

Fixes:

- Fixed compatibility with PowerShell 5

## Version 1.12.4

Schema Update:

See [API Changelog](https://rubrikinc.github.io/rubrik-api-documentation/changelog/changes/)
for API additions, deprecations and breaking changes.

## Version 1.12.3

Schema Update:

See [API Changelog](https://rubrikinc.github.io/rubrik-api-documentation/changelog/changes/)
for API additions, deprecations and breaking changes.

Fixes:

- Fixed multiple CVEs in dependencies

## Version 1.12.2

Schema Update:

See [API Changelog](https://rubrikinc.github.io/rubrik-api-documentation/changelog/changes/)
for API additions, deprecations and breaking changes.

New Features:

- `Get-RscType` now has auto-completion for `-Name` parameter.

Fixes:

- E2E test fixes
  [#171](https://github.com/rubrikinc/rubrik-powershell-sdk/pull/171)
  [#170](https://github.com/rubrikinc/rubrik-powershell-sdk/pull/170)
- Generated documentation fixes
  [#169](https://github.com/rubrikinc/rubrik-powershell-sdk/pull/169)
- Fix `Get-RscSla` when using `-id`
  [#168](https://github.com/rubrikinc/rubrik-powershell-sdk/pull/168)
- Fix `Get-RscMssqlInstance` fields to account for API changes
  [#167](https://github.com/rubrikinc/rubrik-powershell-sdk/pull/167)

## Version 1.12.1

New Features:

- schema update

Fixes:

- Bugfix for `Get-RscVmwareVm`

## Version 1.12

New Features:

- Get-RscSla now retrieves all fields required to update or create SLA Domains.
- Set-RscSla allows pipeline input of SLA object, allowing full SLA domain automation.
- Get-RscNutanixVm can now filter by cluster.
- Get-RscVmwareVm can now filter by organization.
- Get-RscMssqlInstance can now filter out relics and replicated objects (replicas) with -Relic:$false -Replica:$false
- Get-RscMssqlDatabase can now filter out relics and replicated objects (replicas) with -Relic:$false -Replica:$false
- Register-RscRubrikBackupService now supports adding physical hosts by hostname.
- Get-RscNasSystem no longer requires -id parameter
- Get-RscNasShare no longer requires -id parameter
- New Get cmdlets
  - Get-RscArchivalLocation
  - Get-RscAzureNativeVm
  - Get-RscCloudNativeTagRule
  - Get-RscDb2Database
  - Get-RscDb2Instance
  - Get-RscHypervVm
  - Get-RscMongoCollection
  - Get-RscMongoDatabase
  - Get-RscMongoSource
  - Get-RscOracleDatabase
  - Get-RscOracleHost
  - Get-RscSapHanaDatabase
  - Get-RscSapHanaSystem
  - Get-RscAwsNativeEc2Instance

Fixes:

- Get-RscSnapshot no longer throws an exception due to overfetch of fields.
- New-RscSla now properly adds arguments to query.
- Get-RscOrganization correctly retrieves organizations by name
- Fixed format widths on some table views
- Added table formatting to cmdlets. You can revert back to list view with `<cmdlet>` | Format-List

## Version 1.11.2

Schema update.

## Version 1.11

Schema update.

## Version 1.10

- Updated schema,
- Documentation fixes.

## Version 1.9

Fixes:

- Get-RscFileSet : fix arg assignment in nested query
  [#134](https://github.com/rubrikinc/rubrik-powershell-sdk/pull/134)

## Version 1.8

New Features:

- Get-RscVmwareVm now takes a cluster object via pipeline. e.g. `Get-RscCluster "foo" | Get-RscVmwareVm`
- Add snapshotconsistencylevel to vSphereVM fields that are fetched from API.

Fixes:

- Fixed issue with publishing SDK to PowerShell Gallery due to
  PowerShell 5.1 dependencies issues.
- Fixed an issue with access token auto-renewal not being saved in the
  PowerShell session (rseulting in multiple token renew calls).
- Corrected the -Relic switch in Get-RscVmwareVm to properly filter on relic status.
- Fixed an issue with mapping UNKNOWN values to schema enums.

## Version 1.7

Fixes:

- SDK dependencies updated because of vulnerabilities
  (System.IdentityModel.Tokens.Jwt 6.22.1 -> 7.6.2,
   System.Runtime.CompilerServices.Unsafe 4.5.3 -> 6.0.0)

## Version 1.6

New Features:

- Get-RscOrganization cmdlet

Fixes:

- Get-RscPermission cmdlet parameters

## Version 1.5

New Features:

- Get-RscWorkload cmdlet - Retrieves information about any supported workload type, with various filtering capabilities.
- Get-RscVmwareVm - Added -Relic switch. Use -Relic:$false to filter out Relics. -Relic will return only Relics. No usage of -Relic will return all (default operation). -Name parameter is now position 0, so you don't have to specify -Name.
- Get-RscNutanixVm - New cmdlet to get Nutanix VMs
- Register-RscRubrikBackupService - New cmdlet to register RBS on VMs
- Get-RscRole - Gets list of RSC Roles
- Get-RscPermission - Gets list of RSC Permissions from Role
- New-RscPermission - Creates new RSC Permission object
- Merge-RscPermission - Merges an RSC Permission object into a Role object
- Set-RscRole - Updates a Role in RSC with a Role object
- New-RscSla - Now accepts -DailySchedule as a parameter

Fixes:

- Issue [#112](https://github.com/rubrikinc/rubrik-powershell-sdk/issues/112)

Breaking Changes:

- Removed legacy Get-RscVsphereVm CS cmdlet. Please use Get-RscVmwareVm.

## Version 1.4

New Features:

- Set-RscNasShare and Set-RscNasSystem for updating NAS shares and systems.
- Remove-RscNasShare and Remove-RscNasSystem for removing NAS shares and systems.
- Get-RscNasSystem for getting details of NAS systems.
- New-RscNasSystem for registering a new NAS system with RSC.
- Schema Update

Fixes:

- Issue [#86](https://github.com/rubrikinc/rubrik-powershell-sdk/issues/86)
- Issue [#96](https://github.com/rubrikinc/rubrik-powershell-sdk/issues/96)

Breaking Changes:

- Get-RscNasShare - NasShareId parameter has been renamed to Id.
- Get-RscNasShare no longer accepts NasSystemId. Pass a NAS system type obtained from Get-RscNasSystem to retrieve details of all NAS shares on a NAS system.
- New-RscNasShare - NasSourceId parameter has been renamed to NasSystemId.

## Version 1.3

Schema Update

## Version 1.2

Fixes:

- Get-RscSnapshot - Fixed permissions issue.
- New-RscMutationVsphere -Operation CreateAdvancedTag - Select fields by default.

## Version 1.1

New Features:

- New-RscNasShare cmdlet (and its companion New-RscNasShareInput cmdlet to build the input arguments).

Fixes:

- Fix to Get-RscMssqlInstance to address Issue #79
- Fix to Get-RscMssqlInstance to address Issue #73
- Fix to Get-RscMssqlDatabase to address Issue #75
- Fix to Get-RscMssqlDatabase to address Issue #77
- Fix to Get-RscMssqlAvailabilityGroup to address Issue #74
- Fix to Get-RscSnapshot (SnapshotListQuery)

Breaking Changes:

- Type object's Next() method was renamed GetNext() to follow
  PowerShell naming convention (and to make it clear that
  `$obj.Next() = $x` can't work (but `$obj.SetNext($x)` does.)).
- Protect-RscSnappable renamed to Protect-RscWorkload to conform to marketing language
- Removed Backup-RscSlaDomain.ps1 (Backup-SlaDomain) as it did not conform to PowerShell naming standards. Please use Protect-RscWorkload to assign an SLA.

## Version 1.0

New Features:

- Set-RscMssqlAvailabilityGroup - Allows for assigning an SLA to an AG

Fixes:

- Set-RscMssqlDatabase - Fixed issue when setting values for database properties. 
- Get-RscMssqlLogShipping - Fixed issue where RscCluster was always required. Now it is only required when supplying other values. 
- Set-RscMssqlInstance - Fixed help text.
- Fixed input variables in Windows PowerShell.
- Get-RscSla using -Id parameter workaround. Now returns Name and Id.
- Get-RscSla now properly populates the protected object count.

## Version 0.30

New Features:

- Added support for subfield arguments

Fixes:

- `-AddField` and `-RemoveField` now expand interfaces.
- Get-RscMssqlAvailabilityGroup - Now works for returning back list or by name.
- Get-RscMssqlLogShipping - Now works and no longer references Live Mount
- Remove-RscMssqlLogShippingSecondary - Now works and no longer references Live Mount
- Patched clusterConnection DETAIL profile.
- More details in Get-Help Invoke-Rsc

Breaking Changes:

- Get-RscMssqlInstance - No longer accepts RscHost object any more. Not it accepts a string value for HostName and WindowsClusterName. This is because, there is no value in the RscHost object for getting the MSSQL Instance object as the only option is to query by name and not by ID. Additionally, we need the ability to search for a Instance based on a Windows Cluster Name. This new approach allows for a simpler user experience, as they do not need to make an extra call to get a Host object before requesting the Instance object.
- Added support for fields of type `Long`

## Version 0.29

New Features:

- Toolkit: Operations (patch files) are now part of Toolkit
- AutoFieldSpec: patch file for `QueryCdmMssqlLogShippingTargets`
- AutoFieldSpec: patch file for `QueryMssqlDatabaseLiveMounts`
- [README](https://github.com/rubrikinc/rubrik-powershell-sdk/blob/devel/Toolkit/Operations/README.md)
  on how to write patch files.

Fixes:

- Fix for queries that return a single interface object.
  See `Tests/unit/Sla.Tests.ps1`.
  (implemented with _type composition_ in the C# core)

## Version 0.28

New Features:

- Added pipe support for SLA Cmdlets
  [From PR 57](https://github.com/rubrikinc/rubrik-powershell-sdk/pull/57)

Fixes:

- Updated help texts
  [From PR 53](https://github.com/rubrikinc/rubrik-powershell-sdk/pull/53)
- Fixed build and tests for PowerShell 5.1

## Version 0.27

Fixes:

- Fixed an issue in which certain GraphQL calls responded with
  `Unable to cast object of type 'Newtonsoft.Json.Linq.JValue'
  to type 'Newtonsoft.Json.Linq.JObject'.`
- Updated help text in New-RscMssqlExport

New Features:

Breaking Changes:

## Version 0.26

Fixes:

- Limited the number of valid fields displayed in errors from
  `AddField` to 10 to prevent the terminal from being flooded.

## Version 0.25

New Features:

- New _MsSql_ API Operation:
  `DeleteLogShipping`
- New Cmdlets for working with SLAs:
  `Set-RscSla`, `Remove-RscSla`, `Resume-RscSla`, `Suspend-RscSla`,
  `New-RscSlaArchivalSpecs`, `New-RscSlaBackupWindow`, `New-RscSlaDuration`,
  `New-RscSlaObjectSpecificConfig`, `New-RscSlaReplicationSpecs`

Breaking Changes:

- `Get-RscSlaDomain` and `New-RscSlaDomain` Cmdlets have been renamed.
   The new names are `Get-RscSla` and `New-RscSla` respectively.
- `New-RscSnapshotSchedule` Cmdlet has been renamed to
  `New-RscSlaSnapshotSchedule`.

## Version 0.24

New Features:

- MsSql cmdlets
  [From PR 34](https://github.com/rubrikinc/rubrik-powershell-sdk/pull/34)
- New-RscSlaDomain and New-RscSnapshotSchedule cmdlets
  [From PR 39](https://github.com/rubrikinc/rubrik-powershell-sdk/pull/39)

## Version 0.23

New Features:

- Get cmdlets for SLAs and vSphere VMs
  [From PR 27](https://github.com/rubrikinc/rubrik-powershell-sdk/pull/27)
  [From PR 33](https://github.com/rubrikinc/rubrik-powershell-sdk/pull/33)
- MsSql cmdlets
  [From PR 30](https://github.com/rubrikinc/rubrik-powershell-sdk/pull/30)

## Version 0.22

New Features:

- New _Archival_ API Domain:
  `New-RscQueryArchival` and `New-RscMutationArchival`.
- New _Cross Account_ API Domain:
  `New-RscQueryCrossAccount` and `New-RscMutationCrossAccount`.
- New _Syslog_ API Domain:
  `New-RscQuerySyslog` and `New-RscMutationSyslog`.

Fixes:

- Fixed issue with sharing connection with nested powershell scripts.

Breaking Changes:

- The _Cluster_ API Domain became too large and was split into 2 domains:
  _Cluster_ and _Failover Cluster_. See:
  `New-RscQueryFailoverCluster` and `New-RscMutationFailoverCluster`.

## Version 0.21

Fixes:

- Fixed bug in `New-RscQuery` and `New-RscMutation` that caused
  GraphQL operations that were not associated with an API domain
  to fail. All GraphQL operations that were not associated with
  an API domain are now associated with the `Misc` domain.

## Version 0.20

New Features:

- `Invoke-Rsc` now handles paging internally.
  This means that you can now use `Invoke-Rsc` to retrieve
  all items in a list, without having to use `Get-RscPages`.
  For example, to retrieve all clusters:
  `Invoke-Rsc (New-RscQueryCluster -Op List)`
  or
  `(New-RscQueryCluster -Op List).Invoke()`.
  Note that `Invoke()` internally calls `Invoke-Rsc`.
  To retrieve 1 cluster:
  `Invoke-Rsc (New-RscQueryCluster -Op List -Var @{first=1})`
  To retrieve 1,000,000 clusters:
  `Invoke-Rsc (New-RscQueryCluster -Op List -Var @{first=1000000})`
- `Info()` on query object is now more verbose.

Breaking Changes:

- `Get-RscPages` is sunset.
  It is replaced by `Invoke-Rsc` which now handles paging internally.
- `VarTemplate()` on query object is sunset.
  It is replaced by `Example()` which is more complete.

## Version 0.19

New Features:

- The SDK now imposes limits on page sizes when retrieving lists
  from the API. The new default is 50 items per page.
  Note that it should not result in any behavior change for users
  as long as they collect pages with `Get-RscPages` (or
  iterate manually through them). It will cause problems to scripts
  that assumed that the API would return all items in a single
  response and their deployment lists more than 50 items.

Breaking Changes:

- `Get-RscPages` now takes for parameter a `RscQuery` object
  instead of a script block. See `Get-Help Get-RscPages` for details.

## Version 0.18.2

Fixes:

- Fix install on Windows.
- Removed format files for MssqlDatabase and VsphereVm.

## Version 0.18

Fixes:

- Fix case sensitivity issue with documentation files.
- Fix install on Linux.
  
## Version 0.17

New Features:

New toolkit scripts:

- Backup-SlaDomain
- Export-RscMssqlDatabase
- Get-RscManagedVolume
- Get-RscMssqlAvailabilityGroup
- Get-RscMssqlDatabaseFiles
- Get-RscMssqlDatabase
- Get-RscMssqlDatabaseRecoverableRanges
- Get-RscMssqlDatabaseRecoveryPoint
- Get-RscMssqlInstance
- Get-RscMssqlLiveMount
- New-RscMssqlLiveMount
- New-RscMssqlLogBackup
- New-RscMssqlRestore
- New-RscMssqlSnapshot
- Remove-RscMssqlLiveMount
- Set-RscMssqlDatabase
- Start-RscManagedVolumeSnapshot
- Stop-RscManagedVolumeSnapshot

## Version 0.16

New Features:

- New methods on Field objects: `SelectedFields()`,
  `UnselectedFields()` and `AllFields()`.
- `New-RscQuery` and `New-RscMutation` for generic queries and mutations.
  For example to amend an existing query:
  `$query = New-RscQuery -Copy $query -AddField ..`
  or to create a new query based off a GraphQL root field:
  `New-RscQuery -GqlQuery clusterConnection -AddField ..`
- New param to `Get-RscCluster`:
  `Get-RscCluster -AsQuery` returns the query object instead of executing it.
- Total query and mutation cmdlets is now at 52,
  see: [docs/domains_and_operations.md](docs/domains_and_operations.md)

## Version 0.15

New Features:

- New cmdlet: `New-RscQueryManagedVolume` that covers the
  `ManagedVolume` API domain.
- More documentation in Get-Help for the RSC cmdlets.
  
Fixes:

- Fixed bug with passing lists of enums. For example:

```powershell
New-RscQueryVsphere -TopLevelDescendantsList -Var @{typeFilter = @(
  [RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]::WINDOWS_CLUSTER,
  [RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]::PHYSICAL_HOST)}
```

Deprecations:

Breaking Changes:

- `-Patch` was replaced with `-AddField` and `-RemoveField`
- Experimental New-RscQueryGql* cmdlets are removed

## Version 0.14

New Features:

- Refactor! This update is a major refactor of the SDK that invalidates
  all previous versions (because all cmdlet names have changed):
  
  The 2-step operation of first asking for "inputs"
  > `$inputs = Invoke-RscQuery<Domain> -<Operation> -GetInput`

  and then executing with the inputs
  > `Invoke-RscQuery<Domain> -<Operation> -Input $inputs`
  
  is now renamed to first creating a query
  > `$query = New-RscQuery<Domain> -<Operation>`

  and then executing the query
  > `$result = Invoke-Rsc $query`

  or equivalently
  > `$result = $query.Invoke()`
- _SDK Extensions_ are renamed to _SDK Toolkit_,
  and the layout under rubrik-security-cloud/Toolkit
  was reworked.

- Experimental New-RscQueryGql* cmdlets are introduced

Fixes:

Deprecations:

Breaking Changes:

- All cmdlets were renamed in the refactor.
  For example, `Invoke-RscQueryCluster` is now `New-RscQueryCluster`.
- Extensions directory was renamed to Toolkit.

## Version 0.13-beta

New Features:

- Support for PowerShell 5.1
- `Invoke-Rsc -Query` now accepts `RscQuery` objects for input.
- `RscQuery` now have an `Invoke()` method that executes the query.
- `-Patch` now has auto-completion.
- `Invoke-Rsc` now supports GraphQL query strings with
  inline variable definitions (see in its examples).
- `Get-RscHelp -LookupSchema` is an introspection tool
  to help you look up elements in the RSC GraphQL schema.

Fixes:

- Unknown elements in API server responses are now ignored
  instead of causing an error. This is useful when a newer API server
  returns new fields that are not yet in the SDK, or when
  an older API server returns fields that are not in the SDK anymore.
- Token auto-refreshes on cmdlet calls made within 5 minutes of
  token expiration.
- Fix for Invoke-RscQueryAzure commands that overlapped
  (e.g. `(Invoke-RscQueryAzure -Subscriptions -GetGqlRequest)`
  `.operationName --> QueryAzureSqlDatabase`)

Deprecations:

Breaking Changes:

- `Invoke-Rsc -Query .. -Variables ..` is renamed to
  `Invoke-Rsc -GqlQuery .. -Var ..`
- `RscCmdletInput` is renamed to `RscQuery`
- `Fetch()` is renamed `SelectForRetrieval()`

## Version 0.12-beta

New Features:

- RscCmdletInput has 2 new methods, `VarInfo()` and `Info()`
- new (advanced) documentation: `docs/graphql_model.md`
- `Fetch()` method on schema types.

Fixes:

- Fix bug in API server error reporting
- The term "Op" or "Operation" was used in the SDK where it was
  really referring to a _GraphQL Root Field_. This has been fixed.

Deprecations:

Breaking Changes:

- Assemblies are no longer installed at the root of the output
  directory, but instead in a platform subdirectory: `net472` or `net6.0`

## Version 0.11-beta

New Features:

- New Invoke parameters: `-Patch`, `-PatchFile`
- RscCmdletInput: new FieldInfo() method that returns a link to the
  online documentation for the field.
- Extension scripts now live in the `Extensions` top directory.
- `-Input` on cmdlets that accepts a `RscCmdletInput` object:
  the type you retrieve with `-GetInput`. For example:
  `$i=(Invoke-RscXxx -GetInput); ...; Invoke-RscXxx -Input $i`
- New input profile `-InputProfile FULL` which creates a field
  specification that includes all fields recursively.
  This is useful for studying/debugging and for custom operations.
  NOTE: The `FULL` profile will typically generate queries that exceed
  the query complexity limit of the API server. It is not meant to
  be sent out as-is to the API server. Instead, it is meant to be
  used as a starting point for custom operations.
- `Get-RscCmdlet -Locations` shows the various (FS) locations
  where the SDK looks for files.
- `Samples/AllCmdlets.sample.ps1` now accepts a `-GetGqlRequest` that
  will save the GraphQL query to file for _every_ command in the SDK
  into a local `./gql/` directory.
  CAUTION: This will writes hundreds of files to disk!
- New doc files: docs/faq.md, docs/input_model.md

Fixes:

- API server errors on query complexity are now bubbled up to the user
- `Invoke-RscQueryCluster -List -InputProfile DETAIL`
  and `Get-RscCluster -Detail` did not work because of _query complexity_.
  They were fixed by providing the override gql file
  `Operations/DETAIL/QueryClusterConnection.gql`
- `Remove-NullProperties` now works with null input.

Deprecations:

- `-Arg` is deprecated in favor of `-Var` (for variables).
  `-Arg` will be removed in a future release.
- `=InputProfile` is deprecated in favor of `-FieldProfile`.
  `=InputProfile` will be removed in a future release.

Breaking changes:

- Cmdlets' `-GetInputs` is renamed to `-GetInput`.
- RscGqlRequest.DefaultQueryFileName is not a method anymore but a property.

## Version 0.10-beta

New Features:

Fixes:

- `$PROFILE` is not expected to be set anymore.

Breaking changes:

- Custom operations are not expected to be in the same directory
  as `$PROFILE` anymore. Instead, the `$RSC_CUSTOM_DIR` environment
  variable is used to locate them. If this variable is not set, it
  defaults to the **current working directory**.

## Version 0.9-beta

New Features:

- `Invoke-RscQueryDb2`
- `Invoke-RscMutateDb2`
- `Get-RscHelp -CustomOperations`
- `Invoke-Rsc* -GetGqlRequest` , which returns a `RscGqlRequest` object
- `Invoke-Rsc* -InputProfile CUSTOM`
- Override of default field spec with
  `[RubrikSecurityCloud.Files]::GetSdkOperationsDir("DEFAULT")`

Fixes:

- Added `ActivitySeriesId` to Get-RscEventSeries

Breaking changes:

- `-InputProfile DETAILS` is now `-InputProfile DETAIL`
