# Changelog

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
