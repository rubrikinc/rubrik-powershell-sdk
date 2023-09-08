# Changelog

## Version 0.12-beta

New Features:

- RscCmdletInput has 2 new methods, `VarInfo()` and `Info()`
- new (advanced) documentation: `docs/graphql_model.md`
- `Fetch()` method on schema types.

Fixes:

- Fix bug in API server error reporting
- The term "Op" or "Operation" was used in the SDK where it was
  really referring to a *GraphQL Root Field*. This has been fixed.

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
  will save the GraphQL query to file for *every* command in the SDK
  into a local `./gql/` directory.
  CAUTION: This will writes hundreds of files to disk!
- New doc files: docs/faq.md, docs/input_model.md

Fixes:

- API server errors on query complexity are now bubbled up to the user
- `Invoke-RscQueryCluster -List -InputProfile DETAIL`
  and `Get-RscCluster -Detail` did not work because of *query complexity*.
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
