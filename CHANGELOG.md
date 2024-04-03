# Changelog

## Version 0.30

Fixes:

- `-AddField` and `-RemoveField` now expand interfaces.
- Get-RscMssqlAvailabilityGroup - Now works for returning back list or by name.
- Get-RscMssqlLogShipping - Now works and no longer references Live Mount
- Remove-RscMssqlLogShippingSecondary - Now works and no longer references Live Mount
- Patched clusterConnection DETAIL profile.
- Added support for subfield arguments

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

