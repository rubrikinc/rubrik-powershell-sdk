# How To Create a Query

## Overview

A query is defined by three elements:

1. **The GraphQL query name** — which operation to run
   (e.g., `clusterConnection`, `slaDomains`)
2. **Variables** — parameters passed to the operation
   (e.g., how many results, filters)
3. **Fields** — what data to return
   (the SDK selects sensible defaults automatically via
   [AutoField](./autofield.md))

## 1 — Find the Query Name

### You're exploring by keyword

```powershell
Get-RscCmdlet cluster          # search by keyword
Get-RscCmdlet sla              # another example
Get-RscCmdlet -ExactMatch clusterConnection   # exact lookup
```

### You already know the GraphQL query name

Use it directly:

```powershell
$q = New-RscQuery -GqlQuery clusterConnection
```

### You have a raw GraphQL string or file

```powershell
# Inline string
Invoke-Rsc -GqlQuery "query { clusterConnection { nodes { id name } } }"

# From a file
$gql = Get-Content -Path ./my-query.gql -Raw
Invoke-Rsc -GqlQuery $gql
```

## 2 — Set Variables

### See what variables are available

```powershell
$q = New-RscQuery -GqlQuery clusterConnection
$q.Var                    # list all variables
$q.Var.Example()          # show example values
$q.Info()                 # full operation info (variables + field types)
```

### Pass variables inline

```powershell
$q = New-RscQuery -GqlQuery clusterConnection -Var @{ first = 3 }
```

### Set variables on the query object

```powershell
$q = New-RscQuery -GqlQuery clusterConnection
$q.Var.first = 3
$q.Var.sortBy = "REGISTERED_AT"
```

Variables that are not set default to null and are omitted from the
request. Only required variables must be set.

## 3 — Control Field Selection

The SDK automatically selects fields using [AutoField](./autofield.md).
For most queries, the defaults are sufficient — just invoke the query.

### Use the defaults (most common)

```powershell
$q = New-RscQuery -GqlQuery clusterConnection
$q | Invoke-Rsc    # returns id, name, status, type, etc.
```

### Choose a field profile

```powershell
# More fields (depth ≤ 1 expansion)
$q = New-RscQuery -GqlQuery clusterConnection -FieldProfile DETAIL

# Nearly all fields (can be very large)
$q = New-RscQuery -GqlQuery clusterConnection -FieldProfile FULL
```

### Add or remove specific fields

```powershell
$q = New-RscQuery -GqlQuery clusterConnection `
    -AddField Nodes.SnapshotCount, Nodes.GeoLocation.Address `
    -RemoveField Nodes.Status
```

### Discover what fields are available

```powershell
# List all valid field paths
New-RscQuery -GqlQuery clusterConnection -ValidPatchSet

# Search for a specific field
New-RscQuery -GqlQuery clusterConnection -ValidPatchSet |
    Where-Object { $_ -match "snapshot" }
```

### Use a field object for full manual control

```powershell
$fieldObj = Get-RscType -Name ClusterConnection -InitialProperties @(
    "Nodes.Id", "Nodes.Name", "Nodes.Version"
)
$q = New-RscQuery -GqlQuery clusterConnection -Field $fieldObj -FieldProfile EMPTY
```

See [AutoField](./autofield.md) for full details on profiles, patches,
and field objects.

## 4 — Run the Query

```powershell
# Pipe to Invoke-Rsc
$q | Invoke-Rsc

# Or call .Invoke() on the query object
$q.Invoke()

# One-liner
(New-RscQuery -GqlQuery clusterConnection | Invoke-Rsc).Nodes | Select-Object Id, Name
```

## Examples

### List clusters with snapshot counts

```powershell
$result = New-RscQuery -GqlQuery clusterConnection `
    -Var @{ first = 5 } `
    -AddField Nodes.SnapshotCount |
    Invoke-Rsc

$result.Nodes | Select-Object Name, SnapshotCount, Status
```

### Get CDM upgrade info

```powershell
$result = New-RscQuery -GqlQuery clusterConnection `
    -Var @{ first = 1 } `
    -AddField Nodes.CdmUpgradeInfo |
    Invoke-Rsc

$result.Nodes[0].CdmUpgradeInfo | Remove-NullProperties
```

### Inspect the generated GraphQL

```powershell
$q = New-RscQuery -GqlQuery clusterConnection -AddField Nodes.SnapshotCount
$q.GqlRequest().Query    # see the full query text
```

## Related Documentation

- [AutoField](./autofield.md) — how field profiles and patches work
- [Retrieving Interface Fields](./retrieving_interface_fields.md) —
  working with GraphQL interfaces and composite objects
- [Developer Manual](./developer_manual.md) — getting started,
  cmdlet overview
